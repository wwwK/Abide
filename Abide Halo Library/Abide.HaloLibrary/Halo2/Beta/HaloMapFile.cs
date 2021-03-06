﻿using Abide.HaloLibrary.Halo2BetaMap;
using Abide.HaloLibrary.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abide.HaloLibrary.Halo2.Beta
{
    /// <summary>
    /// Represents a container for a Halo 2 beta map file.
    /// </summary>
    public sealed class HaloMapFile
    {
        private Dictionary<uint, HaloTag> tagDictionary = new Dictionary<uint, HaloTag>();
        private Header header = new Header();
        private Index index = new Index();
        private string[] strings = null;
        private uint tagDataMemoryAddressTranslator;
        private uint[] bspTagDataMemoryAddressTranslators;

        /// <summary>
        /// Gets or sets the name of the map.
        /// </summary>
        public string Name
        {
            get => header.Name;
            set => header.Name = value;
        }
        /// <summary>
        /// Gets or sets the map scenario tag ID.
        /// </summary>
        public TagId ScenarioTagId
        {
            get => index.ScenarioId;
            set => index.ScenarioId = value;
        }
        /// <summary>
        /// Gets and returns the map's index table offset.
        /// </summary>
        public int IndexOffset
        {
            get => (int)header.IndexOffset;
        }
        /// <summary>
        /// Gets and returns the map's index table length.
        /// </summary>
        public int IndexLength
        {
            get => (int)header.IndexLength;
        }
        /// <summary>
        /// Gets and returns the map's tag data length.
        /// </summary>
        public int TagDataLength
        {
            get => (int)header.TagDataLength;
        }
        /// <summary>
        /// Gets and returns the map's total data length.
        /// </summary>
        public int TotalDataLength
        {
            get => (int)header.MapDataLength;
        }
        /// <summary>
        /// Gets or sets the fully qualified name of the Halo map file, or the relative file name.
        /// </summary>
        public string FileName { get; set; } = string.Empty;

        /// <summary>
        /// Creates a new instance of the <see cref="HaloMapFile"/> class.
        /// </summary>
        public HaloMapFile() { }
        /// <summary>
        /// Creates a new <see cref="BinaryReader"/> using the file specified by <see cref="FileName"/>.
        /// </summary>
        /// <returns></returns>
        public BinaryReader OpenRead()
        {
            if (File.Exists(FileName))
                return new BinaryReader(File.OpenRead(FileName), Encoding.UTF8, false);
            else throw new FileNotFoundException("Unable to open specified map file for reading.", FileName ?? "null");
        }
        /// <summary>
        /// Creates a new <see cref="BinaryWriter"/> using the file specified by <see cref="FileName"/>.
        /// </summary>
        /// <returns></returns>
        public BinaryWriter OpenWrite()
        {
            if (File.Exists(FileName))
                return new BinaryWriter(File.OpenWrite(FileName), Encoding.UTF8, false);
            else throw new FileNotFoundException("Unable to open specified map file for writing.", FileName ?? "null");
        }
        /// <summary>
        /// Creates a new <see cref="BinaryWriter"/> using the file specified by <see cref="FileName"/>.
        /// </summary>
        /// <returns></returns>
        private BinaryWriter CreateNew()
        {
            return new BinaryWriter(File.Create(FileName), Encoding.UTF8, false);
        }
        /// <summary>
        /// Processes the Halo map file.
        /// </summary>
        public void Load()
        {
            using (BinaryReader reader = OpenRead())
            {
                header = reader.Read<Header>();

                strings = new string[header.StringCount];
                for (int i = 0; i < header.StringCount; i++)
                {
                    reader.BaseStream.Seek(header.StringsIndexOffset + (i * 4), SeekOrigin.Begin);
                    uint offset = reader.ReadUInt32();

                    reader.BaseStream.Seek(header.StringsOffset + offset, SeekOrigin.Begin);
                    strings[i] = reader.ReadUTF8NullTerminated();
                }

                reader.BaseStream.Seek(header.IndexOffset, SeekOrigin.Begin);
                index = reader.Read<Index>();

                uint baseAddress = index.ObjectsAddress + header.IndexLength;
                uint bspDataLength = header.MapDataLength - (header.TagDataLength + header.IndexLength + Index.Length);
                tagDataMemoryAddressTranslator = baseAddress + bspDataLength - (header.IndexOffset + header.IndexLength);
                HaloTag[] tags = new HaloTag[index.ObjectCount];

                tagDictionary.Clear();
                for (int i = 0; i < index.ObjectCount; i++)
                {
                    reader.BaseStream.Seek(header.IndexOffset + Index.Length + (i * ObjectEntry.Length), SeekOrigin.Begin);
                    tags[i] = new HaloTag(this, reader);

                    if (tags[i].MemoryAddress > 0)
                        tags[i].BaseAddress = tagDataMemoryAddressTranslator;

                    reader.BaseStream.Seek(header.IndexOffset + Index.Length + (tags[i].FileNameMemoryAddress - index.ObjectsAddress), SeekOrigin.Begin);
                    tags[i].TagName = reader.ReadUTF8NullTerminated();

                    tagDictionary.Add(tags[i].Id.Dword, tags[i]);
                }

                var scenarioTag = GetTagById(ScenarioTagId);
                reader.BaseStream.Seek(scenarioTag.FileAddress + 828, SeekOrigin.Begin);
                var structureBsps = reader.ReadTagBlock();
                bspTagDataMemoryAddressTranslators = new uint[structureBsps.Count];
                for (int i = 0; i < structureBsps.Count; i++)
                {
                    reader.BaseStream.Seek(structureBsps.Offset + (i * 86), scenarioTag.BaseAddress, SeekOrigin.Begin);
                    uint structureBspOffset = reader.ReadUInt32();
                    _ = reader.ReadUInt32();
                    _ = reader.ReadUInt32();
                    _ = reader.ReadInt32();
                    _ = reader.Read<TagFourCc>();
                    _ = reader.ReadUInt32();
                    _ = reader.ReadUInt32();
                    TagId sbspId = reader.ReadTagId();
                    _ = reader.Read<TagFourCc>();
                    _ = reader.ReadUInt32();
                    _ = reader.ReadUInt32();
                    TagId ltmpId = reader.ReadTagId();

                    if (!sbspId.IsNull)
                    {
                        reader.BaseStream.Seek(structureBspOffset, SeekOrigin.Begin);
                        var sbspHeader = reader.Read<StructureBspBlockHeader>();

                        var structureBspTag = GetTagById(sbspId);
                        structureBspTag.MemoryAddress = sbspHeader.StructureBspOffset;
                        bspTagDataMemoryAddressTranslators[i] = sbspHeader.StructureBspOffset - (structureBspOffset + StructureBspBlockHeader.Length);
                        structureBspTag.BaseAddress = bspTagDataMemoryAddressTranslators[i];

                        if (!ltmpId.IsNull)
                        {
                            var lightmapTag = GetTagById(ltmpId);
                            lightmapTag.MemoryAddress = sbspHeader.StructureLightmapOffset;
                            lightmapTag.BaseAddress = sbspHeader.StructureBspOffset - (structureBspOffset + StructureBspBlockHeader.Length);
                        }
                    }
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public HaloTag GetTagById(TagId id)
        {
            if (tagDictionary.ContainsKey(id.Dword))
                return tagDictionary[id.Dword];
            return null;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string GetStringById(StringId id)
        {
            if (id.Index < strings.Length)
                return strings[id.Index];
            return null;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<HaloTag> GetTagsEnumerator()
        {
            return tagDictionary.Values;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Dictionary<long, byte[]> GetResourcesForTag(TagId id)
        {
            return GetResourcesForTag(GetTagById(id));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tag"></param>
        /// <returns></returns>
        public Dictionary<long, byte[]> GetResourcesForTag(HaloTag tag)
        {
            Dictionary<long, byte[]> resources = new Dictionary<long, byte[]>();
            uint rawOffset; int rawSize;
            long translator;

            if (tag == null) return resources;

            using (BinaryReader reader = OpenRead())
            {
                switch (tag.GroupTag)
                {
                    case "ugh!":
                        translator = tag.BaseAddress;
                        reader.BaseStream.Seek(tag.FileAddress + 64, SeekOrigin.Begin);
                        TagBlock sounds = reader.ReadTagBlock();
                        for (int i = 0; i < sounds.Count; i++)
                        {
                            reader.BaseStream.Seek(sounds.Offset + (i * 12), translator, SeekOrigin.Begin);
                            rawOffset = reader.ReadUInt32();
                            rawSize = reader.ReadInt32() & 0x7FFFFFFF;

                            if (CheckRawOffset(rawOffset))
                            {
                                reader.BaseStream.Seek(rawOffset, SeekOrigin.Begin);
                                if (!resources.ContainsKey(rawOffset))
                                    resources.Add(rawOffset, reader.ReadBytes(rawSize));
                            }
                        }

                        reader.BaseStream.Seek(tag.FileAddress + 80, SeekOrigin.Begin);
                        TagBlock extraInfos = reader.ReadTagBlock();
                        for (int i = 0; i < extraInfos.Count; i++)
                        {
                            reader.BaseStream.Seek(extraInfos.Offset + (i * 44) + 8, translator, SeekOrigin.Begin);
                            rawOffset = reader.ReadUInt32();
                            rawSize = reader.ReadInt32();

                            if (CheckRawOffset(rawOffset))
                            {
                                reader.BaseStream.Seek(rawOffset, SeekOrigin.Begin);
                                if (!resources.ContainsKey(rawOffset))
                                    resources.Add(rawOffset, reader.ReadBytes(rawSize));
                            }
                        }
                        break;

                    case "mode":
                        translator = tag.BaseAddress;
                        reader.BaseStream.Seek(tag.FileAddress + 36, SeekOrigin.Begin);
                        TagBlock sections = reader.ReadTagBlock();
                        for (int i = 0; i < sections.Count; i++)
                        {
                            reader.BaseStream.Seek(sections.Offset + (i * 92) + 56, translator, SeekOrigin.Begin);
                            rawOffset = reader.ReadUInt32();
                            rawSize = reader.ReadInt32();

                            if (CheckRawOffset(rawOffset))
                            {
                                reader.BaseStream.Seek(rawOffset, SeekOrigin.Begin);
                                if (!resources.ContainsKey(rawOffset))
                                    resources.Add(rawOffset, reader.ReadBytes(rawSize));
                            }
                        }

                        reader.BaseStream.Seek(tag.FileAddress + 116, SeekOrigin.Begin);
                        TagBlock prtInfos = reader.ReadTagBlock();
                        for (int i = 0; i < prtInfos.Count; i++)
                        {
                            reader.BaseStream.Seek(prtInfos.Offset + (i * 88) + 52, translator, SeekOrigin.Begin);
                            rawOffset = reader.ReadUInt32();
                            rawSize = reader.ReadInt32();

                            if (CheckRawOffset(rawOffset))
                            {
                                reader.BaseStream.Seek(rawOffset, SeekOrigin.Begin);
                                if (!resources.ContainsKey(rawOffset))
                                    resources.Add(rawOffset, reader.ReadBytes(rawSize));
                            }
                        }
                        break;

                    case "sbsp":
                        translator = tag.BaseAddress;
                        reader.BaseStream.Seek(tag.FileAddress + 156, SeekOrigin.Begin);
                        TagBlock clusters = reader.ReadTagBlock();
                        for (int i = 0; i < clusters.Count; i++)
                        {
                            reader.BaseStream.Seek(clusters.Offset + (i * 176) + 40, translator, SeekOrigin.Begin);
                            rawOffset = reader.ReadUInt32();
                            rawSize = reader.ReadInt32();

                            if (CheckRawOffset(rawOffset))
                            {
                                reader.BaseStream.Seek(rawOffset, SeekOrigin.Begin);
                                if (!resources.ContainsKey(rawOffset))
                                    resources.Add(rawOffset, reader.ReadBytes(rawSize));
                            }
                        }

                        reader.BaseStream.Seek(tag.FileAddress + 312, SeekOrigin.Begin);
                        TagBlock geometryDefinitions = reader.ReadTagBlock();
                        for (int i = 0; i < geometryDefinitions.Count; i++)
                        {
                            reader.BaseStream.Seek(geometryDefinitions.Offset + (i * 200) + 40, translator, SeekOrigin.Begin);
                            rawOffset = reader.ReadUInt32();
                            rawSize = reader.ReadInt32();

                            if (CheckRawOffset(rawOffset))
                            {
                                reader.BaseStream.Seek(rawOffset, SeekOrigin.Begin);
                                if (!resources.ContainsKey(rawOffset))
                                    resources.Add(rawOffset, reader.ReadBytes(rawSize));
                            }
                        }

                        reader.BaseStream.Seek(tag.FileAddress + 532, SeekOrigin.Begin);
                        TagBlock waterDefinitions = reader.ReadTagBlock();
                        for (int i = 0; i < waterDefinitions.Count; i++)
                        {
                            reader.BaseStream.Seek(waterDefinitions.Offset + (i * 172) + 16, translator, SeekOrigin.Begin);
                            rawOffset = reader.ReadUInt32();
                            rawSize = reader.ReadInt32();

                            if (CheckRawOffset(rawOffset))
                            {
                                reader.BaseStream.Seek(rawOffset, SeekOrigin.Begin);
                                if (!resources.ContainsKey(rawOffset))
                                    resources.Add(rawOffset, reader.ReadBytes(rawSize));
                            }
                        }

                        reader.BaseStream.Seek(tag.FileAddress + 564, SeekOrigin.Begin);
                        TagBlock decorators = reader.ReadTagBlock();
                        for (int i = 0; i < decorators.Count; i++)
                        {
                            reader.BaseStream.Seek(decorators.Offset + (i * 48) + 16, translator, SeekOrigin.Begin);
                            TagBlock caches = reader.ReadTagBlock();
                            for (int j = 0; j < caches.Offset; j++)
                            {
                                reader.BaseStream.Seek(caches.Offset + (j * 44), translator, SeekOrigin.Begin);
                                rawOffset = reader.ReadUInt32();
                                rawSize = reader.ReadInt32();

                                if (CheckRawOffset(rawOffset))
                                {
                                    reader.BaseStream.Seek(rawOffset, SeekOrigin.Begin);
                                    if (!resources.ContainsKey(rawOffset))
                                        resources.Add(rawOffset, reader.ReadBytes(rawSize));
                                }
                            }
                        }
                        break;

                    case "ltmp":
                        translator = tag.BaseAddress;
                        reader.BaseStream.Seek(tag.FileAddress + 128, SeekOrigin.Begin);
                        TagBlock groups = reader.ReadTagBlock();
                        for (int i = 0; i < groups.Count; i++)
                        {
                            reader.BaseStream.Seek(groups.Offset + (i * 104) + 32, translator, SeekOrigin.Begin);
                            clusters = reader.ReadTagBlock();
                            for (int j = 0; j < clusters.Count; j++)
                            {
                                reader.BaseStream.Seek(clusters.Offset + (j * 84) + 40, translator, SeekOrigin.Begin);
                                rawOffset = reader.ReadUInt32();
                                rawSize = reader.ReadInt32();

                                if (CheckRawOffset(rawOffset))
                                {
                                    reader.BaseStream.Seek(rawOffset, SeekOrigin.Begin);
                                    if (!resources.ContainsKey(rawOffset))
                                        resources.Add(rawOffset, reader.ReadBytes(rawSize));
                                }
                            }

                            reader.BaseStream.Seek(groups.Offset + (i * 104) + 48, translator, SeekOrigin.Begin);
                            TagBlock poops = reader.ReadTagBlock();
                            for (int j = 0; j < poops.Count; j++)
                            {
                                reader.BaseStream.Seek(poops.Offset + (j * 84) + 40, translator, SeekOrigin.Begin);
                                rawOffset = reader.ReadUInt32();
                                rawSize = reader.ReadInt32();

                                if (CheckRawOffset(rawOffset))
                                {
                                    reader.BaseStream.Seek(rawOffset, SeekOrigin.Begin);
                                    if (!resources.ContainsKey(rawOffset))
                                        resources.Add(rawOffset, reader.ReadBytes(rawSize));
                                }
                            }

                            reader.BaseStream.Seek(groups.Offset + (i * 104) + 64, translator, SeekOrigin.Begin);
                            TagBlock buckets = reader.ReadTagBlock();
                            for (int j = 0; j < buckets.Count; j++)
                            {
                                reader.BaseStream.Seek(buckets.Offset + (j * 56) + 12, translator, SeekOrigin.Begin);
                                rawOffset = reader.ReadUInt32();
                                rawSize = reader.ReadInt32();

                                if (CheckRawOffset(rawOffset))
                                {
                                    reader.BaseStream.Seek(rawOffset, SeekOrigin.Begin);
                                    if (!resources.ContainsKey(rawOffset))
                                        resources.Add(rawOffset, reader.ReadBytes(rawSize));
                                }
                            }
                        }
                        break;

                    case "weat":
                        translator = tag.BaseAddress;
                        reader.BaseStream.Seek(tag.FileAddress, SeekOrigin.Begin);
                        TagBlock particleSystems = reader.ReadTagBlock();
                        for (int i = 0; i < particleSystems.Count; i++)
                        {
                            reader.BaseStream.Seek(particleSystems.Offset + (i * 140) + 64, translator, SeekOrigin.Begin);
                            rawOffset = reader.ReadUInt32();
                            rawSize = reader.ReadInt32();

                            if (CheckRawOffset(rawOffset))
                            {
                                reader.BaseStream.Seek(rawOffset, SeekOrigin.Begin);
                                if (!resources.ContainsKey(rawOffset))
                                    resources.Add(rawOffset, reader.ReadBytes(rawSize));
                            }
                        }
                        break;

                    case "DECR":
                        reader.BaseStream.Seek(tag.FileAddress + 56, SeekOrigin.Begin);
                        rawOffset = reader.ReadUInt32();
                        rawSize = reader.ReadInt32();

                        if (CheckRawOffset(rawOffset))
                        {
                            reader.BaseStream.Seek(rawOffset, SeekOrigin.Begin);
                            if (!resources.ContainsKey(rawOffset))
                                resources.Add(rawOffset, reader.ReadBytes(rawSize));
                        }
                        break;

                    case "PRTM":
                        reader.BaseStream.Seek(tag.FileAddress + 160, SeekOrigin.Begin);
                        rawOffset = reader.ReadUInt32();
                        rawSize = reader.ReadInt32();

                        if (CheckRawOffset(rawOffset))
                        {
                            reader.BaseStream.Seek(rawOffset, SeekOrigin.Begin);
                            if (!resources.ContainsKey(rawOffset))
                                resources.Add(rawOffset, reader.ReadBytes(rawSize));
                        }
                        break;

                    case "jmad":
                        translator = tag.BaseAddress;
                        reader.BaseStream.Seek(tag.FileAddress, SeekOrigin.Begin);
                        TagBlock animations = reader.ReadTagBlock();
                        for (int i = 0; i < animations.Count; i++)
                        {
                            reader.BaseStream.Seek(animations.Offset + (i * 20) + 4, translator, SeekOrigin.Begin);
                            rawSize = reader.ReadInt32();
                            rawOffset = reader.ReadUInt32();

                            if (CheckRawOffset(rawOffset))
                            {
                                reader.BaseStream.Seek(rawOffset, SeekOrigin.Begin);
                                if (!resources.ContainsKey(rawOffset))
                                    resources.Add(rawOffset, reader.ReadBytes(rawSize));
                            }
                        }
                        break;

                    case "bitm":
                        translator = tag.BaseAddress;
                        reader.BaseStream.Seek(tag.FileAddress + 68, SeekOrigin.Begin);
                        TagBlock bitmapData = reader.ReadTagBlock();
                        for (int i = 0; i < bitmapData.Count; i++)
                        {
                            reader.BaseStream.Seek(bitmapData.Offset + (i * 116) + 28, translator, SeekOrigin.Begin);
                            uint lod1Offset = reader.ReadUInt32();
                            uint lod2Offset = reader.ReadUInt32();
                            uint lod3Offset = reader.ReadUInt32();
                            uint lod4Offset = reader.ReadUInt32();
                            uint lod5Offset = reader.ReadUInt32();
                            uint lod6Offset = reader.ReadUInt32();
                            int lod1Size = reader.ReadInt32();
                            int lod2Size = reader.ReadInt32();
                            int lod3Size = reader.ReadInt32();
                            int lod4Size = reader.ReadInt32();
                            int lod5Size = reader.ReadInt32();
                            int lod6Size = reader.ReadInt32();

                            rawOffset = lod1Offset; rawSize = lod1Size;
                            if (CheckRawOffset(rawOffset))
                            {
                                reader.BaseStream.Seek(rawOffset, SeekOrigin.Begin);
                                if (!resources.ContainsKey(rawOffset))
                                    resources.Add(rawOffset, reader.ReadBytes(rawSize));
                            }

                            rawOffset = lod2Offset; rawSize = lod2Size;
                            if (CheckRawOffset(rawOffset))
                            {
                                reader.BaseStream.Seek(rawOffset, SeekOrigin.Begin);
                                if (!resources.ContainsKey(rawOffset))
                                    resources.Add(rawOffset, reader.ReadBytes(rawSize));
                            }

                            rawOffset = lod3Offset; rawSize = lod3Size;
                            if (CheckRawOffset(rawOffset))
                            {
                                reader.BaseStream.Seek(rawOffset, SeekOrigin.Begin);
                                if (!resources.ContainsKey(rawOffset))
                                    resources.Add(rawOffset, reader.ReadBytes(rawSize));
                            }

                            rawOffset = lod4Offset; rawSize = lod4Size;
                            if (CheckRawOffset(rawOffset))
                            {
                                reader.BaseStream.Seek(rawOffset, SeekOrigin.Begin);
                                if (!resources.ContainsKey(rawOffset))
                                    resources.Add(rawOffset, reader.ReadBytes(rawSize));
                            }

                            rawOffset = lod5Offset; rawSize = lod5Size;
                            if (CheckRawOffset(rawOffset))
                            {
                                reader.BaseStream.Seek(rawOffset, SeekOrigin.Begin);
                                if (!resources.ContainsKey(rawOffset))
                                    resources.Add(rawOffset, reader.ReadBytes(rawSize));
                            }

                            rawOffset = lod6Offset; rawSize = lod6Size;
                            if (CheckRawOffset(rawOffset))
                            {
                                reader.BaseStream.Seek(rawOffset, SeekOrigin.Begin);
                                if (!resources.ContainsKey(rawOffset))
                                    resources.Add(rawOffset, reader.ReadBytes(rawSize));
                            }
                        }
                        break;
                }
            }

            return resources;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public StringContainer GetStringsForTag(TagId id)
        {
            return GetStringsForTag(GetTagById(id));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tag"></param>
        /// <returns></returns>
        public StringContainer GetStringsForTag(HaloTag tag)
        {
            throw new NotImplementedException();
        }

        private bool CheckRawOffset(long offset)
        {
            return (offset & 0xC0000000) == 0 && offset >= 0 && offset < header.FileLength;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static HaloMapFile Load(string fileName)
        {
            HaloMapFile map = new HaloMapFile() { FileName = fileName };
            map.Load();

            return map;
        }
    }

    /// <summary>
    /// Represents a virtual tag data container.
    /// </summary>
    public sealed class TagData : IDisposable
    {
        /// <summary>
        /// Gets and returns the tag.
        /// </summary>
        public HaloTag Tag { get; }
        /// <summary>
        /// Gets and returns the memory address for the start of the tag data.
        /// </summary>
        public long MemoryAddress { get; internal set; }
        /// <summary>
        /// Gets and returns a vitual memory stream containing the tag data.
        /// </summary>
        public VirtualStream Stream { get; internal set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TagData"/> class using the specified Halo tag.
        /// </summary>
        /// <param name="tag"></param>
        public TagData(HaloTag tag)
        {
            Tag = tag;
        }
        /// <summary>
        /// Releases all resources used by this instance.
        /// </summary>
        public void Dispose()
        {
            Stream.Dispose();
        }
    }

    /// <summary>
    /// Represents a Halo 2 map tag.
    /// </summary>
    public sealed class HaloTag
    {
        private ObjectEntry objectEntry = new ObjectEntry();

        /// <summary>
        /// Gets and returns the map that this tag belongs to.
        /// </summary>
        public HaloMapFile Map { get; }
        /// <summary>
        /// Gets and returns the base address of the tag data.
        /// </summary>
        public uint BaseAddress { get; internal set; }
        /// <summary>
        /// Gets and returns the tag name.
        /// </summary>
        public string TagName { get; internal set; } = string.Empty;
        /// <summary>
        /// Gets and returns the tag ID.
        /// </summary>
        public TagId Id
        {
            get => objectEntry.Id;
        }
        /// <summary>
        /// Gets and returns the group tag.
        /// </summary>
        public TagFourCc GroupTag
        {
            get => objectEntry.Root;
        }
        /// <summary>
        /// Gets and returns the length of the tag data.
        /// </summary>
        public int Length
        {
            get => (int)objectEntry.Size;
            internal set => objectEntry.Size = (uint)value;
        }
        /// <summary>
        /// Gets and returns the length of the tag data as a signed 64-bit integer.
        /// </summary>
        public long LongLength
        {
            get => objectEntry.Size;
        }
        /// <summary>
        /// Gets and returns the address of the tag.
        /// </summary>
        public long FileAddress
        {
            get => objectEntry.TagDataOffset - BaseAddress;
        }
        /// <summary>
        /// Gets and returns the memory address of the file name of the tag.
        /// </summary>
        public long FileNameMemoryAddress
        {
            get => objectEntry.FileNameOffset;
            internal set => objectEntry.FileNameOffset = (uint)value;
        }
        /// <summary>
        /// Gets and returns the memory address of the tag.
        /// </summary>
        public long MemoryAddress
        {
            get => objectEntry.TagDataOffset;
            internal set => objectEntry.TagDataOffset = (uint)value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (!string.IsNullOrEmpty(TagName))
                return $"{TagName}.{GroupTag} {Id} Offset: {FileAddress} Size: {Length}";
            else return $"{Id} Offset: {FileAddress} Size: {Length}";
        }
        internal HaloTag(HaloMapFile owner, BinaryReader reader)
        {
            Map = owner;
            objectEntry = reader.Read<ObjectEntry>();
        }
    }
}
