﻿using Abide.HaloLibrary.IO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;

namespace Abide.HaloLibrary.Halo2Map
{
    /// <summary>
    /// Represents a Halo 2 binary map file.
    /// </summary>
    [Serializable, Obsolete("Deprecated, use Abide.HaloLibrary.Halo2.Retail.HaloMap instead")]
    public sealed class MapFile : MarshalByRefObject, IDisposable
    {
        /// <summary>
        /// Represents the minimum length of a Halo 2 map file.
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
        public VirtualStream TagDataStream
        {
            get { return tagData; }
        }
        /// <summary>
        /// Gets and returns the number of BSP tag data in the map.
        /// </summary>
        [Browsable(false)]
        public int BspCount => bspTagData?.Length ?? 0;
        /// <summary>
        /// Gets and returns the length of the map index in bytes.
        /// </summary>
        [Browsable(false)]
        public int IndexLength => (int)header.IndexLength;
        /// <summary>
        /// Gets and returns a list of the Halo 2 map's string IDs.
        /// </summary>
        [Category("Map Data"), Description("The Halo 2 map's strings.")]
        public StringList Strings
        {
            get { return strings; }
        }
        /// <summary>
        /// Gets and returns a list of the Halo 2 map's tag hierarchies.
        /// </summary>
        [Browsable(false)]
        public TagHierarchyList Tags
        {
            get { return tags; }
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
        /// <summary>
        /// Gets or sets the Halo 2 map's globals.
        /// </summary>
        [Browsable(false)]
        public IndexEntry Globals
        {
            get { return globals; }
            set { globals = value; }
        }

        private Header header;
        private VirtualStream[] bspTagData;
        private StringList strings;
        private MemoryStream crazyData;
        private Index index;
        private TagHierarchyList tags;
        private VirtualStream tagData;
        private IndexEntryList indexList;
        private IndexEntry scenario, globals;
        
        /// <summary>
        /// Don't use this. I won't like it when you use this.
        /// </summary>
        /// <param name="sourceIndex">Are you...</param>
        /// <param name="destinationIndex">... serious?</param>
        [Obsolete("Please don't use this method it's a bad method and you are bad if you use it.")]
        public void MoveBspTagData(int sourceIndex, int destinationIndex)
        {
            List<VirtualStream> bspTagData = new List<VirtualStream>(this.bspTagData);
            VirtualStream data = bspTagData[sourceIndex];
            bspTagData.RemoveAt(sourceIndex);
            bspTagData.Insert(destinationIndex, data);

            //Get array
            this.bspTagData = bspTagData.ToArray();
        }
        /// <summary>
        /// Initializes a new Halo 2 map file instance.
        /// </summary>
        public MapFile()
        {
            //Initialize
            header = Header.CreateDefault();
            index = Index.CreateDefault();
            bspTagData = new VirtualStream[0];
            strings = new StringList();
            crazyData = new MemoryStream();
            tags = new TagHierarchyList();
            indexList = new IndexEntryList(this);
            tagData = VirtualStream.Empty;
        }
        /// <summary>
        /// Loads a Halo 2 map file from a specified file path.
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
        /// Loads a Halo 2 map file from the specified stream.
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
            if (inStream.Length < MinLength)
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

                    //Read File Names
                    string[] files = reader.ReadUTF8StringTable(header.FileNamesOffset, header.FileNamesIndexOffset, (int)header.FileNameCount);
                    
                    //Read Strings
                    strings = new StringList(reader.ReadUTF8StringTable(header.StringsOffset, header.StringsIndexOffset, (int)header.StringCount));

                    //Read Index
                    inStream.Seek(header.IndexOffset, SeekOrigin.Begin);
                    index = reader.Read<Index>();

                    //Read Tags
                    TagHierarchy[] tags = new TagHierarchy[index.TagCount];
                    for (int i = 0; i < index.TagCount; i++)
                        tags[i] = reader.Read<TagHierarchy>();
                    this.tags = new TagHierarchyList(tags);

                    //Read Objects
                    inStream.Seek(index.ObjectsOffset - index.TagsAddress + header.IndexOffset + Index.Length, SeekOrigin.Begin);
                    ObjectEntry objectEntry = new ObjectEntry(); IndexEntry[] indexEntries = new IndexEntry[index.ObjectCount];
                    for (int i = 0; i < index.ObjectCount; i++)
                    {
                        objectEntry = reader.Read<ObjectEntry>();
                        indexEntries[i] = new IndexEntry(objectEntry, files[i], this.tags[objectEntry.Tag])
                        {
                            PostProcessedOffset = (int)objectEntry.Offset,
                            PostProcessedSize = (int)objectEntry.Size
                        };
                    }

                    //Setup Index List
                    indexList = new IndexEntryList(this, indexEntries);

                    //Read Crazy
                    inStream.Seek(header.CrazyOffset, SeekOrigin.Begin);
                    crazyData = new MemoryStream(reader.ReadBytes((int)header.CrazyLength));

                    //Get Meta Memory-file address
                    uint metaFileMemoryAddress = 0, metaMemoryAddress = 0;
                    if (index.ObjectCount > 0)
                    {
                        metaFileMemoryAddress = indexList[0].Offset - (header.IndexOffset + header.IndexLength);
                        metaMemoryAddress = indexList[0].Offset;
                    }

                    //Read Meta
                    inStream.Seek(header.IndexOffset + header.IndexLength, SeekOrigin.Begin);
                    tagData = new VirtualStream(metaMemoryAddress, reader.ReadBytes((int)header.TagDataLength));

                    //Loop
                    foreach (IndexEntry entry in indexList)
                        if (entry.Offset != 0)
                            entry.TagData = tagData;

                    //Prepare BSP start...
                    int bspStart = (int)header.Strings128Offset;

                    //Prepare
                    StringEntry[] en = null, jp = null, nl = null, fr = null, es = null, it = null, kr = null, zh = null, pr = null;

                    //Read Strings
                    foreach (var indexEntry in indexList)
                        if (indexEntry.Id == index.GlobalsId)
                        {
                            //Read English Strings
                            ReadStringTable(inStream, reader, indexEntry, metaFileMemoryAddress, 400, out en);

                            //Read Japanese Strings
                            ReadStringTable(inStream, reader, indexEntry, metaFileMemoryAddress, 428, out jp);

                            //Read Dutch Strings
                            ReadStringTable(inStream, reader, indexEntry, metaFileMemoryAddress, 456, out nl);

                            //Read French Strings
                            ReadStringTable(inStream, reader, indexEntry, metaFileMemoryAddress, 484, out fr);

                            //Read Spanish Strings
                            ReadStringTable(inStream, reader, indexEntry, metaFileMemoryAddress, 512, out es);

                            //Read Italian Strings
                            ReadStringTable(inStream, reader, indexEntry, metaFileMemoryAddress, 540, out it);

                            //Read Korean Strings
                            ReadStringTable(inStream, reader, indexEntry, metaFileMemoryAddress, 568, out kr);

                            //Read Chinese Strings
                            ReadStringTable(inStream, reader, indexEntry, metaFileMemoryAddress, 596, out zh);

                            //Read Portuguese Strings
                            ReadStringTable(inStream, reader, indexEntry, metaFileMemoryAddress, 624, out pr);

                            //Break
                            break;
                        }

                    //Read BSP Meta
                    if (indexList.ContainsID(index.ScenarioId))
                    {
                        //Goto
                        inStream.Seek(indexList[index.ScenarioId].Offset + 528, metaFileMemoryAddress, SeekOrigin.Begin);
                        TagBlock structureBsps = (TagBlock)reader.ReadUInt64();
                        bspTagData = new VirtualStream[structureBsps.Count];
                        for (int i = 0; i < structureBsps.Count; i++)
                        {
                            //Goto
                            inStream.Seek(structureBsps.Offset + (i * 68), metaFileMemoryAddress, SeekOrigin.Begin);
                            int structureBspBlockAddress = reader.ReadInt32();
                            uint structureBspBlockSize = reader.ReadUInt32();
                            uint structureBspMemoryAddress = reader.ReadUInt32();
                            int zero = reader.ReadInt32();
                            TagFourCc sbspTag = reader.Read<TagFourCc>();
                            TagId sbspId = reader.Read<TagId>();
                            TagFourCc ltmpTag = reader.Read<TagFourCc>();
                            TagId ltmpId = reader.Read<TagId>();
                            
                            //Read BSP tag data block
                            inStream.Seek(structureBspBlockAddress, SeekOrigin.Begin);
                            bspTagData[i] = new VirtualStream(structureBspMemoryAddress, reader.ReadBytes((int)structureBspBlockSize));

                            //Read BSP header
                            uint sbspLength = 0, ltmpLength = 0; StructureBspBlockHeader bspHeader = new StructureBspBlockHeader();
                            using (BinaryReader bspReader = bspTagData[i].CreateReader())
                            {
                                //Read
                                bspTagData[i].Seek(structureBspMemoryAddress, SeekOrigin.Begin);
                                bspHeader = bspReader.Read<StructureBspBlockHeader>();

                                //Get structure bsp length
                                if (ltmpId.IsNull) sbspLength = (structureBspMemoryAddress + structureBspBlockSize) - bspHeader.StructureBspOffset;
                                else sbspLength = bspHeader.StructureLightmapOffset - bspHeader.StructureBspOffset;

                                //Get lightmap length
                                if (!ltmpId.IsNull) ltmpLength = (structureBspMemoryAddress + structureBspBlockSize) - bspHeader.StructureLightmapOffset;
                            }

                            //Setup SBSP and Lightmap
                            if (indexList.ContainsID(sbspId))
                            {
                                indexList[sbspId].TagData = bspTagData[i];
                                indexList[sbspId].PostProcessedOffset = (int)bspHeader.StructureBspOffset;
                                indexList[sbspId].PostProcessedSize = (int)sbspLength;
                            }
                            if (indexList.ContainsID(ltmpId))
                            {
                                indexList[ltmpId].TagData = bspTagData[i];
                                indexList[ltmpId].PostProcessedOffset = (int)bspHeader.StructureLightmapOffset;
                                indexList[ltmpId].PostProcessedSize = (int)ltmpLength;
                            }

                            //Check
                            if (structureBspBlockAddress < bspStart)
                                bspStart = structureBspBlockAddress;
                        }
                    }

                    //Read Strings into unicode tags
                    using (BinaryReader metaReader = tagData.CreateReader())
                        foreach (var unicode in indexList.Where(e => e.Root == HaloTags.unic))
                        {
                            //Prepare
                            ushort offset, count;
                            unicode.TagData.Seek(unicode.Offset + 16, SeekOrigin.Begin);

                            //Read English
                            offset = metaReader.ReadUInt16();
                            count = metaReader.ReadUInt16();
                            unicode.Strings.English.AddRange(en.Where((s, i) => i >= offset && i < offset + count));

                            //Read Japanese
                            offset = metaReader.ReadUInt16();
                            count = metaReader.ReadUInt16();
                            unicode.Strings.Japanese.AddRange(jp.Where((s, i) => i >= offset && i < offset + count));

                            //Read German
                            offset = metaReader.ReadUInt16();
                            count = metaReader.ReadUInt16();
                            unicode.Strings.German.AddRange(nl.Where((s, i) => i >= offset && i < offset + count));

                            //Read French
                            offset = metaReader.ReadUInt16();
                            count = metaReader.ReadUInt16();
                            unicode.Strings.French.AddRange(fr.Where((s, i) => i >= offset && i < offset + count));

                            //Read Spanish
                            offset = metaReader.ReadUInt16();
                            count = metaReader.ReadUInt16();
                            unicode.Strings.Spanish.AddRange(es.Where((s, i) => i >= offset && i < offset + count));

                            //Read Italian
                            offset = metaReader.ReadUInt16();
                            count = metaReader.ReadUInt16();
                            unicode.Strings.Italian.AddRange(it.Where((s, i) => i >= offset && i < offset + count));

                            //Read Korean
                            offset = metaReader.ReadUInt16();
                            count = metaReader.ReadUInt16();
                            unicode.Strings.Korean.AddRange(kr.Where((s, i) => i >= offset && i < offset + count));

                            //Read Chinese
                            offset = metaReader.ReadUInt16();
                            count = metaReader.ReadUInt16();
                            unicode.Strings.Chinese.AddRange(zh.Where((s, i) => i >= offset && i < offset + count));

                            //Read Portuguese
                            offset = metaReader.ReadUInt16();
                            count = metaReader.ReadUInt16();
                            unicode.Strings.Portuguese.AddRange(pr.Where((s, i) => i >= offset && i < offset + count));
                        }

                    //Zero-out variables
                    header.FileLength = 0;
                    header.MapDataLength = 0;
                    index.ObjectsOffset = 0;

                    //Read Raws
                    ReadRaws(inStream, reader);

                    //Get scenario and globals
                    scenario = indexList[index.ScenarioId];
                    globals = indexList[index.GlobalsId];
                }
            }
            catch (Exception ex) { throw new MapFileExcption(ex); }
        }
        /// <summary>
        /// Attempts to read any internal raw data reference by the supplied tag group.
        /// </summary>
        /// <param name="inStream">The Halo 2 map file stream.</param>
        /// <param name="reader">The reader for the map stream.</param>
        private void ReadRaws(Stream inStream, BinaryReader reader)
        {
            //Null
            RawStream rawData = null;
            int rawOffset, rawSize;
            long offsetAddress, lengthAddress;

            //Handle objects...
            foreach (IndexEntry entry in indexList.Where(e => e.TagData != null))
            {
                //Clear
                entry.Raws.Clear();

                //Prepare
                using (BinaryReader metaReader = entry.TagData.CreateReader())
                using (BinaryWriter metaWriter = entry.TagData.CreateWriter())
                    switch (entry.Root.FourCc)
                    {
                        #region ugh!
                        case HaloTags.ugh_:
                            entry.TagData.Seek(entry.Offset + 64, SeekOrigin.Begin);
                            int soundsCount = metaReader.ReadInt32();
                            uint soundsOffset = metaReader.ReadUInt32();
                            for (int i = 0; i < soundsCount; i++)
                            {
                                //Goto
                                entry.TagData.Seek(soundsOffset + (i * 12), SeekOrigin.Begin);
                                offsetAddress = entry.TagData.Position;
                                rawOffset = metaReader.ReadInt32();
                                lengthAddress = entry.TagData.Position;
                                rawSize = metaReader.ReadInt32() & 0x7FFFFFFF;   //Mask off the first bit

                                //Check
                                if ((rawOffset & 0xC0000000) == 0)
                                {
                                    //Read
                                    inStream.Seek(rawOffset, SeekOrigin.Begin);
                                    if (entry.Raws[RawSection.Sound].ContainsRawOffset(rawOffset))
                                        rawData = entry.Raws[RawSection.Sound][rawOffset];
                                    else { rawData = new RawStream(reader.ReadBytes(rawSize), rawOffset); entry.Raws[0].Add(rawData); }
                                    rawData.OffsetAddresses.Add(offsetAddress);
                                    rawData.LengthAddresses.Add(lengthAddress);
                                }
                            }

                            entry.TagData.Seek(entry.Offset + 80, SeekOrigin.Begin);
                            int extraInfosCount = metaReader.ReadInt32();
                            uint extraInfosOffset = metaReader.ReadUInt32();
                            for (int i = 0; i < extraInfosCount; i++)
                            {
                                //Goto
                                entry.TagData.Seek(extraInfosOffset + (i * 44) + 8, SeekOrigin.Begin);
                                offsetAddress = entry.TagData.Position;
                                rawOffset = metaReader.ReadInt32();
                                lengthAddress = entry.TagData.Position;
                                rawSize = metaReader.ReadInt32();

                                //Check
                                if ((rawOffset & 0xC0000000) == 0)
                                {
                                    //Read
                                    inStream.Seek(rawOffset, SeekOrigin.Begin);
                                    if (entry.Raws[RawSection.LipSync].ContainsRawOffset(rawOffset))
                                        rawData = entry.Raws[RawSection.LipSync][rawOffset];
                                    else { rawData = new RawStream(reader.ReadBytes(rawSize), rawOffset); entry.Raws[RawSection.LipSync].Add(rawData); }
                                    rawData.OffsetAddresses.Add(offsetAddress);
                                    rawData.LengthAddresses.Add(lengthAddress);
                                }
                            }
                            break;
                        #endregion
                        #region mode
                        case HaloTags.mode:
                            entry.TagData.Seek(entry.Offset + 36, SeekOrigin.Begin);
                            int sectionCount = metaReader.ReadInt32();
                            uint sectionOffset = metaReader.ReadUInt32();
                            for (int i = 0; i < sectionCount; i++)
                            {
                                entry.TagData.Seek(sectionOffset + (i * 92) + 56, SeekOrigin.Begin);
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

                            entry.TagData.Seek(entry.Offset + 116, SeekOrigin.Begin);
                            int prtCount = metaReader.ReadInt32();
                            uint prtOffset = metaReader.ReadUInt32();
                            for (int i = 0; i < prtCount; i++)
                            {
                                entry.TagData.Seek(prtOffset + (i * 88) + 52, SeekOrigin.Begin);
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
                        #region weat
                        case HaloTags.weat:
                            entry.TagData.Seek(entry.Offset, SeekOrigin.Begin);
                            int particleSystemCount = metaReader.ReadInt32();
                            uint particleSystemOffset = metaReader.ReadUInt32();
                            for (int i = 0; i < particleSystemCount; i++)
                            {
                                entry.TagData.Seek(particleSystemOffset + (i * 140) + 64, SeekOrigin.Begin);
                                offsetAddress = entry.TagData.Position;
                                rawOffset = metaReader.ReadInt32();
                                lengthAddress = entry.TagData.Position;
                                rawSize = metaReader.ReadInt32();

                                //Check
                                if ((rawOffset & 0xC0000000) == 0)
                                {
                                    //Read
                                    inStream.Seek(rawOffset, SeekOrigin.Begin);
                                    if (entry.Raws[RawSection.Weather].ContainsRawOffset(rawOffset))
                                        rawData = entry.Raws[RawSection.Weather][rawOffset];
                                    else { rawData = new RawStream(reader.ReadBytes(rawSize), rawOffset); entry.Raws[RawSection.Weather].Add(rawData); }
                                    rawData.OffsetAddresses.Add(offsetAddress);
                                    rawData.LengthAddresses.Add(lengthAddress);
                                }
                            }
                            break;
                        #endregion
                        #region DECR
                        case HaloTags.DECR:
                            entry.TagData.Seek(entry.Offset + 56, SeekOrigin.Begin);
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
                            entry.TagData.Seek(entry.Offset + 160, SeekOrigin.Begin);
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
                        #region jmad
                        case HaloTags.jmad:
                            entry.TagData.Seek(entry.Offset + 172, SeekOrigin.Begin);
                            int animationCount = metaReader.ReadInt32();
                            uint animationOffset = metaReader.ReadUInt32();
                            for (int i = 0; i < animationCount; i++)
                            {
                                entry.TagData.Seek(animationOffset + (i * 20) + 4, SeekOrigin.Begin);
                                lengthAddress = entry.TagData.Position;
                                rawSize = metaReader.ReadInt32();
                                offsetAddress = entry.TagData.Position;
                                rawOffset = metaReader.ReadInt32();

                                //Check
                                if ((rawOffset & 0xC0000000) == 0)
                                {
                                    //Read
                                    inStream.Seek(rawOffset, SeekOrigin.Begin);
                                    if (entry.Raws[RawSection.Animation].ContainsRawOffset(rawOffset))
                                        rawData = entry.Raws[RawSection.Animation][rawOffset];
                                    else { rawData = new RawStream(reader.ReadBytes(rawSize), rawOffset); entry.Raws[RawSection.Animation].Add(rawData); }
                                    rawData.OffsetAddresses.Add(offsetAddress);
                                    rawData.LengthAddresses.Add(lengthAddress);
                                }
                            }
                            break;
                        #endregion
                        #region bitm
                        case HaloTags.bitm:
                            entry.TagData.Seek(entry.Offset + 68, SeekOrigin.Begin);
                            int bitmapCount = metaReader.ReadInt32();
                            uint bitmapOffset = metaReader.ReadUInt32();
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
                            long bspAddress = (uint)entry.PostProcessedOffset;

                            //Goto Clusters
                            entry.TagData.Seek(bspAddress + 156, SeekOrigin.Begin);
                            int clusterCount = metaReader.ReadInt32();
                            uint clusterOffset = metaReader.ReadUInt32();
                            for (int i = 0; i < clusterCount; i++)
                            {
                                entry.TagData.Seek(clusterOffset + (i * 176) + 40, SeekOrigin.Begin);
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
                            entry.TagData.Seek(bspAddress + 312, SeekOrigin.Begin);
                            int geometriesCount = metaReader.ReadInt32();
                            uint geometriesOffset = metaReader.ReadUInt32();
                            for (int i = 0; i < geometriesCount; i++)
                            {
                                entry.TagData.Seek(geometriesOffset + (i * 200) + 40, SeekOrigin.Begin);
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

                            //Goto Water definitions
                            entry.TagData.Seek(bspAddress + 532, SeekOrigin.Begin);
                            int watersCount = metaReader.ReadInt32();
                            uint watersOffset = metaReader.ReadUInt32();
                            for (int i = 0; i < watersCount; i++)
                            {
                                entry.TagData.Seek(watersOffset + (i * 172) + 16, SeekOrigin.Begin);
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

                            //Goto Decorators Definitions
                            entry.TagData.Seek(bspAddress + 564, SeekOrigin.Begin);
                            int decoratorsCount = metaReader.ReadInt32();
                            uint decoratorsOffset = metaReader.ReadUInt32();
                            for (int i = 0; i < decoratorsCount; i++)
                            {
                                entry.TagData.Seek(decoratorsOffset + (i * 48) + 16, SeekOrigin.Begin);
                                uint cachesCount = metaReader.ReadUInt32();
                                uint cachesOffset = metaReader.ReadUInt32();
                                for (int j = 0; j < cachesCount; j++)
                                {
                                    entry.TagData.Seek(cachesOffset + (j * 44), SeekOrigin.Begin);
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
                            break;
                        #endregion
                        #region ltmp
                        case HaloTags.ltmp:
                            long lightmapAddress = (uint)entry.PostProcessedOffset;

                            //Goto Lightmap Groups
                            entry.TagData.Seek(lightmapAddress + 128);
                            int groupsCount = metaReader.ReadInt32();
                            uint groupsPointer = metaReader.ReadUInt32();
                            for (int i = 0; i < groupsCount; i++)
                            {
                                //Goto Cluster Definitions
                                entry.TagData.Seek(groupsPointer + (i * 104) + 32, SeekOrigin.Begin);
                                int clustersCount = metaReader.ReadInt32();
                                uint clustersOffset = metaReader.ReadUInt32();
                                for (int j = 0; j < clustersCount; j++)
                                {
                                    entry.TagData.Seek(clustersOffset + (j * 84) + 40, SeekOrigin.Begin);
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

                                //Goto Poop Definitions
                                entry.TagData.Seek(groupsPointer + (i * 104) + 48, SeekOrigin.Begin);
                                int poopsCount = metaReader.ReadInt32();
                                uint poopsOffset = metaReader.ReadUInt32();
                                for (int j = 0; j < poopsCount; j++)
                                {
                                    entry.TagData.Seek(poopsOffset + (j * 84) + 40, SeekOrigin.Begin);
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

                                //Goto Geometry Buckets
                                entry.TagData.Seek(groupsPointer + (i * 104) + 64, SeekOrigin.Begin);
                                int bucketsCount = metaReader.ReadInt32();
                                uint bucketsOffset = metaReader.ReadUInt32();
                                for (int j = 0; j < bucketsCount; j++)
                                {
                                    entry.TagData.Seek(bucketsOffset + (j * 56) + 12, SeekOrigin.Begin);
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
                            break;
                            #endregion
                    }
            }
        }
        /// <summary>
        /// Reads a string table from the file into the string list using the string data at an offset provided.
        /// </summary>
        /// <param name="inStream">The Halo 2 cached map file stream.</param>
        /// <param name="reader">The reader for the map stream.</param>
        /// <param name="globals">The globals object index entry.</param>
        /// <param name="memoryFileAddress">The memory address of the tag data.</param>
        /// <param name="offset">The globals-based offset to a strings info data section.</param>
        /// <param name="table">The string entry list to read the strings into.</param>
        private void ReadStringTable(Stream inStream, BinaryReader reader, IndexEntry globals, uint memoryFileAddress, uint offset, out StringEntry[] table)
        {
            //Read
            inStream.Seek(globals.Offset + offset, memoryFileAddress, SeekOrigin.Begin);
            int count = reader.ReadInt32();
            int tableLength = reader.ReadInt32();
            int indexOffset = reader.ReadInt32();
            int tableOffset = reader.ReadInt32();

            //Prepare
            StringObject[] stringObjects = new StringObject[count];
            table = new StringEntry[count];

            //Read Index
            inStream.Seek(indexOffset, SeekOrigin.Begin);
            for (int i = 0; i < count; i++)
            {
                stringObjects[i] = reader.Read<StringObject>();
                table[i] = new StringEntry() { ID = strings[stringObjects[i].StringID.Index] };
            }

            //Read Strings
            for (int i = 0; i < count; i++)
            {
                inStream.Seek(tableOffset + stringObjects[i].Offset, SeekOrigin.Begin);
                table[i].Value = reader.ReadUTF8NullTerminated();
            }
        }
        /// <summary>
        /// Saves this Halo 2 map file to the specfied file or stream.
        /// </summary>
        /// <param name="filename">A string that contains the name of the file to which to save this Halo 2 map.</param>
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
        /// Saves this Halo 2 map file to the specified stream.
        /// </summary>
        /// <param name="stream">The stream where the Halo 2 map will be saved.</param>
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
            if (!indexList.ContainsID(index.GlobalsId)) throw new MapFileExcption(new InvalidOperationException("Map does not contain globals tag group."));
            if (!indexList.ContainsID(index.ScenarioId)) throw new MapFileExcption(new InvalidOperationException("Map does not contain scenario tag group."));
            
            //Setup
            index.ScenarioId = scenario.Id;
            index.GlobalsId = globals.Id;
            header.ScenarioPath = scenario.Filename;
            
            //Prepare
            int offset = 0;
            char[] string128Buffer = null;

            //Strings tables and indices
            byte[] table = null;
            int enTable = 0, enIndex = 0, enSize = 0;
            int jpTable = 0, jpIndex = 0, jpSize = 0;
            int nlTable = 0, nlIndex = 0, nlSize = 0;
            int frTable = 0, frIndex = 0, frSize = 0;
            int esTable = 0, esIndex = 0, esSize = 0;
            int itTable = 0, itIndex = 0, itSize = 0;
            int krTable = 0, krIndex = 0, krSize = 0;
            int zhTable = 0, zhIndex = 0, zhSize = 0;
            int prTable = 0, prIndex = 0, prSize = 0;

            //Get Datas
            List<RawStream> soundData = indexList.SelectMany(e => e.Raws[RawSection.Sound]).ToList();
            List<RawStream> modelData = indexList.SelectMany(e => e.Raws[RawSection.Model]).ToList();
            List<RawStream> weatherData = indexList.SelectMany(e => e.Raws[RawSection.Weather]).ToList();
            List<RawStream> decoratorData = indexList.SelectMany(e => e.Raws[RawSection.DecoratorSet]).ToList();
            List<RawStream> particleModelData = indexList.SelectMany(e => e.Raws[RawSection.ParticleModel]).ToList();
            List<RawStream> lipSyncDatas = indexList.SelectMany(e => e.Raws[RawSection.LipSync]).ToList();
            List<RawStream> animationData = indexList.SelectMany(e => e.Raws[RawSection.Animation]).ToList();
            List<RawStream> bitmapData = indexList.SelectMany(e => e.Raws[RawSection.Bitmap]).ToList();
            List<RawStream>[] bspData = new List<RawStream>[bspTagData.Length];
            for (int i = 0; i < bspTagData.Length; i++)
                bspData[i] = indexList.Where(e => e.TagData == bspTagData[i]).SelectMany(e => e.Raws[RawSection.BSP]).ToList();
            
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
                using (BinaryReader metaReader = tagData.CreateReader())
                using (BinaryWriter metaWriter = tagData.CreateWriter())
                {
                    //Write sound raw data
                    WriteRawData(writer, soundData, metaWriter);

                    //Write model raw data
                    WriteRawData(writer, modelData, metaWriter);

                    //Write BSP raw data
                    for (int i = 0; i < bspTagData.Length; i++)
                        using (BinaryWriter bspWriter = bspTagData[i].CreateWriter())
                            WriteRawData(writer, bspData[i], bspWriter);

                    //Write weather raw data
                    WriteRawData(writer, weatherData, metaWriter);

                    //Write decorator raw data
                    WriteRawData(writer, decoratorData, metaWriter);

                    //Write lip-sync raw data
                    WriteRawData(writer, lipSyncDatas, metaWriter);

                    //Write particle model raw data
                    WriteRawData(writer, particleModelData, metaWriter);

                    //Write animation raw data
                    WriteRawData(writer, animationData, metaWriter);

                    //Write Structure BSP and Lightmap
                    List<VirtualStream> bspTagDataList = new List<VirtualStream>();
                    int bspLength = 0;
                    tagData.Seek(scenario.Offset + 528, SeekOrigin.Begin);
                    int sbspsCount = metaReader.ReadInt32();
                    uint sbspsOffset = metaReader.ReadUInt32();
                    for (int i = 0; i < sbspsCount; i++)
                    {
                        //Get tag data
                        VirtualStream bspTagData = null;
                        if (this.bspTagData.Length > i) bspTagData = this.bspTagData[i];
                        else
                        {
                            //Create new data
                            bspTagData = new VirtualStream(Index.IndexVirtualAddress + index.Length);

                            //Write blank header
                            StructureBspBlockHeader structureBspBlockHeader = new StructureBspBlockHeader() { StructureBsp = "sbsp" };

                            //Skip header
                            bspTagData.Seek(StructureBspBlockHeader.Length, SeekOrigin.Current);

                            //Align
                            bspTagData.Align(1024);

                            //Get length
                            structureBspBlockHeader.BlockLength = (int)bspTagData.Length;

                            //Write
                            bspTagData.Seek(bspTagData.BaseAddress, SeekOrigin.Begin);
                            using (BinaryWriter bspWriter = bspTagData.CreateWriter())
                                bspWriter.Write(structureBspBlockHeader);
                        }
                        
                        //Add to list
                        bspTagDataList.Add(bspTagData);

                        //Get block offset
                        offset = (int)stream.Align(512);

                        //Write scenario sbsp reference
                        tagData.Seek(sbspsOffset + (i * 68), SeekOrigin.Begin);
                        metaWriter.Write(offset);
                        metaWriter.Write((int)bspTagData.Length);
                        metaWriter.Write((int)(bspTagData.BaseAddress));
                        metaWriter.Write(0x0);
                        metaWriter.Write<TagFourCc>(HaloTags.sbsp);
                        tagData.Seek(4, SeekOrigin.Current);
                        metaWriter.Write<TagFourCc>(HaloTags.ltmp);
                        tagData.Seek(4, SeekOrigin.Current);

                        //Write block
                        writer.Write(bspTagData.ToArray());
                        if (bspTagData.Length > bspLength)
                            bspLength = (int)bspTagData.Length;
                    }
                    header.MapDataLength += (uint)bspLength;
                    bspTagData = bspTagDataList.ToArray();

                    //Write Strings 128
                    header.StringCount = (uint)strings.Count;
                    header.Strings128Offset = (uint)stream.Align(512);
                    foreach (string stringId in strings)
                    {
                        string128Buffer = new char[128];
                        for (int i = 0; i < Math.Min(128, stringId.Length); i++)
                            string128Buffer[i] = stringId[i];
                        writer.Write(string128Buffer);
                    }

                    //Write String Index
                    offset = 0;
                    header.StringsIndexOffset = (uint)stream.Align(512);
                    foreach (string stringId in strings)
                    {
                        writer.Write(offset);
                        offset += Encoding.UTF8.GetByteCount(stringId) + 1;
                    }

                    //Write String IDs
                    header.StringsOffset = (uint)stream.Align(512);
                    foreach (string stringId in strings)
                        writer.WriteUTF8NullTerminated(stringId);
                    header.FileNamesOffset = (uint)stream.Align(512);
                    stream.Seek(header.FileNamesOffset, SeekOrigin.Begin);
                    header.StringsLength = (uint)strings.Sum(s => Encoding.UTF8.GetByteCount(s) + 1);

                    //Write Files
                    header.FileNameCount = (uint)indexList.Count;
                    header.FileNamesOffset = (uint)stream.Align(512);
                    header.FileNamesLength = (uint)indexList.Sum(e => Encoding.UTF8.GetByteCount(e.Filename) + 1);
                    foreach (var indexEntry in indexList)
                        writer.WriteUTF8NullTerminated(indexEntry.Filename);

                    //Write Files Index
                    offset = 0;
                    header.FileNamesIndexOffset = (uint)stream.Align(512);
                    foreach (var indexEntry in indexList)
                    {
                        writer.Write(offset);
                        offset += Encoding.UTF8.GetByteCount(indexEntry.Filename) + 1;
                    }

                    //Prepare String Lists
                    List<StringEntry> en = new List<StringEntry>();
                    List<StringEntry> jp = new List<StringEntry>();
                    List<StringEntry> nl = new List<StringEntry>();
                    List<StringEntry> fr = new List<StringEntry>();
                    List<StringEntry> es = new List<StringEntry>();
                    List<StringEntry> it = new List<StringEntry>();
                    List<StringEntry> kr = new List<StringEntry>();
                    List<StringEntry> zh = new List<StringEntry>();
                    List<StringEntry> pr = new List<StringEntry>();

                    //Loop
                    foreach (var unicode in indexList.Where(e => e.Root == HaloTags.unic))
                    {
                        //Goto
                        tagData.Seek(unicode.Offset + 16, SeekOrigin.Begin);

                        //Write English
                        metaWriter.Write((ushort)en.Count);
                        metaWriter.Write((ushort)unicode.Strings.English.Count);
                        en.AddRange(unicode.Strings.English);

                        //Write Japanese
                        metaWriter.Write((ushort)jp.Count);
                        metaWriter.Write((ushort)unicode.Strings.Japanese.Count);
                        jp.AddRange(unicode.Strings.Japanese);

                        //Write German
                        metaWriter.Write((ushort)nl.Count);
                        metaWriter.Write((ushort)unicode.Strings.German.Count);
                        nl.AddRange(unicode.Strings.German);

                        //Write French
                        metaWriter.Write((ushort)fr.Count);
                        metaWriter.Write((ushort)unicode.Strings.French.Count);
                        fr.AddRange(unicode.Strings.French);

                        //Write Spanish
                        metaWriter.Write((ushort)es.Count);
                        metaWriter.Write((ushort)unicode.Strings.Spanish.Count);
                        es.AddRange(unicode.Strings.Spanish);

                        //Write Italian
                        metaWriter.Write((ushort)it.Count);
                        metaWriter.Write((ushort)unicode.Strings.Italian.Count);
                        it.AddRange(unicode.Strings.Italian);

                        //Write Korean
                        metaWriter.Write((ushort)kr.Count);
                        metaWriter.Write((ushort)unicode.Strings.Korean.Count);
                        kr.AddRange(unicode.Strings.Korean);

                        //Write Chinese
                        metaWriter.Write((ushort)zh.Count);
                        metaWriter.Write((ushort)unicode.Strings.Chinese.Count);
                        zh.AddRange(unicode.Strings.Chinese);

                        //Write Portuguese
                        metaWriter.Write((ushort)pr.Count);
                        metaWriter.Write((ushort)unicode.Strings.Portuguese.Count);
                        pr.AddRange(unicode.Strings.Portuguese);
                    }

                    //Write English Table
                    enIndex = (int)stream.Align(512);
                    writer.Write(CreateStringIndex(en));
                    enTable = (int)stream.Align(512);
                    table = CreateStringTable(en);
                    writer.Write(table);
                    enSize = table.Length;

                    //Write Japanese Table
                    jpIndex = (int)stream.Align(512);
                    writer.Write(CreateStringIndex(jp));
                    jpTable = (int)stream.Align(512);
                    table = CreateStringTable(jp);
                    writer.Write(table);
                    jpSize = table.Length;

                    //Write Dutch Table
                    nlIndex = (int)stream.Align(512);
                    writer.Write(CreateStringIndex(nl));
                    nlTable = (int)stream.Align(512);
                    table = CreateStringTable(nl);
                    writer.Write(table);
                    nlSize = table.Length;

                    //Write French Table
                    frIndex = (int)stream.Align(512);
                    writer.Write(CreateStringIndex(fr));
                    frTable = (int)stream.Align(512);
                    table = CreateStringTable(fr);
                    writer.Write(table);
                    frSize = table.Length;

                    //Write Spanish Table
                    esIndex = (int)stream.Align(512);
                    writer.Write(CreateStringIndex(es));
                    esTable = (int)stream.Align(512);
                    table = CreateStringTable(es);
                    writer.Write(table);
                    esSize = table.Length;

                    //Write Italian Table
                    itIndex = (int)stream.Align(512);
                    writer.Write(CreateStringIndex(it));
                    itTable = (int)stream.Align(512);
                    table = CreateStringTable(it);
                    writer.Write(table);
                    itSize = table.Length;

                    //Write Korean Table
                    krIndex = (int)stream.Align(512);
                    writer.Write(CreateStringIndex(kr));
                    krTable = (int)stream.Align(512);
                    table = CreateStringTable(kr);
                    writer.Write(table);
                    krSize = table.Length;

                    //Write Chinese Table
                    zhIndex = (int)stream.Align(512);
                    writer.Write(CreateStringIndex(zh));
                    zhTable = (int)stream.Align(512);
                    table = CreateStringTable(zh);
                    writer.Write(table);
                    zhSize = table.Length;

                    //Write Portuguese Table
                    prIndex = (int)stream.Align(512);
                    writer.Write(CreateStringIndex(pr));
                    prTable = (int)stream.Align(512);
                    table = CreateStringTable(pr);
                    writer.Write(table);
                    prSize = table.Length;

                    //Write Crazy
                    header.CrazyLength = (uint)crazyData.Length;
                    header.CrazyOffset = (uint)stream.Align(512);
                    writer.Write(crazyData.ToArray());

                    //Write bitmap data
                    WriteRawData(writer, bitmapData, metaWriter);

                    //Write Index
                    header.IndexOffset = (uint)stream.Align(512);
                    writer.Write(index);

                    //Write English to globals
                    tagData.Seek(globals.Offset + 400, SeekOrigin.Begin);
                    metaWriter.Write(en.Count);
                    metaWriter.Write(enSize);
                    metaWriter.Write(enIndex);
                    metaWriter.Write(enTable);

                    //Write Japanese to globals
                    tagData.Seek(12, SeekOrigin.Current);
                    metaWriter.Write(jp.Count);
                    metaWriter.Write(jpSize);
                    metaWriter.Write(jpIndex);
                    metaWriter.Write(jpTable);

                    //Write Dutch to globals
                    tagData.Seek(12, SeekOrigin.Current);
                    metaWriter.Write(nl.Count);
                    metaWriter.Write(nlSize);
                    metaWriter.Write(nlIndex);
                    metaWriter.Write(nlTable);

                    //Write French to globals
                    tagData.Seek(12, SeekOrigin.Current);
                    metaWriter.Write(fr.Count);
                    metaWriter.Write(frSize);
                    metaWriter.Write(frIndex);
                    metaWriter.Write(frTable);

                    //Write Spanish to globals
                    tagData.Seek(12, SeekOrigin.Current);
                    metaWriter.Write(es.Count);
                    metaWriter.Write(esSize);
                    metaWriter.Write(esIndex);
                    metaWriter.Write(esTable);

                    //Write Italian to globals
                    tagData.Seek(12, SeekOrigin.Current);
                    metaWriter.Write(it.Count);
                    metaWriter.Write(itSize);
                    metaWriter.Write(itIndex);
                    metaWriter.Write(itTable);

                    //Write Korean to globals
                    tagData.Seek(12, SeekOrigin.Current);
                    metaWriter.Write(kr.Count);
                    metaWriter.Write(krSize);
                    metaWriter.Write(krIndex);
                    metaWriter.Write(krTable);

                    //Write Chinese to globals
                    tagData.Seek(12, SeekOrigin.Current);
                    metaWriter.Write(zh.Count);
                    metaWriter.Write(zhSize);
                    metaWriter.Write(zhIndex);
                    metaWriter.Write(zhTable);

                    //Write Portuguese to globals
                    tagData.Seek(12, SeekOrigin.Current);
                    metaWriter.Write(pr.Count);
                    metaWriter.Write(prSize);
                    metaWriter.Write(prIndex);
                    metaWriter.Write(prTable);
                }

                //Write Meta
                header.TagDataLength = (uint)tagData.Length;
                writer.Write(tagData.ToArray());
                header.MapDataLength += header.TagDataLength;

#if DEBUG
                //DEBUG MAP PAD FIX
                uint remainder = header.MapDataLength % 1024u;
                
                //Pad File?
                if (remainder > 0)
                {
                    byte[] padding = new byte[1024 - remainder];
                    stream.Write(padding, 0, padding.Length);
                    header.MapDataLength += (uint)padding.Length;
                    header.TagDataLength += (uint)padding.Length;
                }
#endif

                //Set
                header.FileLength = (uint)stream.Length;

                //Sign
                header.Checksum = 0;
                stream.Seek(2048, SeekOrigin.Begin);
                for (int i = 0; i < (header.FileLength - 2048) / 4; i++)
                    header.Checksum ^= reader.ReadUInt32();

                //Write header
                stream.Seek(0, SeekOrigin.Begin);
                writer.Write(header);

                //Read
                ReadRaws(stream, reader);
            }
        }
        /// <summary>
        /// Swaps a BSP's tag data stream buffer using the specified buffer and virtual address.
        /// </summary>
        /// <param name="tagData">The byte array to swap the tag data stream buffer with.</param>
        /// <param name="bspIndex">The zero-based index of the BSP.</param>
        /// <param name="virtualAddress">The virtual address of the new tag data.</param>
        /// <exception cref="ArgumentNullException"><paramref name="tagData"/> is null.</exception>
        public void SwapBspTagBuffer(byte[] tagData, int bspIndex, long virtualAddress)
        {
            //Check
            if (tagData == null) throw new ArgumentNullException(nameof(tagData));
            if (bspIndex < 0 || bspIndex >= bspTagData.Length) throw new ArgumentOutOfRangeException(nameof(bspIndex));

            //Get entries
            IndexEntry[] entries = indexList.Where(e => e.TagData == bspTagData[bspIndex]).ToArray();

            //Dispose?
            if (bspTagData[bspIndex] != null) bspTagData[bspIndex].Dispose();
            bspTagData[bspIndex] = new VirtualStream(virtualAddress, (byte[])tagData.Clone());

            //Change entry's tag data.
            foreach (IndexEntry entry in entries)
                entry.TagData = bspTagData[bspIndex];
        }
        /// <summary>
        /// Swaps the map file's tag data stream buffer using the specified buffer and virtual address.
        /// </summary>
        /// <param name="tagData">The byte array to swap the tag data stream buffer with.</param>
        /// <param name="virtualAddress">The virtual address of the new tag data.</param>
        /// <exception cref="ArgumentNullException"><paramref name="tagData"/> is null.</exception>
        public void SwapTagBuffer(byte[] tagData, long virtualAddress)
        {
            //Check
            if (tagData == null) throw new ArgumentNullException(nameof(tagData));

            //Get entries
            IndexEntry[] entries = indexList.Where(e => e.TagData == this.tagData).ToArray();

            //Dispose?
            if (this.tagData != null) this.tagData.Dispose();
            this.tagData = new VirtualStream(virtualAddress, (byte[])tagData.Clone());

            //Change entry's tag data.
            foreach (IndexEntry entry in entries)
                entry.TagData = this.tagData;
        }
        /// <summary>
        /// Gets and returns the stream containing the specified BSP's tags' data.
        /// </summary>
        /// <param name="bspIndex">The zero-based index of the BSP.</param>
        public VirtualStream GetBspTagDataStream(int bspIndex)
        {
            //Check
            if (bspIndex < 0 || bspIndex >= bspTagData.Length) throw new ArgumentOutOfRangeException(nameof(bspIndex));

            //Return
            return bspTagData[bspIndex];
        }
        /// <summary>
        /// Returns the map's name.
        /// </summary>
        /// <returns>The map's name.</returns>
        public override string ToString()
        {
            return header.Name;
        }
        /// <summary>
        /// Closes the map file, clearing all used buffers.
        /// </summary>
        public void Close()
        {
            //Dispose
            foreach (var entry in indexList)
                entry.Dispose();
            foreach (var data in bspTagData)
                if (data != null)
                    data.Dispose();
            if (crazyData != null)
                crazyData.Dispose();
            if (tagData != null)
                tagData.Dispose();

            //Setup
            header = Header.CreateDefault();
            index = Index.CreateDefault();
            bspTagData = new VirtualStream[0];
            strings = new StringList();
            crazyData = new MemoryStream();
            tags = new TagHierarchyList();
            indexList = new IndexEntryList(this);
            tagData = VirtualStream.Empty;
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
            bspTagData = null;
            strings = null;
            tags = null;
            indexList = null;
            tagData = null;
        }
        /// <summary>
        /// Retrieves information about a supplied tag block.
        /// </summary>
        /// <param name="tagBlock">The tag block to retrieve information about.</param>
        /// <param name="isValid">True if the supplied tag block is valid, false if it is not.</param>
        /// <returns>An instance of <see cref="TagBlockInformation"/> that, if valid, contains information about <paramref name="tagBlock"/>.</returns>
        public TagBlockInformation GetTagBlockInfo(TagBlock tagBlock, out bool isValid)
        {
            //Prepare
            TagBlockInformation info = null;
            bool valid = true;

            //Get Map Info
            int tagDataStart = (int)(header.IndexOffset + header.IndexLength);
            uint blockOffset = tagBlock.Offset - Index.IndexTagsAddress;

            //Check for valid pointer...
            valid &= !tagBlock.IsZero;
            valid &= tagBlock.Count > 0;
            valid &= blockOffset > 0 && tagData.Length > blockOffset;

            //Check
            if (valid) foreach (var entry in
                    indexList.Where(e => e.PostProcessedOffset < tagBlock.Offset && e.PostProcessedOffset + e.PostProcessedSize >= tagBlock.Offset))
                    info = new TagBlockInformation(entry, tagBlock);


            //Return
            isValid = valid;
            return info;
        }
        /// <summary>
        /// Adds a new string identifier to the map.
        /// </summary>
        /// <param name="stringId">The string identifier.</param>
        /// <exception cref="ArgumentNullException"><paramref name="stringId"/> is null.</exception>
        public StringId AddStringId(string stringId)
        {
            //Check
            if (stringId == null) throw new ArgumentNullException(nameof(stringId));

            //Prepare
            int index = -1;

            //Add
            if (!strings.Contains(stringId))
                strings.Add(stringId);

            //Get
            index = strings.IndexOf(stringId);

            //Return
            return StringId.FromString(stringId, index);
        }
        /// <summary>
        /// Creates a padded index table for the current Halo 2 map.
        /// </summary>
        /// <returns>A Halo 2 index table containing the index, tags, and object entries present in this instance.</returns>
        private byte[] CreateIndex()
        {
            //Edit Index
            index.ObjectCount = (uint)indexList.Count;
            index.TagCount = (uint)tags.Count;
            index.ObjectsOffset = (uint)(tags.Count * TagHierarchy.Length + Index.IndexTagsAddress);
            index.TagsAddress = Index.IndexTagsAddress;

            //Calculate minimum length...
            int length = (Index.Length + (TagHierarchy.Length * tags.Count) + (ObjectEntry.Length * indexList.Count)).PadTo(4096);

            //Check
            if (length > header.IndexLength) throw new MapFileExcption("Unable to save map. Index length is larger than expected.");
            else length = (int)header.IndexLength;

            //Write
            byte[] indexTable = new byte[length];
            using (MemoryStream ms = new MemoryStream(indexTable))
            using (BinaryWriter writer = new BinaryWriter(ms))
            {
                writer.Write(index);                    //Write index header
                foreach (TagHierarchy tag in tags)      //Write tags
                    writer.Write(tag);
                foreach (IndexEntry entry in indexList) //Write object entries
                    writer.Write(entry.GetObjectEntry());
            }

            //Return
            return indexTable;
        }
        /// <summary>
        /// Creates a strings table.
        /// </summary>
        /// <param name="stringList">The strings in the table.</param>
        /// <returns>A byte array containing a 512-byte padded string table.</returns>
        private byte[] CreateStringTable(IList<StringEntry> stringList)
        {
            int length = 0;
            for (int i = 0; i < stringList.Count; i++)
                length += Encoding.UTF8.GetByteCount(stringList[i].Value) + 1;
            byte[] stringTable = new byte[length];
            using (MemoryStream stream = new MemoryStream(stringTable))
            using (BinaryWriter writer = new BinaryWriter(stream))
            {
                for (int i = 0; i < stringList.Count; i++)
                    writer.WriteUTF8NullTerminated(stringList[i].Value);
            }
            return stringTable;
        }
        /// <summary>
        /// Creates a string table index.
        /// </summary>
        /// <param name="stringTable">The strings in the table.</param>
        /// <returns>A byte array containing a 512-byte padded string index.</returns>
        private byte[] CreateStringIndex(IList<StringEntry> stringTable)
        {
            //Prepare
            int offset = 0;
            int length = 8 * stringTable.Count;
            byte[] index = new byte[length];

            //Write
            using (MemoryStream stream = new MemoryStream(index))
            using (BinaryWriter writer = new BinaryWriter(stream))
                for (int i = 0; i < stringTable.Count; i++)
                {
                    //Write
                    writer.Write(StringId.FromString(stringTable[i].ID, strings.IndexOf(stringTable[i].ID)));
                    writer.Write(offset);

                    //Increment
                    offset += Encoding.UTF8.GetByteCount(stringTable[i].Value) + 1;
                }
            return index;
        }
        /// <summary>
        /// Writes a raw section to the map using the specified map writer, raw data, and tag writer.
        /// </summary>
        /// <param name="mapWriter">The <see cref="BinaryWriter"/> that writes to the map file stream.</param>
        /// <param name="rawDataStreams">The raw data streams in a section.</param>
        /// <param name="tagWriter">The <see cref="BinaryWriter"/> that writes to the tag data stream.</param>
        private void WriteRawData(BinaryWriter mapWriter, IEnumerable<RawStream> rawDataStreams, BinaryWriter tagWriter)
        {
            //Loop
            foreach (RawStream raw in rawDataStreams)
            {
                //Align
                long address = mapWriter.BaseStream.Align(512);

                //Write Lengths
                foreach (var offset in raw.LengthAddresses)
                {
                    tagWriter.BaseStream.Seek(offset, SeekOrigin.Begin);
                    tagWriter.Write((uint)raw.Length);
                }

                //Write Addresses
                foreach (var offset in raw.OffsetAddresses)
                {
                    tagWriter.BaseStream.Seek(offset, SeekOrigin.Begin);
                    tagWriter.Write((uint)address);
                }

                //Write raw
                mapWriter.Write(raw.ToArray());
            }
        }

        /// <summary>
        /// Represents a Halo 2 Tag Block information container.
        /// </summary>
        [Serializable]
        public sealed class TagBlockInformation
        {
            /// <summary>
            /// Gets and returns the index entry that owns this tag block.
            /// </summary>
            public IndexEntry Owner
            {
                get { return owner; }
            }
            /// <summary>
            /// Gets and returns the tag block.
            /// </summary>
            public TagBlock TagBlock
            {
                get { return tagBlock; }
            }

            private readonly IndexEntry owner;
            private readonly TagBlock tagBlock;

            /// <summary>
            /// Initializes a new <see cref="TagBlockInformation"/> instance using the supplied index entry and tag block.
            /// </summary>
            /// <param name="owner">The <see cref="IndexEntry"/> that owns <paramref name="tagBlock"/>.</param>
            /// <param name="tagBlock">The <see cref="HaloLibrary.TagBlock"/>.</param>
            public TagBlockInformation(IndexEntry owner, TagBlock tagBlock)
            {
                this.owner = owner;
                this.tagBlock = tagBlock;
            }
        }

        /// <summary>
        /// Represents a Halo 2 tag heirarchy list.
        /// </summary>
        [Serializable]
        public sealed class TagHierarchyList : IEnumerable<TagHierarchy>
        {
            /// <summary>
            /// Gets the number of tag hierarchy structures this list contains.
            /// </summary>
            public int Count
            {
                get { return tags.Count; }
            }

            private readonly Dictionary<TagFourCc, TagHierarchy> tags;

            /// <summary>
            /// Initializes the <see cref="TagHierarchyList"/> using the supplied <see cref="TagHierarchy"/> array.
            /// </summary>
            /// <param name="tagHierarchies">The <see cref="TagHierarchy"/> array to copy into the new list.</param>
            public TagHierarchyList(TagHierarchy[] tagHierarchies)
            {
                //Prepare
                tags = new Dictionary<TagFourCc, TagHierarchy>();

                //Add
                foreach (TagHierarchy tagHierarchy in tagHierarchies)
                    tags.Add(tagHierarchy.Root, tagHierarchy);
            }
            /// <summary>
            /// Initializes a new <see cref="TagHierarchyList"/>.
            /// </summary>
            public TagHierarchyList()
            {
                tags = new Dictionary<TagFourCc, TagHierarchy>();
            }
            /// <summary>
            /// Gets and returns the <see cref="TagHierarchy"/> whose root is the specified <see cref="TagFourCc"/>.
            /// </summary>
            /// <param name="tag">The root of the <see cref="TagHierarchy"/> to get.</param>
            /// <returns>A <see cref="TagHierarchy"/> structure whose <see cref="TagHierarchy.Root"/> value is the specified <see cref="TagFourCc"/> value.</returns>
            /// <exception cref="ArgumentException">Occurs when the specified tag root is not found.</exception>
            public TagHierarchy this[TagFourCc tag]
            {
                get
                {
                    if (tags.ContainsKey(tag)) return tags[tag];
                    else throw new ArgumentException("Unable to find tag hierarchy for the supplied tag.", "tag");
                }
            }
            /// <summary>
            /// Checks if the list contains an tag hierarchy whose root matches the supplied tag.
            /// </summary>
            /// <param name="tag">The ID to check.</param>
            /// <returns>True if the list contains an tag hierarchy whose root matches the supplied tag, false if not.</returns>
            public bool ContainsTag(TagFourCc tag)
            {
                return tags.ContainsKey(tag);
            }
            /// <summary>
            /// Returns an enumerator that iterates through the <see cref="TagHierarchyList"/>.
            /// </summary>
            /// <returns>An enumerator.</returns>
            public IEnumerator<TagHierarchy> GetEnumerator()
            {
                return tags.Values.GetEnumerator();
            }
            /// <summary>
            /// Gets a string representation of this list.
            /// </summary>
            /// <returns>A string representation of this list.</returns>
            public override string ToString()
            {
                return string.Format("Count = {0}", tags.Count);
            }
            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }

        /// <summary>
        /// Represents a Halo 2 index entry list.
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

            private readonly MapFile owner;
            private readonly Dictionary<uint, IndexEntry> entries;
            private readonly Dictionary<int, uint> indexLookup;

            /// <summary>
            /// Intializes a new <see cref="IndexEntryList"/> copying the supplied <see cref="IndexEntry"/> array into the list.
            /// </summary>
            /// <param name="owner">The map file that owns this index entry list.</param>
            /// <param name="indexEntries">The array to copy into the new list.</param>
            public IndexEntryList(MapFile owner, IndexEntry[] indexEntries) : this(owner)
            {
                //Check
                if (indexEntries == null) throw new ArgumentNullException(nameof(indexEntries));
                if (owner == null) throw new ArgumentNullException(nameof(owner));

                //Add
                for (int i = 0; i < indexEntries.Length; i++)
                {
                    entries.Add(indexEntries[i].Id, indexEntries[i]);
                    indexLookup.Add(i, indexEntries[i].Id);
                    indexEntries[i].Owner = owner;
                }

                //Set owner
                this.owner = owner;
            }
            /// <summary>
            /// Initializes a new <see cref="IndexEntryList"/>.
            /// </summary>
            /// <param name="owner">The map file that owns this index entry list.</param>
            public IndexEntryList(MapFile owner)
            {
                //Set
                owner = owner ?? throw new ArgumentNullException(nameof(owner));

                //Setup
                entries = new Dictionary<uint, IndexEntry>();
                indexLookup = new Dictionary<int, uint>();
            }
            /// <summary>
            /// Checks if the list contains an index entry whose ID matches the supplied ID.
            /// </summary>
            /// <param name="id">The ID to check.</param>
            /// <returns>True if the list contains an index entry whose ID is the supplied ID, false if not.</returns>
            public bool ContainsID(TagId id)
            {
                return entries.ContainsKey(id.Dword);
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
            /// Attempts to insert an index entry to the list.
            /// </summary>
            /// <param name="index">The zero-based index in the list at which <paramref name="entry"/> is to be inserted.</param>
            /// <param name="entry">The index entry to be inserted into the list.</param>
            /// <returns><see langword="true"/> if the index entry was successfully inserted; otherwise, <see langword="false"/>.</returns>
            public bool Insert(int index, IndexEntry entry)
            {
                //Check
                if (entries.ContainsKey(entry.Id)) return false;
                var indexEntries = entries.Values.ToList();
                indexEntries.Insert(index, entry);
                entry.Owner = owner;

                //Rebuild dictionaries
                entries.Clear();
                indexLookup.Clear();
                foreach (IndexEntry indexEntry in indexEntries)
                {
                    indexLookup.Add(entries.Count, indexEntry.Id);
                    entries.Add(indexEntry.Id, indexEntry);
                }
                return true;
            }
            /// <summary>
            /// Attempts to add an index entry to the end of the list.
            /// </summary>
            /// <param name="entry">The entry to be added to the list.</param>
            /// <returns><see langword="true"/> if the index entry was successfully added; otherwise, <see langword="false"/>.</returns>
            public bool Add(IndexEntry entry)
            {
                //Check
                if (entries.ContainsKey(entry.Id.Dword)) return false;
                var indexEntries = entries.Values.ToList();
                indexEntries.Add(entry);
                entry.Owner = owner;

                //Rebuild dictionary
                entries.Clear();
                indexLookup.Clear();
                foreach (IndexEntry indexEntry in indexEntries)
                {
                    indexLookup.Add(entries.Count, indexEntry.Id.Dword);
                    entries.Add(indexEntry.Id.Dword, indexEntry);
                }
                return true;
            }
            /// <summary>
            /// Attempts to remove an index entry from the list.
            /// </summary>
            /// <param name="entry">The entry to be removed from the list.</param>
            /// <returns><see langword="true"/> if the index entry was successfully removed; otherwise, <see langword="false"/>.</returns>
            public bool Remove(IndexEntry entry)
            {
                //Check
                if (!entries.ContainsKey(entry.Id)) return false;
                var indexEntries = entries.Values.ToList();
                indexEntries.Remove(entry);
                entry.Owner = null;

                //Rebuild dictionary
                entries.Clear();
                indexLookup.Clear();
                foreach (IndexEntry indexEntry in indexEntries)
                {
                    indexLookup.Add(entries.Count, indexEntry.Id);
                    entries.Add(indexEntry.Id, indexEntry);
                }
                return true;
            }
            IEnumerator IEnumerable.GetEnumerator()
            {
                return entries.Values.GetEnumerator();
            }
        }

        /// <summary>
        /// Represents a Halo 2 string list.
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
            public StringList() : this(DefaultStrings.GetDefaultStrings().ToArray()) { }
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
    /// Represents an error that occurs while handling a Halo 2 map file.
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
