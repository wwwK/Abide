﻿using Abide.HaloLibrary.IO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;

namespace Abide.HaloLibrary.Halo2BetaMap
{
    /// <summary>
    /// Represents a Halo 2 Beta binary map file.
    /// </summary>
    [Serializable]
    public sealed class MapFile : MarshalByRefObject, IDisposable
    {
        /// <summary>
        /// Represents the minimum length of a Halo 2 beta map file.
        /// This value is the sum of the length of a <see cref="Header"/> structure, and the minimum length of the index table.
        /// </summary>
        private const int MinLength = 6144;
        /// <summary>
        /// Gets or sets the Halo 2 map's name.
        /// </summary>
        [Category("Map Properties"), Description("The name of the Halo 2 map.")]
        public string Name
        {
            get { return header.Name; }
            set { header.Name = value; }
        }
        /// <summary>
        /// Gets and returns the Halo 2 map's build string.
        /// </summary>
        [Browsable(false)]
        public string Build
        {
            get { return header.Build; }
        }
        /// <summary>
        /// Gets and returns the Halo 2 map's index entry list.
        /// </summary>
        [Browsable(false)]
        public IndexEntryList IndexEntries
        {
            get { return indexList; }
        }
        /// <summary>
        /// Gets and returns the stream containing the tags' data.
        /// </summary>
        [Browsable(false)]
        public FixedMemoryMappedStream TagDataStream
        {
            get { return tagData; }
        }
        /// <summary>
        /// Gets and returns a list of the Halo 2 map's string IDs.
        /// </summary>
        [Category("Map Data"), Description("The Halo 2 map's strings.")]
        public StringList Strings
        {
            get { return strings; }
        }
        /// <summary>
        /// Gets or sets the Halo 2 map's scenario.
        /// </summary>
        [Browsable(false)]
        public IndexEntry Scenario
        {
            get { return scenario; }
            set { scenario = value; }
        }

        private Header header;
        private FixedMemoryMappedStream[] sbspTagDatas;
        private StringList strings;
        private FixedMemoryMappedStream crazyData;
        private Index index;
        private FixedMemoryMappedStream tagData;
        private IndexEntryList indexList;
        private Dictionary<TagId, int> bspIndexLookup;
        private IndexEntry scenario;

        /// <summary>
        /// Initializes a new instance of the <see cref="MapFile"/> class.
        /// </summary>
        public MapFile()
        {
            //Initialize
            header = new Header();
            index = Index.CreateDefault();
            sbspTagDatas = new FixedMemoryMappedStream[0];
            strings = new StringList();
            crazyData = FixedMemoryMappedStream.Empty;
            indexList = new IndexEntryList();
            tagData = FixedMemoryMappedStream.Empty;
            bspIndexLookup = new Dictionary<TagId, int>();
        }
        /// <summary>
        /// Loads a Halo 2 beta map file from a specified file path.
        /// </summary>
        /// <param name="filename">A relative or absolute path for the map file.</param>
        /// <exception cref="ArgumentNullException"><paramref name="filename"/> is null.</exception>
        /// <exception cref="FileNotFoundException"><paramref name="filename"/> does not exist.</exception>
        /// <exception cref="MapFileExcption">Exception occured while loading the map.</exception>
        public void Load(string filename)
        {
            //Prepare
            FileStream fs = null;

            //Check...
            if (filename == null) throw new ArgumentNullException(nameof(filename));
            else if (!File.Exists(filename)) throw new FileNotFoundException("Unable to find the specified file.", filename);

            //Open Stream...?
            try { fs = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.Read); }
            catch (Exception ex) { throw new MapFileExcption(ex); }

            //Check
            if (fs != null) { Load(fs); fs.Close(); fs.Dispose(); }
        }
        /// <summary>
        /// Loads a Halo 2 beta map file from the specified stream.
        /// </summary>
        /// <param name="inStream">The stream containing the Halo 2 map.</param>
        /// <exception cref="ArgumentNullException"><paramref name="inStream"/> is null.</exception>
        /// <exception cref="ArgumentException">Exception occured while handling <paramref name="inStream"/>.</exception>
        /// <exception cref="MapFileExcption">Exception occured while loading map.</exception>
        public void Load(Stream inStream)
        {
            //Check
            if (inStream == null) throw new ArgumentNullException(nameof(inStream));
            if (!inStream.CanRead) throw new ArgumentException("Stream does not support reading.", nameof(inStream));
            if (!inStream.CanSeek) throw new ArgumentException("Stream does not support seeking.", nameof(inStream));

            //Check file...
            if (inStream.Length < 6144)
                throw new MapFileExcption("Invalid map file.");

            try
            {
                //Create Reader
                using (BinaryReader reader = new BinaryReader(inStream))
                {
                    //Read Header
                    inStream.Seek(0, SeekOrigin.Begin);
                    header = reader.Read<Header>();

                    //Check...
                    if (header.Head != HaloTags.head || header.Foot != HaloTags.foot)    //Quick sanity check...
                        throw new MapFileExcption("Invalid map header.");

                    //Read Strings
                    strings = new StringList(reader.ReadUTF8StringTable(header.StringsOffset, header.StringsIndexOffset, (int)header.StringCount));

                    //Read Index Table
                    inStream.Seek(header.IndexOffset, SeekOrigin.Begin);
                    index = reader.Read<Index>();

                    //Read Object Entries
                    ObjectEntry[] objectEntries = new ObjectEntry[index.ObjectCount];
                    for (int i = 0; i < index.ObjectCount; i++)
                        objectEntries[i] = reader.Read<ObjectEntry>();

                    //Read Index Entries
                    IndexEntry[] indexEntries = new IndexEntry[index.ObjectCount]; string filename = null;
                    inStream.Seek(header.IndexOffset, SeekOrigin.Begin);
                    using (FixedMemoryMappedStream indexData = new FixedMemoryMappedStream(reader.ReadBytes((int)header.IndexLength), Index.IndexMemoryAddress - Index.Length))
                    using (BinaryReader indexReader = new BinaryReader(indexData))
                    {
                        //Loop
                        for (int i = 0; i < index.ObjectCount; i++)
                        {
                            //Read Filename
                            indexData.Seek(objectEntries[i].FileNameOffset, SeekOrigin.Begin);
                            filename = indexReader.ReadUTF8NullTerminated();

                            //Create Entry
                            indexEntries[i] = new IndexEntry(objectEntries[i], filename)
                            {
                                PostProcessedOffset = (int)objectEntries[i].TagDataOffset,
                                PostProcessedSize = (int)objectEntries[i].Size,
                            };
                        }
                    }

                    //Setup Index List
                    indexList = new IndexEntryList(indexEntries);

                    //Read Crazy
                    inStream.Seek(header.CrazyOffset, SeekOrigin.Begin);
                    crazyData = new FixedMemoryMappedStream(reader.ReadBytes((int)header.CrazyLength));

                    //Get Meta Memory-file address
                    uint metaFileMemoryAddress = 0, metaMemoryAddress = 0;
                    if (index.ObjectCount > 0)
                    {
                        metaFileMemoryAddress = indexList[0].Offset - (header.IndexOffset + header.IndexLength);
                        metaMemoryAddress = indexList[0].Offset;
                    }

                    //Read Meta
                    inStream.Seek(header.IndexOffset + header.IndexLength, SeekOrigin.Begin);
                    tagData = new FixedMemoryMappedStream(reader.ReadBytes((int)header.TagDataLength), metaMemoryAddress);

                    //Loop
                    foreach (IndexEntry entry in indexList)
                        if (entry.Offset != 0)
                            entry.TagData = tagData;

                    //Prepare BSP start...
                    int bspStart = (int)header.Strings128Offset;

                    //Read BSP Meta
                    if (indexList.ContainsID(index.ScenarioId))
                    {
                        //Goto
                        inStream.Seek(indexList[index.ScenarioId].Offset + 828, metaFileMemoryAddress, SeekOrigin.Begin);
                        TagBlock structureBsps = reader.ReadUInt64();
                        sbspTagDatas = new FixedMemoryMappedStream[structureBsps.Count];
                        for (int i = 0; i < structureBsps.Count; i++)
                        {
                            //Goto
                            inStream.Seek(structureBsps.Offset + (i * 86), metaFileMemoryAddress, SeekOrigin.Begin);
                            int sbspOffset = reader.ReadInt32();
                            int sbspSize = reader.ReadInt32();
                            int bspMagic = reader.ReadInt32();
                            int bspFileMagic = bspMagic - sbspOffset;
                            inStream.Seek(4, SeekOrigin.Current);
                            Tag sbspTag = reader.Read<Tag>();
                            uint sbspNameAddress = reader.ReadUInt32();
                            inStream.Seek(4, SeekOrigin.Current);
                            TagId sbspId = reader.Read<TagId>();
                            Tag ltmpTag = reader.Read<Tag>();
                            uint ltmpNameAddress = reader.ReadUInt32();
                            inStream.Seek(4, SeekOrigin.Current);
                            TagId ltmpId = reader.Read<TagId>();

                            //Add
                            bspIndexLookup.Add(sbspId, i);

                            //Goto
                            inStream.Seek(sbspOffset, SeekOrigin.Begin);
                            sbspTagDatas[i] = new FixedMemoryMappedStream(reader.ReadBytes(sbspSize), (uint)bspMagic);
                            SbspHeader sbspHeader = new SbspHeader();
                            using (BinaryReader bspHeaderReader = new BinaryReader(sbspTagDatas[i]))
                                sbspHeader = bspHeaderReader.Read<SbspHeader>();

                            //Setup SBSP and Lightmap
                            if (indexList.ContainsID(sbspId))
                            {
                                indexList[sbspId].TagData = sbspTagDatas[i];
                                indexList[sbspId].PostProcessedOffset = bspMagic;
                                indexList[sbspId].PostProcessedSize = sbspSize;
                            }
                            if (indexList.ContainsID(ltmpId))
                            {
                                indexList[ltmpId].TagData = sbspTagDatas[i];
                                indexList[ltmpId].PostProcessedOffset = sbspHeader.LightmapOffset;
                                indexList[ltmpId].PostProcessedSize = sbspHeader.DataLength - (sbspHeader.LightmapOffset - bspMagic);
                            }

                            //Check
                            if (sbspOffset < bspStart)
                                bspStart = sbspOffset;
                        }

                        //Zero-out variables
                        header.FileLength = 0;
                        header.MapDataLength = 0;

                        //Read Raws
                        ReadRaws(inStream, reader);

                        //Get Scenario
                        scenario = indexList[index.ScenarioId];
                    }
                }
            }
            catch(Exception ex) { throw ex; }
        }
        /// <summary>
        /// Attempts to read any internal raw data reference by the supplied tag group.
        /// </summary>
        /// <param name="inStream">The Halo 2 beta map file stream.</param>
        /// <param name="reader">The reader for the map stream.</param>
        private void ReadRaws(Stream inStream, BinaryReader reader)
        {
            //Null
            RawStream rawData = null;
            int rawOffset, rawSize;
            long offsetAddress, lengthAddress;

            //Handle objects...
            foreach (IndexEntry entry in indexList)
            {
                //Clear
                entry.Raws.Clear();

                //Prepare
                using (BinaryReader metaReader = new BinaryReader(entry.TagData))
                using (BinaryWriter metaWriter = new BinaryWriter(entry.TagData))
                    switch (entry.Root)
                    {
                        #region mode
                        case HaloTags.mode:
                            entry.TagData.Seek(entry.Offset + 76, SeekOrigin.Begin);
                            int sectionCount = metaReader.ReadInt32();
                            int sectionOffset = metaReader.ReadInt32();
                            for (int i = 0; i < sectionCount; i++)
                            {
                                entry.TagData.Seek(sectionOffset + (i * 104) + 64, SeekOrigin.Begin);
                                offsetAddress = entry.TagData.Position;
                                rawOffset = metaReader.ReadInt32();
                                lengthAddress = entry.TagData.Position;
                                rawSize = metaReader.ReadInt32();

                                //Check
                                if ((rawOffset & 0xC0000000) == 0)
                                {
                                    //Read
                                    inStream.Seek(rawOffset, SeekOrigin.Begin);
                                    if (entry.Raws[RawSection.Model].ContainsRawOffset(rawOffset))
                                        rawData = entry.Raws[RawSection.Model][rawOffset];
                                    else { rawData = new RawStream(reader.ReadBytes(rawSize), rawOffset); entry.Raws[RawSection.Model].Add(rawData); }
                                    rawData.OffsetAddresses.Add(offsetAddress);
                                    rawData.LengthAddresses.Add(lengthAddress);
                                }
                            }

                            entry.TagData.Seek(entry.Offset + 188, SeekOrigin.Begin);
                            int prtCount = metaReader.ReadInt32();
                            int prtOffset = metaReader.ReadInt32();
                            for (int i = 0; i < prtCount; i++)
                            {
                                entry.TagData.Seek(prtOffset + (i * 108) + 68, SeekOrigin.Begin);
                                offsetAddress = entry.TagData.Position;
                                rawOffset = metaReader.ReadInt32();
                                lengthAddress = entry.TagData.Position;
                                rawSize = metaReader.ReadInt32();

                                //Check
                                if ((rawOffset & 0xC0000000) == 0)
                                {
                                    //Read
                                    inStream.Seek(rawOffset, SeekOrigin.Begin);
                                    if (entry.Raws[RawSection.Model].ContainsRawOffset(rawOffset))
                                        rawData = entry.Raws[RawSection.Model][rawOffset];
                                    else { rawData = new RawStream(reader.ReadBytes(rawSize), rawOffset); entry.Raws[RawSection.Model].Add(rawData); }
                                    rawData.OffsetAddresses.Add(offsetAddress);
                                    rawData.LengthAddresses.Add(lengthAddress);
                                }
                            }
                            break;
                        #endregion
                        #region DECR
                        case HaloTags.DECR:
                            entry.TagData.Seek(entry.Offset + 80, SeekOrigin.Begin);
                            offsetAddress = entry.TagData.Position;
                            rawOffset = metaReader.ReadInt32();
                            lengthAddress = entry.TagData.Position;
                            rawSize = metaReader.ReadInt32();

                            //Check
                            if ((rawOffset & 0xC0000000) == 0)
                            {
                                //Read
                                inStream.Seek(rawOffset, SeekOrigin.Begin);
                                if (entry.Raws[RawSection.DecoratorSet].ContainsRawOffset(rawOffset))
                                    rawData = entry.Raws[RawSection.DecoratorSet][rawOffset];
                                else { rawData = new RawStream(reader.ReadBytes(rawSize), rawOffset); entry.Raws[RawSection.DecoratorSet].Add(rawData); }
                                rawData.OffsetAddresses.Add(offsetAddress);
                                rawData.LengthAddresses.Add(lengthAddress);
                            }
                            break;
                        #endregion
                        #region PRTM
                        case HaloTags.PRTM:
                            entry.TagData.Seek(entry.Offset + 304, SeekOrigin.Begin);
                            offsetAddress = entry.TagData.Position;
                            rawOffset = metaReader.ReadInt32();
                            lengthAddress = entry.TagData.Position;
                            rawSize = metaReader.ReadInt32();

                            //Check
                            if ((rawOffset & 0xC0000000) == 0)
                            {
                                //Read
                                inStream.Seek(rawOffset, SeekOrigin.Begin);
                                if (entry.Raws[RawSection.ParticleModel].ContainsRawOffset(rawOffset))
                                    rawData = entry.Raws[RawSection.ParticleModel][rawOffset];
                                else { rawData = new RawStream(reader.ReadBytes(rawSize), rawOffset); entry.Raws[RawSection.ParticleModel].Add(rawData); }
                                rawData.OffsetAddresses.Add(offsetAddress);
                                rawData.LengthAddresses.Add(lengthAddress);
                            }
                            break;
                        #endregion
                        #region DECP
                        case HaloTags.DECP:
                            entry.TagData.Seek(entry.Offset + 16, SeekOrigin.Begin);
                            int decoratorCount = metaReader.ReadInt32();
                            int decoratorOffset = metaReader.ReadInt32();
                            for (int i = 0; i < decoratorCount; i++)
                            {
                                entry.TagData.Seek(decoratorOffset + (i * 52), SeekOrigin.Begin);
                                offsetAddress = entry.TagData.Position;
                                rawOffset = metaReader.ReadInt32();
                                entry.TagData.Seek(decoratorOffset + (i * 52) + 4, SeekOrigin.Begin);
                                lengthAddress = entry.TagData.Position;
                                rawSize = metaReader.ReadInt32();

                                //Check
                                if ((rawOffset & 0xC0000000) == 0)
                                {
                                    //Read
                                    inStream.Seek(rawOffset, SeekOrigin.Begin);
                                    if (entry.Raws[RawSection.Decorator].ContainsRawOffset(rawOffset))
                                        rawData = entry.Raws[RawSection.Decorator][rawOffset];
                                    else { rawData = new RawStream(reader.ReadBytes(rawSize), rawOffset); entry.Raws[RawSection.Decorator].Add(rawData); }
                                    rawData.OffsetAddresses.Add(offsetAddress);
                                    rawData.LengthAddresses.Add(lengthAddress);
                                }
                            }
                            break;
                        #endregion
                        #region bitm
                        case HaloTags.bitm:
                            entry.TagData.Seek(entry.Offset + 96, SeekOrigin.Begin);
                            int bitmapCount = metaReader.ReadInt32();
                            int bitmapOffset = metaReader.ReadInt32();
                            for (int i = 0; i < bitmapCount; i++)
                            {
                                //LOD0
                                entry.TagData.Seek(bitmapOffset + (i * 116) + 28, SeekOrigin.Begin);
                                offsetAddress = entry.TagData.Position;
                                rawOffset = metaReader.ReadInt32();
                                entry.TagData.Seek(bitmapOffset + (i * 116) + 52, SeekOrigin.Begin);
                                lengthAddress = entry.TagData.Position;
                                rawSize = metaReader.ReadInt32();

                                //Check
                                if ((rawOffset & 0xC0000000) == 0)
                                {
                                    //Read
                                    inStream.Seek(rawOffset, SeekOrigin.Begin);
                                    if (entry.Raws[RawSection.Bitmap].ContainsRawOffset(rawOffset))
                                        rawData = entry.Raws[RawSection.Bitmap][rawOffset];
                                    else { rawData = new RawStream(reader.ReadBytes(rawSize), rawOffset); entry.Raws[RawSection.Bitmap].Add(rawData); }
                                    rawData.OffsetAddresses.Add(offsetAddress);
                                    rawData.LengthAddresses.Add(lengthAddress);
                                }

                                //LOD1
                                entry.TagData.Seek(bitmapOffset + (i * 116) + 32, SeekOrigin.Begin);
                                offsetAddress = entry.TagData.Position;
                                rawOffset = metaReader.ReadInt32();
                                entry.TagData.Seek(bitmapOffset + (i * 116) + 56, SeekOrigin.Begin);
                                lengthAddress = entry.TagData.Position;
                                rawSize = metaReader.ReadInt32();

                                //Check
                                if ((rawOffset & 0xC0000000) == 0)
                                {
                                    //Read
                                    inStream.Seek(rawOffset, SeekOrigin.Begin);
                                    if (entry.Raws[RawSection.Bitmap].ContainsRawOffset(rawOffset))
                                        rawData = entry.Raws[RawSection.Bitmap][rawOffset];
                                    else { rawData = new RawStream(reader.ReadBytes(rawSize), rawOffset); entry.Raws[RawSection.Bitmap].Add(rawData); }
                                    rawData.OffsetAddresses.Add(offsetAddress);
                                    rawData.LengthAddresses.Add(lengthAddress);
                                }

                                //LOD2
                                entry.TagData.Seek(bitmapOffset + (i * 116) + 36, SeekOrigin.Begin);
                                offsetAddress = entry.TagData.Position;
                                rawOffset = metaReader.ReadInt32();
                                entry.TagData.Seek(bitmapOffset + (i * 116) + 60, SeekOrigin.Begin);
                                lengthAddress = entry.TagData.Position;
                                rawSize = metaReader.ReadInt32();

                                //Check
                                if ((rawOffset & 0xC0000000) == 0)
                                {
                                    //Read
                                    inStream.Seek(rawOffset, SeekOrigin.Begin);
                                    if (entry.Raws[RawSection.Bitmap].ContainsRawOffset(rawOffset))
                                        rawData = entry.Raws[RawSection.Bitmap][rawOffset];
                                    else { rawData = new RawStream(reader.ReadBytes(rawSize), rawOffset); entry.Raws[RawSection.Bitmap].Add(rawData); }
                                    rawData.OffsetAddresses.Add(offsetAddress);
                                    rawData.LengthAddresses.Add(lengthAddress);
                                }

                                //LOD3
                                entry.TagData.Seek(bitmapOffset + (i * 116) + 40, SeekOrigin.Begin);
                                offsetAddress = entry.TagData.Position;
                                rawOffset = metaReader.ReadInt32();
                                entry.TagData.Seek(bitmapOffset + (i * 116) + 64, SeekOrigin.Begin);
                                lengthAddress = entry.TagData.Position;
                                rawSize = metaReader.ReadInt32();

                                //Check
                                if ((rawOffset & 0xC0000000) == 0)
                                {
                                    //Read
                                    inStream.Seek(rawOffset, SeekOrigin.Begin);
                                    if (entry.Raws[RawSection.Bitmap].ContainsRawOffset(rawOffset))
                                        rawData = entry.Raws[RawSection.Bitmap][rawOffset];
                                    else { rawData = new RawStream(reader.ReadBytes(rawSize), rawOffset); entry.Raws[RawSection.Bitmap].Add(rawData); }
                                    rawData.OffsetAddresses.Add(offsetAddress);
                                    rawData.LengthAddresses.Add(lengthAddress);
                                }

                                //LOD4
                                entry.TagData.Seek(bitmapOffset + (i * 116) + 44, SeekOrigin.Begin);
                                offsetAddress = entry.TagData.Position;
                                rawOffset = metaReader.ReadInt32();
                                entry.TagData.Seek(bitmapOffset + (i * 116) + 68, SeekOrigin.Begin);
                                lengthAddress = entry.TagData.Position;
                                rawSize = metaReader.ReadInt32();

                                //Check
                                if ((rawOffset & 0xC0000000) == 0)
                                {
                                    //Read
                                    inStream.Seek(rawOffset, SeekOrigin.Begin);
                                    if (entry.Raws[RawSection.Bitmap].ContainsRawOffset(rawOffset))
                                        rawData = entry.Raws[RawSection.Bitmap][rawOffset];
                                    else { rawData = new RawStream(reader.ReadBytes(rawSize), rawOffset); entry.Raws[RawSection.Bitmap].Add(rawData); }
                                    rawData.OffsetAddresses.Add(offsetAddress);
                                    rawData.LengthAddresses.Add(lengthAddress);
                                }

                                //LOD5
                                entry.TagData.Seek(bitmapOffset + (i * 116) + 48, SeekOrigin.Begin);
                                offsetAddress = entry.TagData.Position;
                                rawOffset = metaReader.ReadInt32();
                                entry.TagData.Seek(bitmapOffset + (i * 116) + 72, SeekOrigin.Begin);
                                lengthAddress = entry.TagData.Position;
                                rawSize = metaReader.ReadInt32();

                                //Check
                                if ((rawOffset & 0xC0000000) == 0)
                                {
                                    //Read
                                    inStream.Seek(rawOffset, SeekOrigin.Begin);
                                    if (entry.Raws[RawSection.Bitmap].ContainsRawOffset(rawOffset))
                                        rawData = entry.Raws[RawSection.Bitmap][rawOffset];
                                    else { rawData = new RawStream(reader.ReadBytes(rawSize), rawOffset); entry.Raws[RawSection.Bitmap].Add(rawData); }
                                    rawData.OffsetAddresses.Add(offsetAddress);
                                    rawData.LengthAddresses.Add(lengthAddress);
                                }
                            }
                            break;
                        #endregion
                        #region sbsp
                        case HaloTags.sbsp:
                            long bspAddress = entry.PostProcessedOffset;

                            //Get Lightmap address
                            entry.TagData.Seek(bspAddress + 8);
                            uint lightmapAddress = metaReader.ReadUInt32();

                            //Goto Clusters
                            entry.TagData.Seek(bspAddress + 228, SeekOrigin.Begin);
                            uint clusterCount = metaReader.ReadUInt32();
                            uint clusterOffset = metaReader.ReadUInt32();
                            for (int i = 0; i < clusterCount; i++)
                            {
                                entry.TagData.Seek(clusterOffset + (i * 196) + 44, SeekOrigin.Begin);
                                offsetAddress = entry.TagData.Position;
                                rawOffset = metaReader.ReadInt32();
                                lengthAddress = entry.TagData.Position;
                                rawSize = metaReader.ReadInt32();

                                //Check
                                if ((rawOffset & 0xC0000000) == 0)
                                {
                                    //Read
                                    inStream.Seek(rawOffset, SeekOrigin.Begin);
                                    if (entry.Raws[RawSection.BSP].ContainsRawOffset(rawOffset))
                                        rawData = entry.Raws[RawSection.BSP][rawOffset];
                                    else { rawData = new RawStream(reader.ReadBytes(rawSize), rawOffset); entry.Raws[RawSection.BSP].Add(rawData); }
                                    rawData.OffsetAddresses.Add(offsetAddress);
                                    rawData.LengthAddresses.Add(lengthAddress);
                                }
                            }

                            //Goto Geometries definitions
                            entry.TagData.Seek(bspAddress + 468, SeekOrigin.Begin);
                            uint geometriesCount = metaReader.ReadUInt32();
                            uint geometriesOffset = metaReader.ReadUInt32();
                            for (int i = 0; i < geometriesCount; i++)
                            {
                                entry.TagData.Seek(geometriesOffset + (i * 260) + 44, SeekOrigin.Begin);
                                offsetAddress = entry.TagData.Position;
                                rawOffset = metaReader.ReadInt32();
                                lengthAddress = entry.TagData.Position;
                                rawSize = metaReader.ReadInt32();

                                //Check
                                if ((rawOffset & 0xC0000000) == 0)
                                {
                                    //Read
                                    inStream.Seek(rawOffset, SeekOrigin.Begin);
                                    if (entry.Raws[RawSection.BSP].ContainsRawOffset(rawOffset))
                                        rawData = entry.Raws[RawSection.BSP][rawOffset];
                                    else { rawData = new RawStream(reader.ReadBytes(rawSize), rawOffset); entry.Raws[RawSection.BSP].Add(rawData); }
                                    rawData.OffsetAddresses.Add(offsetAddress);
                                    rawData.LengthAddresses.Add(lengthAddress);
                                }
                            }

                            //Check for lightmap
                            if (lightmapAddress != 0)
                            {
                                //Goto Lightmap Groups
                                entry.TagData.Seek(lightmapAddress + 128);
                                uint groupsCount = metaReader.ReadUInt32();
                                uint groupsPointer = metaReader.ReadUInt32();
                                for (int i = 0; i < groupsCount; i++)
                                {
                                    //Goto Geometry Buckets
                                    entry.TagData.Seek(groupsPointer + (i * 196) + 96, SeekOrigin.Begin);
                                    uint bucketsCount = metaReader.ReadUInt32();
                                    uint bucketsOffset = metaReader.ReadUInt32();
                                    for (int j = 0; j < bucketsCount; j++)
                                    {
                                        entry.TagData.Seek(bucketsOffset + (j * 68) + 16, SeekOrigin.Begin);
                                        offsetAddress = entry.TagData.Position;
                                        rawOffset = metaReader.ReadInt32();
                                        lengthAddress = entry.TagData.Position;
                                        rawSize = metaReader.ReadInt32();

                                        //Check
                                        if ((rawOffset & 0xC0000000) == 0)
                                        {
                                            //Read
                                            inStream.Seek(rawOffset, SeekOrigin.Begin);
                                            if (entry.Raws[RawSection.BSP].ContainsRawOffset(rawOffset))
                                                rawData = entry.Raws[RawSection.BSP][rawOffset];
                                            else { rawData = new RawStream(reader.ReadBytes(rawSize), rawOffset); entry.Raws[RawSection.BSP].Add(rawData); }
                                            rawData.OffsetAddresses.Add(offsetAddress);
                                            rawData.LengthAddresses.Add(lengthAddress);
                                        }
                                    }
                                }
                            }

                            //Goto Water definitions
                            entry.TagData.Seek(bspAddress + 716, SeekOrigin.Begin);
                            uint watersCount = metaReader.ReadUInt32();
                            uint watersOffset = metaReader.ReadUInt32();
                            for (int i = 0; i < watersCount; i++)
                            {
                                entry.TagData.Seek(watersOffset + (i * 160) + 28, SeekOrigin.Begin);
                                offsetAddress = entry.TagData.Position;
                                rawOffset = metaReader.ReadInt32();
                                lengthAddress = entry.TagData.Position;
                                rawSize = metaReader.ReadInt32();

                                //Check
                                if ((rawOffset & 0xC0000000) == 0)
                                {
                                    //Read
                                    inStream.Seek(rawOffset, SeekOrigin.Begin);
                                    if (entry.Raws[RawSection.BSP].ContainsRawOffset(rawOffset))
                                        rawData = entry.Raws[RawSection.BSP][rawOffset];
                                    else { rawData = new RawStream(reader.ReadBytes(rawSize), rawOffset); entry.Raws[RawSection.BSP].Add(rawData); }
                                    rawData.OffsetAddresses.Add(offsetAddress);
                                    rawData.LengthAddresses.Add(lengthAddress);
                                }
                            }
                            break;
                        #endregion
                        #region snd!
                        case HaloTags.snd_:
                            //Read Choices
                            entry.TagData.Seek(entry.Offset + 148, SeekOrigin.Begin);
                            int choiceCount = metaReader.ReadInt32();
                            int choiceOffset = metaReader.ReadInt32();
                            for (int i = 0; i < choiceCount; i++)
                            {
                                //Read Permutations
                                entry.TagData.Seek(choiceOffset + (i * 80) + 68);
                                int permutationCount = metaReader.ReadInt32();
                                int permutationOffset = metaReader.ReadInt32();
                                for (int j = 0; j < permutationCount; j++)
                                {
                                    //Read Sounds
                                    entry.TagData.Seek(permutationOffset + (j * 100) + 52);
                                    int soundsCount = metaReader.ReadInt32();
                                    int soundsOffset = metaReader.ReadInt32();
                                    for (int k = 0; k < soundsCount; k++)
                                    {
                                        //Read Raw offset and length
                                        entry.TagData.Seek(soundsOffset + (k * 16));
                                        offsetAddress = entry.TagData.Position;
                                        rawOffset = metaReader.ReadInt32();
                                        lengthAddress = entry.TagData.Position;
                                        rawSize = (int)(metaReader.ReadInt32() & 0xFFFDFFFF);   //Mask of bit

                                        //Check
                                        if ((rawOffset & 0xC0000000) == 0)
                                        {
                                            //Read
                                            inStream.Seek(rawOffset, SeekOrigin.Begin);
                                            if (entry.Raws[RawSection.Sound].ContainsRawOffset(rawOffset))
                                                rawData = entry.Raws[RawSection.Sound][rawOffset];
                                            else { rawData = new RawStream(reader.ReadBytes(rawSize), rawOffset); entry.Raws[RawSection.Sound].Add(rawData); }
                                            rawData.OffsetAddresses.Add(offsetAddress);
                                            rawData.LengthAddresses.Add(lengthAddress);
                                        }
                                    }
                                }
                            }
                            break;
                            #endregion
                    }
            }
        }
        /// <summary>
        /// Saves this Halo 2 Beta map file to the specfied file or stream.
        /// </summary>
        /// <param name="filename">A string that contains the name of the file to which to save this Halo 2 Beta map.</param>
        /// <exception cref="ArgumentNullException"><paramref name="filename"/> is null.</exception>
        /// <exception cref="DirectoryNotFoundException">Directory containing <paramref name="filename"/> is not found.</exception>
        /// <exception cref="IOException">A generic I/O exception occured.</exception>
        /// <exception cref="MapFileExcption">Exception occured while saving the map file.</exception>
        public void Save(string filename)
        {
            //Check
            if (filename == null) throw new ArgumentNullException("filename");
            if (!Directory.Exists(Path.GetDirectoryName(filename))) throw new DirectoryNotFoundException();

            //Create for read/write
            using (FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.ReadWrite, FileShare.Read))
                Save(fs);
        }
        /// <summary>
        /// Saves this Halo 2 Beta map file to the specified stream.
        /// </summary>
        /// <param name="stream">The stream where the Halo 2 Beta map will be saved.</param>
        /// <exception cref="ArgumentNullException"><paramref name="stream"/> is null.</exception>
        /// <exception cref="ArgumentException"><paramref name="stream"/> does not support seeking.</exception>
        /// <exception cref="MapFileExcption">A write error occured.</exception>
        public void Save(Stream stream)
        {
            //Check stream
            if (stream == null) throw new ArgumentNullException("stream");
            if (!stream.CanSeek) throw new ArgumentException("Stream does not support seeking.", "stream");
            if (!stream.CanWrite) throw new ArgumentException("Stream does not support writing.", "stream");
            if (!stream.CanRead) throw new ArgumentException("Stream does not support reading.", "stream");

            //Check map
            if (scenario == null) throw new MapFileExcption("Map does not have a scenario assigned.");
            if (!indexList.ContainsID(index.ScenarioId)) throw new MapFileExcption(new InvalidOperationException("Map does not contain scenario tag group."));

            //Setup
            index.ScenarioId = scenario.Id;

            //Prepare
            int offset = 0;
            char[] string128Buffer = null;

            //Get Datas
            List<RawStream> soundDatas = new List<RawStream>();
            List<RawStream> modelDatas = new List<RawStream>();
            List<RawStream>[] sbspDatas = new List<RawStream>[sbspTagDatas.Length];
            List<RawStream> decoratorDatas = new List<RawStream>();
            List<RawStream> decoratorSetDatas = new List<RawStream>();
            List<RawStream> particleModelDatas = new List<RawStream>();
            List<RawStream> bitmapDatas = new List<RawStream>();
            for (int i = 0; i < sbspTagDatas.Length; i++)
                sbspDatas[i] = new List<RawStream>();

            //Loop
            foreach (var entry in indexList)
                switch (entry.Root.FourCc)
                {
                    case HaloTags.snd_: soundDatas.AddRange(entry.Raws[RawSection.Sound]); break;
                    case HaloTags.mode: modelDatas.AddRange(entry.Raws[RawSection.Model]); break;
                    case HaloTags.sbsp: sbspDatas[bspIndexLookup[entry.Id]].AddRange(entry.Raws[RawSection.BSP]); break;
                    case HaloTags.DECR: decoratorSetDatas.AddRange(entry.Raws[RawSection.DecoratorSet]); break;
                    case HaloTags.DECP: decoratorDatas.AddRange(entry.Raws[RawSection.Decorator]); break;
                    case HaloTags.PRTM: particleModelDatas.AddRange(entry.Raws[RawSection.ParticleModel]); break;
                    case HaloTags.bitm: bitmapDatas.AddRange(entry.Raws[RawSection.Bitmap]); break;
                }

            //Create I/Os
            using (BinaryReader reader = new BinaryReader(stream))
            using (BinaryWriter writer = new BinaryWriter(stream))
            {
                //Create Index
                byte[] index = CreateIndex();

                //Prepare Header
                header.MapDataLength = (uint)index.Length;
                header.IndexLength = (uint)index.Length;

                //Write Raws
                stream.Seek(2048, SeekOrigin.Begin);

                //Setup Meta I/O
                using (BinaryReader metaReader = new BinaryReader(tagData))
                using (BinaryWriter metaWriter = new BinaryWriter(tagData))
                {
                    //Write Models and fix addresses
                    foreach (RawStream data in modelDatas)
                    {
                        //Get and write offset and length
                        offset = (int)stream.Seek(stream.Position.PadTo(512), SeekOrigin.Begin);
                        foreach (long address in data.OffsetAddresses)
                        {
                            tagData.Seek(address, SeekOrigin.Begin);
                            metaWriter.Write(offset);
                        }
                        foreach (long address in data.LengthAddresses)
                        {
                            tagData.Seek(address, SeekOrigin.Begin);
                            metaWriter.Write(data.IntLength);
                        }

                        //Write
                        writer.Write(data.GetBuffer());
                    }

                    //Write BSPs and fix addresses
                    for (int i = 0; i < sbspTagDatas.Length; i++)
                        using (BinaryWriter bspWriter = new BinaryWriter(sbspTagDatas[i]))
                            foreach (RawStream data in sbspDatas[i])
                            {
                                //Get and write offset and length
                                offset = (int)stream.Seek(stream.Position.PadTo(512), SeekOrigin.Begin);
                                foreach (long address in data.OffsetAddresses)
                                {
                                    sbspTagDatas[i].Seek(address, SeekOrigin.Begin);
                                    bspWriter.Write(offset);
                                }
                                foreach (long address in data.LengthAddresses)
                                {
                                    sbspTagDatas[i].Seek(address, SeekOrigin.Begin);
                                    bspWriter.Write(data.IntLength);
                                }

                                //Write
                                writer.Write(data.GetBuffer());
                            }

                    //Write Decorator and fix addresses
                    foreach (RawStream data in decoratorDatas)
                    {
                        //Get and write offset and length
                        offset = (int)stream.Seek(stream.Position.PadTo(512), SeekOrigin.Begin);
                        foreach (long address in data.OffsetAddresses)
                        {
                            tagData.Seek(address, SeekOrigin.Begin);
                            metaWriter.Write(offset);
                        }
                        foreach (long address in data.LengthAddresses)
                        {
                            tagData.Seek(address, SeekOrigin.Begin);
                            metaWriter.Write(data.IntLength);
                        }

                        //Write
                        writer.Write(data.GetBuffer());
                    }

                    //Write Decorator set and fix addresses
                    foreach (RawStream data in decoratorSetDatas)
                    {
                        //Get and write offset and length
                        offset = (int)stream.Seek(stream.Position.PadTo(512), SeekOrigin.Begin);
                        foreach (long address in data.OffsetAddresses)
                        {
                            tagData.Seek(address, SeekOrigin.Begin);
                            metaWriter.Write(offset);
                        }
                        foreach (long address in data.LengthAddresses)
                        {
                            tagData.Seek(address, SeekOrigin.Begin);
                            metaWriter.Write(data.IntLength);
                        }

                        //Write
                        writer.Write(data.GetBuffer());
                    }

                    //Write Particle models and fix addresses
                    foreach (RawStream data in particleModelDatas)
                    {
                        //Get and write offset and length
                        offset = (int)stream.Seek(stream.Position.PadTo(512), SeekOrigin.Begin);
                        foreach (long address in data.OffsetAddresses)
                        {
                            tagData.Seek(address, SeekOrigin.Begin);
                            metaWriter.Write(offset);
                        }
                        foreach (long address in data.LengthAddresses)
                        {
                            tagData.Seek(address, SeekOrigin.Begin);
                            metaWriter.Write(data.IntLength);
                        }

                        //Write
                        writer.Write(data.GetBuffer());
                    }

                    //Write Structure BSP and Lightmap
                    int bspLength = 0;
                    tagData.Seek(scenario.Offset + 828, SeekOrigin.Begin);
                    int sbspsCount = metaReader.ReadInt32();
                    int sbspsOffset = metaReader.ReadInt32();
                    for (int i = 0; i < sbspTagDatas.Length; i++)
                    {
                        tagData.Seek(sbspsOffset + (i * 86) + 8, SeekOrigin.Begin);
                        uint testValue = metaReader.ReadUInt32();

                        offset = (int)stream.Seek(stream.Position.PadTo(512), SeekOrigin.Begin);
                        tagData.Seek(sbspsOffset + (i * 86), SeekOrigin.Begin);
                        metaWriter.Write(offset);
                        metaWriter.Write((int)sbspTagDatas[i].Length);
                        metaWriter.Write(Index.IndexMemoryAddress + (index.Length - Index.Length));
                        writer.Write(sbspTagDatas[i].GetBuffer());
                        if (sbspTagDatas[i].Length > bspLength)
                            bspLength = sbspTagDatas[i].IntLength;
                    }
                    header.MapDataLength += (uint)bspLength;

                    //Write Strings 128
                    header.StringCount = (uint)strings.Count;
                    header.Strings128Offset = (uint)stream.Position.PadTo(512);
                    foreach (string stringId in strings)
                    {
                        string128Buffer = stringId.PadRight(128, '\0').ToCharArray();
                        writer.Write(string128Buffer);
                    }

                    //Write String Index
                    offset = 0;
                    header.StringsIndexOffset = (uint)stream.Seek(stream.Position.PadTo(512), SeekOrigin.Begin);
                    foreach (string stringId in strings)
                    {
                        writer.Write(offset);
                        offset += Encoding.UTF8.GetByteCount(stringId) + 1;
                    }

                    //Write String IDs
                    header.StringsOffset = (uint)stream.Seek(stream.Position.PadTo(512), SeekOrigin.Begin);
                    foreach (string stringId in strings)
                        writer.WriteUTF8NullTerminated(stringId);

                    //Write Crazy
                    header.CrazyLength = (uint)crazyData.IntLength;
                    header.CrazyOffset = (uint)stream.Seek(stream.Position.PadTo(512), SeekOrigin.Begin);
                    writer.Write(crazyData.GetBuffer());

                    //Write Bitmaps and fix addresses
                    foreach (RawStream data in bitmapDatas)
                    {
                        //Get and write offset and length
                        offset = (int)stream.Seek(stream.Position.PadTo(512), SeekOrigin.Begin);
                        foreach (long address in data.OffsetAddresses)
                        {
                            tagData.Seek(address, SeekOrigin.Begin);
                            metaWriter.Write(offset);
                        }
                        foreach (long address in data.LengthAddresses)
                        {
                            tagData.Seek(address, SeekOrigin.Begin);
                            metaWriter.Write(data.IntLength);
                        }

                        //Write
                        writer.Write(data.GetBuffer());
                    }

                    //Write Sounds and fix addresses
                    foreach (RawStream data in soundDatas)
                    {
                        //Get and write offset and length
                        offset = (int)stream.Seek(stream.Position.PadTo(512), SeekOrigin.Begin);
                        foreach (long address in data.OffsetAddresses)
                        {
                            tagData.Seek(address, SeekOrigin.Begin);
                            metaWriter.Write(offset);
                        }
                        foreach (long address in data.LengthAddresses)
                        {
                            tagData.Seek(address, SeekOrigin.Begin);
                            metaWriter.Write(data.IntLength);
                        }

                        //Write
                        writer.Write(data.GetBuffer());
                    }

                    //Write Index
                    header.IndexOffset = (uint)stream.Seek(stream.Position.PadTo(512), SeekOrigin.Begin);
                    writer.Write(index);
                }

                //Write Meta
                header.TagDataLength = (uint)tagData.IntLength;
                writer.Write(tagData.GetBuffer());
                header.MapDataLength += header.TagDataLength;

                //Pad File
                stream.Seek(stream.Position.PadTo(1024), SeekOrigin.Begin);

                //Set
                header.FileLength = (uint)stream.Length;
                
                //Write header
                stream.Seek(0, SeekOrigin.Begin);
                writer.Write(header);

                //Read
                ReadRaws(stream, reader);
            }
        }
        /// <summary>
        /// Closes the map file, clearing all used buffers.
        /// </summary>
        public void Close()
        {
            //Dispose
            foreach (var entry in indexList)
                entry.Dispose();
            foreach (var data in sbspTagDatas)
                if (data != null)
                    data.Dispose();
            if (crazyData != null)
                crazyData.Dispose();
            if (tagData != null)
                tagData.Dispose();

            //Setup
            header = Header.CreateDefault();
            index = Index.CreateDefault();
            sbspTagDatas = new FixedMemoryMappedStream[0];
            strings = new StringList();
            crazyData = FixedMemoryMappedStream.Empty;
            indexList = new IndexEntryList();
            tagData = FixedMemoryMappedStream.Empty;
            bspIndexLookup = new Dictionary<TagId, int>();
            scenario = null;

            //Collect
            GC.Collect();
        }
        /// <summary>
        /// Clears all buffers and releases all resources used by this instance.
        /// </summary>
        public void Dispose()
        {
            //Close
            Close();

            //Null buffers
            sbspTagDatas = null;
            strings = null;
            bspIndexLookup = null;
            indexList = null;
            tagData = null;
        }
        /// <summary>
        /// Creates a padded index table for the current Halo 2 Beta map.
        /// </summary>
        /// <returns>A Halo 2 Beta index table containing the index, tags, and object entries present in this instance.</returns>
        private byte[] CreateIndex()
        {
            //Edit Index
            index.ObjectCount = (uint)indexList.Count;
            index.IndexAddress = Index.IndexMemoryAddress;
            
            //Calculate minimum length...
            int length = Index.Length + (ObjectEntry.Length * indexList.Count);
            for (int i = 0; i < indexList.Count; i++)
                length += indexList[i].Filename.Length + 1;

            //Check
            if (length > header.IndexLength) throw new MapFileExcption("Unable to save map. Index length is larger than expected.");
            else length = (int)header.IndexLength;

            //Get Filenames Start
            uint filenamesStartOffset = (uint)(Index.IndexMemoryAddress + (32 * indexList.Count));

            //Write
            uint filenameOffset = 0;
            byte[] indexTable = new byte[length];
            using (MemoryStream ms = new MemoryStream(indexTable))
            using (BinaryWriter writer = new BinaryWriter(ms))
            {
                writer.Write(index);                        //Write index header
                for (int i = 0; i < indexList.Count; i++)   //Write object entries
                {
                    indexList[i].FilenameOffset = filenamesStartOffset + filenameOffset;
                    writer.Write(indexList[i].GetObjectEntry());
                    filenameOffset += (uint)(indexList[i].Filename.Length + 1);
                }
                for (int i = 0; i < indexList.Count; i++)   //Write File names
                    writer.WriteUTF8NullTerminated(indexList[i].Filename);
            }

            //Return
            return indexTable;
        }

        /// <summary>
        /// Represents a Halo 2 beta index entry list.
        /// </summary>
        [Serializable]
        public sealed class IndexEntryList : IEnumerable<IndexEntry>
        {
            /// <summary>
            /// Gets the number of index entries this list contains.
            /// </summary>
            public int Count
            {
                get { return entries.Count; }
            }
            /// <summary>
            /// Gets and returns the first object entry in the list.
            /// </summary>
            /// <exception cref="IndexOutOfRangeException"></exception>
            public IndexEntry First
            {
                get
                {
                    if (entries.Count > 0) return entries[indexLookup[0]];
                    else throw new IndexOutOfRangeException();
                }
            }
            /// <summary>
            /// Gets and returns the last object entry in the list.
            /// </summary>
            /// <exception cref="IndexOutOfRangeException"></exception>
            public IndexEntry Last
            {
                get
                {
                    int index = entries.Count - 1;
                    if (index >= 0) return entries[indexLookup[index]];
                    else throw new IndexOutOfRangeException();
                }
            }
            /// <summary>
            /// Gets and returns the index entry object by its <see cref="TagId"/>.
            /// </summary>
            /// <param name="id">The <see cref="TagId"/> of the index entry object.</param>
            /// <returns>An <see cref="IndexEntry"/> whose ID matches the supplied <see cref="TagId"/>.</returns>
            public IndexEntry this[TagId id]
            {
                get
                {
                    if (entries.ContainsKey(id)) return entries[id];
                    else return null;
                }
            }
            /// <summary>
            /// Gets and returns the index entry object at a given index.
            /// </summary>
            /// <param name="index">The index of the index entry object.</param>
            /// <returns>An <see cref="IndexEntry"/> at the given index.</returns>
            public IndexEntry this[int index]
            {
                get
                {
                    if (indexLookup.ContainsKey(index)) return entries[indexLookup[index]];
                    else return null;
                }
            }

            private readonly Dictionary<TagId, IndexEntry> entries;
            private readonly Dictionary<int, TagId> indexLookup;

            /// <summary>
            /// Intializes a new <see cref="IndexEntryList"/> copying the supplied <see cref="IndexEntry"/> array into the list.
            /// </summary>
            /// <param name="indexEntries">The array to copy into the new list.</param>
            public IndexEntryList(IndexEntry[] indexEntries)
            {
                //Setup
                entries = new Dictionary<TagId, IndexEntry>();
                indexLookup = new Dictionary<int, TagId>();

                //Add
                for (int i = 0; i < indexEntries.Length; i++)
                {
                    entries.Add(indexEntries[i].Id, indexEntries[i]);
                    indexLookup.Add(i, indexEntries[i].Id);
                }
            }
            /// <summary>
            /// Initializes a new <see cref="IndexEntryList"/>.
            /// </summary>
            public IndexEntryList()
            {
                //Setup
                entries = new Dictionary<TagId, IndexEntry>();
                indexLookup = new Dictionary<int, TagId>();
            }
            /// <summary>
            /// Checks if the list contains an index entry whose ID matches the supplied ID.
            /// </summary>
            /// <param name="id">The ID to check.</param>
            /// <returns>True if the list contains an index entry whose ID is the supplied ID, false if not.</returns>
            public bool ContainsID(TagId id)
            {
                return entries.ContainsKey(id);
            }
            /// <summary>
            /// Gets a string representation of this list.
            /// </summary>
            /// <returns>A string representation of this list.</returns>
            public override string ToString()
            {
                return string.Format("Count = {0}", entries.Count);
            }
            /// <summary>
            /// Returns an enumerator that iterates through the <see cref="IndexEntryList"/>.
            /// </summary>
            /// <returns>An enumerator.</returns>
            public IEnumerator<IndexEntry> GetEnumerator()
            {
                return entries.Values.GetEnumerator();
            }
            /// <summary>
            /// Attempts to remove an index entry from the list whose ID matches the supplied ID.
            /// </summary>
            /// <param name="id">The ID of the index entry to remove.</param>
            public bool Remove(TagId id)
            {
                //Prepare
                bool removed = false;

                //Remove?
                if (indexLookup.ContainsKey(id))
                    removed = entries.Remove(id);

                //Check
                if (removed)
                {
                    var list = entries.ToList();
                    for (int i = 0; i < list.Count; i++)
                        indexLookup.Add(i, list[i].Key);
                }

                //Return
                return removed;
            }
            /// <summary>
            /// Attempts to add an index entry to the list.
            /// Not currently implemented.
            /// </summary>
            /// <param name="entry">The index entry to add.</param>
            /// <returns></returns>
            public bool Add(IndexEntry entry)
            {
                throw new NotImplementedException();
            }
            IEnumerator IEnumerable.GetEnumerator()
            {
                return entries.Values.GetEnumerator();
            }
        }

        /// <summary>
        /// Represents a Halo 2 beta string list.
        /// </summary>
        [Serializable]
        public sealed class StringList : IEnumerable<string>, ICollection<string>
        {
            /// <summary>
            /// Gets and returns the number of strings in the list.
            /// </summary>
            public int Count
            {
                get { return strings.Count; }
            }
            /// <summary>
            /// Gets and returns a a string's ID from the given string within the list.
            /// </summary>
            /// <param name="sid">The string whose ID is to be retrieved.</param>
            /// <returns><see cref="StringId.Zero"/> if the string does not exist, otherwise returns a valid <see cref="StringId"/> value.</returns>
            public StringId this[string sid]
            {
                get
                {
                    //Check
                    if (sid == null) throw new ArgumentNullException(nameof(sid));

                    //Return zero for non-existing strings.
                    if (!Contains(sid)) return StringId.Zero;
                    else return StringId.FromString(sid, strings.IndexOf(sid));
                }
            }
            /// <summary>
            /// Gets or sets a string's value at a given index within the list.
            /// </summary>
            /// <param name="index">The index of the string.</param>
            /// <returns>A string value.</returns>
            /// <exception cref="ArgumentOutOfRangeException"><paramref name="index"/> is outside of the valid range.</exception>
            /// <exception cref="ArgumentNullException"><paramref name="value"/> is null.</exception>
            public string this[int index]
            {
                get
                {
                    //Check
                    if (index < 0 || index >= strings.Count) throw new ArgumentOutOfRangeException(nameof(index));

                    //Return
                    return strings[index];
                }
                set
                {
                    //Check
                    if (index < 0 || index >= strings.Count) throw new ArgumentOutOfRangeException(nameof(index));
                    if (value == null) throw new ArgumentNullException(nameof(value));

                    //Set
                    strings[index] = value;
                }
            }

            private readonly List<string> strings;

            /// <summary>
            /// Initializes a new <see cref="StringList"/> instance.
            /// </summary>
            public StringList() : this(new string[0]) { }
            /// <summary>
            /// Initializes a new <see cref="StringList"/> instance using the supplied string array.
            /// </summary>
            /// <param name="strings">The string array to populate the list with.</param>
            /// <exception cref="ArgumentNullException"><paramref name="strings"/> is null.</exception>
            public StringList(string[] strings)
            {
                //Check
                if (strings == null) throw new ArgumentNullException(nameof(strings));

                //Intialize
                this.strings = new List<string>(strings);
            }
            /// <summary>
            /// Attempts to add a string value to the list.
            /// </summary>
            /// <param name="value">The string to add.</param>
            /// <returns>true if the string does not exist, and the string is added successfully; othewise false and the string was not added.</returns>
            /// <exception cref="ArgumentNullException"><paramref name="value"/> is null.</exception>
            public bool Add(string value)
            {
                //Check
                if (value == null) throw new ArgumentNullException(nameof(value));

                //Add?
                bool contains = strings.Contains(value);
                if (!contains) strings.Add(value);

                //Return
                return contains;
            }
            /// <summary>
            /// Attempts to add a string value to the list, and retrieve its identifier.
            /// </summary>
            /// <param name="value">The string value.</param>
            /// <param name="id">The target string id.</param>
            /// <returns>true if the string does not exist, and the string is added successfully; othewise false and the string was not added.</returns>
            /// <exception cref="ArgumentNullException"><paramref name="value"/> is null.</exception>
            public bool Add(string value, out StringId id)
            {
                //Check
                if (value == null) throw new ArgumentNullException(nameof(value));

                //Add?
                bool contains = strings.Contains(value);
                if (!contains) strings.Add(value);

                //Get ID
                id = StringId.FromString(value, strings.IndexOf(value));

                //Return
                return contains;
            }
            /// <summary>
            /// Determines if a string value exists within the list.
            /// </summary>
            /// <param name="value">The string to check for.</param>
            /// <returns>true if the string exists in the list; otherwise false.</returns>
            /// <exception cref="ArgumentNullException"><paramref name="value"/> is null.</exception>
            public bool Contains(string value)
            {
                //Check
                if (value == null) throw new ArgumentNullException(nameof(value));

                //Return
                return strings.Contains(value);
            }
            /// <summary>
            /// Attempts to remove a string value from the list.
            /// </summary>
            /// <param name="value">The string to remove.</param>
            /// <returns>true if the string is found and removed; otherwise false.</returns>
            /// <exception cref="ArgumentNullException"><paramref name="value"/> is null.</exception>
            public bool Remove(string value)
            {
                //Check
                if (value == null) throw new ArgumentNullException(nameof(value));

                //Return
                return strings.Remove(value);
            }
            /// <summary>
            /// Attempts to remove a string value from this list at the specified index.
            /// </summary>
            /// <param name="index">The zero-based index of the string to remove.</param>
            public void RemoveAt(int index)
            {
                //Check
                if (index >= 0 && index < strings.Count)
                    strings.RemoveAt(index);
            }
            /// <summary>
            /// Reset's the map's strings table, leaving the zero-string.
            /// </summary>
            public void Reset()
            {
                //Clear
                strings.Clear();
                strings.Add(string.Empty);
            }
            /// <summary>
            /// Gets the zero-based index of the string within the list.
            /// </summary>
            /// <param name="value">The string to retrieve the index of.</param>
            /// <returns>-1 if the specified string was not found, otherwise returns a valid index.</returns>
            public int IndexOf(string value)
            {
                //Check
                if (value == null) throw new ArgumentNullException(nameof(value));

                //Return
                return strings.IndexOf(value);
            }
            /// <summary>
            /// Gets and returns an enumerator that iterates the instance.
            /// </summary>
            /// <returns>An enumerator.</returns>
            public IEnumerator<string> GetEnumerator()
            {
                return strings.GetEnumerator();
            }
            /// <summary>
            /// Returns a string representation of this list.
            /// </summary>
            /// <returns>A string.</returns>
            public override string ToString()
            {
                return $"Count: {strings.Count}";
            }

            int ICollection<string>.Count
            {
                get { return strings.Count; }
            }
            bool ICollection<string>.IsReadOnly
            {
                get { return false; }
            }
            void ICollection<string>.Add(string item)
            {
                Add(item);
            }
            void ICollection<string>.Clear()
            {
                Reset();
            }
            bool ICollection<string>.Contains(string item)
            {
                return strings.Contains(item);
            }
            void ICollection<string>.CopyTo(string[] array, int arrayIndex)
            {
                strings.CopyTo(array, arrayIndex);
            }
            bool ICollection<string>.Remove(string item)
            {
                return strings.Remove(item);
            }
            IEnumerator<string> IEnumerable<string>.GetEnumerator()
            {
                return strings.GetEnumerator();
            }
            IEnumerator IEnumerable.GetEnumerator()
            {
                return strings.GetEnumerator();
            }
        }
    }

    /// <summary>
    /// Represents an error that occurs while handling a Halo 2 Beta map file.
    /// </summary>
    public sealed class MapFileExcption : Exception
    {
        /// <summary>
        /// Initializes a new instance of <see cref="MapFileExcption"/>.
        /// </summary>
        public MapFileExcption() : base()
        { }
        /// <summary>
        /// Initializes a new instance of <see cref="MapFileExcption"/> using the provided exception message.
        /// </summary>
        /// <param name="message">The exception's message.</param>
        public MapFileExcption(string message) :
            base(message)
        { }
        /// <summary>
        /// Initializes a new instance of <see cref="MapFileExcption"/> using the provided inner exception.
        /// </summary>
        /// <param name="innerException">The inner exception that triggered the <see cref="MapFileExcption"/>.</param>
        public MapFileExcption(Exception innerException) : base(innerException.Message, innerException)
        { }
        /// <summary>
        /// Initializes a new instance of <see cref="MapFileExcption"/> using the provided exception message and inner exception.
        /// </summary>
        /// <param name="message">The exception's message.</param>
        /// <param name="innerException">The inner exception that triggered the <see cref="MapFileExcption"/>.</param>
        public MapFileExcption(string message, Exception innerException) : base(message, innerException)
        { }
    }
}
