﻿using Abide.Guerilla.Library;
using Abide.HaloLibrary;
using Abide.HaloLibrary.Halo2.Retail;
using Abide.HaloLibrary.IO;
using Abide.Tag;
using Abide.Tag.Cache.Generated;
using Abide.Wpf.Modules.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Convert = Abide.Guerilla.Library.Convert;

namespace Abide.Wpf.Modules.Operations
{
    public sealed class HaloMapDecompileOperation : BackgroundOperation
    {
        private readonly string mapPath = string.Empty;
        private readonly string tagsDirectory = string.Empty;
        private HaloMap map = null;

        public HaloMapDecompileOperation(string path)
        {
            mapPath = path;
            tagsDirectory = Path.Combine(RegistrySettings.WorkspaceDirectory, "tags");
        }
        protected override void OnBackground(object state)
        {
            ReportStatus($"Loading {mapPath}...");
            map = new HaloMap(mapPath);
            ReportStatus($"Decompiling {map.Name}...");
            Group globalsGroup;
            Group soundGestaltGroup = null;
            IndexEntry soundGestalt = null;
            IndexEntry globals = map.Globals;

            try
            {
                using (var tagReader = globals.Data.GetVirtualStream().CreateReader())
                {
                    tagReader.BaseStream.Seek(globals.Address, SeekOrigin.Begin);
                    globalsGroup = TagLookup.CreateTagGroup(globals.Root);
                    globalsGroup.Read(tagReader);

                    BlockField soundGlobalsTagBlock = (BlockField)globalsGroup.TagBlocks[0].Fields[4];
                    if (soundGlobalsTagBlock.BlockList.Count > 0)
                    {
                        TagId soundGestaltId = (TagId)soundGlobalsTagBlock.BlockList[0].Fields[4].Value;
                        soundGestalt = map.IndexEntries[soundGestaltId];
                        soundGlobalsTagBlock.BlockList[0].Fields[4].Value = (int)TagId.Null;
                    }
                }

                if (soundGestalt != null)
                {
                    using (BinaryReader reader = soundGestalt.Data.GetVirtualStream().CreateReader())
                    {
                        soundGestaltGroup = TagLookup.CreateTagGroup(soundGestalt.Root);
                        reader.BaseStream.Seek(soundGestalt.Address, SeekOrigin.Begin);
                        soundGestaltGroup.Read(reader);
                    }
                }

                int num = 0;
                SetProgressVisibility(true);
                ResetProgress(map.IndexEntries.Count);
                var result = Parallel.ForEach(map.IndexEntries, entry =>
                {
                    num++;
                    Group guerillaTagGroup;
                    var tagGroup = TagLookup.CreateTagGroup(entry.Root);
                    var reader = entry.Data.GetVirtualStream().CreateReader();
                    reader.BaseStream.Seek(entry.Address, SeekOrigin.Begin);
                    try { tagGroup.Read(reader); }
                    finally { guerillaTagGroup = Convert.ToGuerilla(tagGroup, soundGestaltGroup, entry, map); }

                    string localFileName = Path.Combine($"{entry.Filename}.{guerillaTagGroup.Name}");
                    string tagGroupFileName = Path.Combine(tagsDirectory, localFileName);

                    if (!Directory.Exists(Path.GetDirectoryName(tagGroupFileName)))
                    {
                        Directory.CreateDirectory(Path.GetDirectoryName(tagGroupFileName));
                    }

                    TagGroupHeader header = new TagGroupHeader();
                    using (FileStream fs = new FileStream(tagGroupFileName, FileMode.Create, FileAccess.ReadWrite, FileShare.Read))
                    using (BinaryReader fileReader = new BinaryReader(fs))
                    using (BinaryWriter fileWriter = new BinaryWriter(fs))
                    {
                        fs.Seek(TagGroupHeader.Size, SeekOrigin.Begin);
                        guerillaTagGroup.Write(fileWriter);

                        switch (guerillaTagGroup.Tag)
                        {
                            case "snd!":
                                SoundTagGroup_CreateRaws(guerillaTagGroup, soundGestalt, fileWriter, ref header);
                                break;
                            case "mode":
                                RenderModelTagGroup_CreateRaws(guerillaTagGroup, entry, fileWriter, ref header);
                                break;
                            case "sbsp":
                                ScenarioStructureBspTagGroup_CreateRaws(guerillaTagGroup, entry, fileWriter, ref header);
                                break;
                            case "ltmp":
                                ScenarioStructureLightmapTagGroup_CreateRaws(guerillaTagGroup, entry, fileWriter, ref header);
                                break;
                            case "weat":
                                WeatherSystemTagGroup_CreateRaws(guerillaTagGroup, entry, fileWriter, ref header);
                                break;
                            case "DECR":
                                DecoratorSetTagGroup_CreateRaws(guerillaTagGroup, entry, fileWriter, ref header);
                                break;
                            case "PRTM":
                                ParticleModelTagGroup_CreateRaws(guerillaTagGroup, entry, fileWriter, ref header);
                                break;
                            case "jmad":
                                AnimationTagGroup_CreateRaws(guerillaTagGroup, entry, fileWriter, ref header);
                                break;
                            case "bitm":
                                BitmapTagGroup_CreateRaws(guerillaTagGroup, entry, fileWriter, ref header);
                                break;
                        }

                        header.Checksum = (uint)TagGroup_CalculateChecksum(guerillaTagGroup);
                        header.GroupTag = guerillaTagGroup.Tag.FourCc;
                        header.Id = entry.Id.Dword;
                        header.AbideTag = "atag";

                        fs.Seek(0, SeekOrigin.Begin);
                        fileWriter.Write(header);
                        ReportProgress(num);
                    }
                });
            }
            catch
            {
#if DEBUG
                throw;
#endif
            }
            finally
            {
                GC.Collect();
            }

            ReportProgress(map.IndexEntries.Count);
            Thread.Sleep(2000);
            SetProgressVisibility(false);
        }
        protected override void OnCancel()
        {
            throw new NotImplementedException();
        }
        protected override object OnStart()
        {
            ReportStatus("Starting decompile operation...");
            SetProgressVisibility(true);
            return null;
        }

        private void SoundTagGroup_CreateRaws(ITagGroup tagGroup, IndexEntry entry, BinaryWriter writer, ref TagGroupHeader header)
        {
            List<long> addresses = new List<long>();
            List<byte[]> buffers = new List<byte[]>();

            foreach (ITagBlock pitchRange in ((BlockField)tagGroup[0][13]).BlockList)
            {
                foreach (ITagBlock permutation in ((BlockField)pitchRange[7]).BlockList)
                {
                    foreach (ITagBlock chunk in ((BlockField)permutation[6]).BlockList)
                    {
                        int address = (int)chunk[0].Value;

                        if (entry.Resources.TryGetResource(address, out var resource))
                        {
                            header.TagResourceCount++;
                            addresses.Add(address);
                            buffers.Add(resource.GetBuffer());
                        }
                        else if ((address & 0xC0000000) == 0)
                        {
                            System.Diagnostics.Debugger.Break();
                        }
                    }
                }
            }

            foreach (ITagBlock extraInfo in ((BlockField)tagGroup[0][15]).BlockList)
            {
                ITagBlock geometry = (ITagBlock)extraInfo[2].Value;
                int address = (int)geometry[1].Value;

                if (entry.Resources.TryGetResource(address, out var resource))
                {
                    header.TagResourceCount++;
                    addresses.Add(address);
                    buffers.Add(resource.GetBuffer());
                }
            }

            if (header.TagResourceCount > 0)
            {
                header.RawOffsetsOffset = (uint)writer.BaseStream.Position;
                for (int i = 0; i < header.TagResourceCount; i++)
                {
                    writer.Write((int)addresses[i]);
                }

                header.RawLengthsOffset = (uint)writer.BaseStream.Position;
                for (int i = 0; i < header.TagResourceCount; i++)
                {
                    writer.Write(buffers[i].Length);
                }

                header.RawDataOffset = (uint)writer.BaseStream.Position;
                for (int i = 0; i < header.TagResourceCount; i++)
                {
                    writer.Write(buffers[i]);
                }
            }
        }
        private void RenderModelTagGroup_CreateRaws(ITagGroup guerillaTagGroup, IndexEntry entry, BinaryWriter writer, ref TagGroupHeader header)
        {
            List<long> addresses = new List<long>();
            List<byte[]> buffers = new List<byte[]>();

            foreach (ITagBlock section in ((BlockField)guerillaTagGroup[0][7]).BlockList)
            {
                ITagBlock geometry = (ITagBlock)section[6].Value;
                int address = (int)geometry[1].Value;

                if (entry.Resources.TryGetResource(address, out var resource))
                {
                    header.TagResourceCount++;
                    addresses.Add(address);
                    buffers.Add(resource.GetBuffer());
                }
            }

            foreach (ITagBlock prtInfo in ((BlockField)guerillaTagGroup[0][24]).BlockList)
            {
                ITagBlock geometry = (ITagBlock)prtInfo[13].Value;
                int address = (int)geometry[1].Value;

                if (entry.Resources.TryGetResource(address, out var resource))
                {
                    header.TagResourceCount++;
                    addresses.Add(address);
                    buffers.Add(resource.GetBuffer());
                }
            }

            if (header.TagResourceCount > 0)
            {
                header.RawOffsetsOffset = (uint)writer.BaseStream.Position;
                for (int i = 0; i < header.TagResourceCount; i++)
                {
                    writer.Write((int)addresses[i]);
                }

                header.RawLengthsOffset = (uint)writer.BaseStream.Position;
                for (int i = 0; i < header.TagResourceCount; i++)
                {
                    writer.Write(buffers[i].Length);
                }

                header.RawDataOffset = (uint)writer.BaseStream.Position;
                for (int i = 0; i < header.TagResourceCount; i++)
                {
                    writer.Write(buffers[i]);
                }
            }
        }
        private void ScenarioStructureBspTagGroup_CreateRaws(ITagGroup guerillaTagGroup, IndexEntry entry, BinaryWriter writer, ref TagGroupHeader header)
        {
            List<long> addresses = new List<long>();
            List<byte[]> buffers = new List<byte[]>();

            foreach (ITagBlock structureBspCluster in ((BlockField)guerillaTagGroup[0][19]).BlockList)
            {
                ITagBlock geometry = (ITagBlock)structureBspCluster[1].Value;
                int address = (int)geometry[1].Value;

                if (entry.Resources.TryGetResource(address, out var resource))
                {
                    header.TagResourceCount++;
                    addresses.Add(address);
                    buffers.Add(resource.GetBuffer());
                }
            }

            foreach (ITagBlock structureBspInstancedGeometryDefinition in ((BlockField)guerillaTagGroup[0][39]).BlockList)
            {
                ITagBlock renderInfo = (ITagBlock)structureBspInstancedGeometryDefinition[0].Value;
                ITagBlock geometry = (ITagBlock)renderInfo[1].Value;
                int address = (int)geometry[1].Value;

                if (entry.Resources.TryGetResource(address, out var resource))
                {
                    header.TagResourceCount++;
                    addresses.Add(address);
                    buffers.Add(resource.GetBuffer());
                }
            }

            foreach (ITagBlock structureBspWaterDefinition in ((BlockField)guerillaTagGroup[0][50]).BlockList)
            {
                ITagBlock geometry = (ITagBlock)structureBspWaterDefinition[2].Value;
                int address = (int)geometry[1].Value;

                if (entry.Resources.TryGetResource(address, out var resource))
                {
                    header.TagResourceCount++;
                    addresses.Add(address);
                    buffers.Add(resource.GetBuffer());
                }
            }

            foreach (ITagBlock decoratorPlacementDefinition in ((BlockField)guerillaTagGroup[0][54]).BlockList)
            {
                foreach (ITagBlock decoratorCacheBlock in ((BlockField)decoratorPlacementDefinition[2]).BlockList)
                {
                    ITagBlock geometry = (ITagBlock)decoratorCacheBlock[0].Value;
                    int address = (int)geometry[1].Value;

                    if (entry.Resources.TryGetResource(address, out var resource))
                    {
                        header.TagResourceCount++;
                        addresses.Add(address);
                        buffers.Add(resource.GetBuffer());
                    }
                }
            }

            if (header.TagResourceCount > 0)
            {
                header.RawOffsetsOffset = (uint)writer.BaseStream.Position;
                for (int i = 0; i < header.TagResourceCount; i++)
                {
                    writer.Write((int)addresses[i]);
                }

                header.RawLengthsOffset = (uint)writer.BaseStream.Position;
                for (int i = 0; i < header.TagResourceCount; i++)
                {
                    writer.Write(buffers[i].Length);
                }

                header.RawDataOffset = (uint)writer.BaseStream.Position;
                for (int i = 0; i < header.TagResourceCount; i++)
                {
                    writer.Write(buffers[i]);
                }
            }
        }
        private void ScenarioStructureLightmapTagGroup_CreateRaws(ITagGroup guerillaTagGroup, IndexEntry entry, BinaryWriter writer, ref TagGroupHeader header)
        {
            List<long> addresses = new List<long>();
            List<byte[]> buffers = new List<byte[]>();

            foreach (ITagBlock structureLightmapGroup in ((BlockField)guerillaTagGroup[0][16]).BlockList)
            {
                foreach (ITagBlock cluster in ((BlockField)structureLightmapGroup[6]).BlockList)
                {
                    ITagBlock geometry = (ITagBlock)cluster[1].Value;
                    int address = (int)geometry[1].Value;

                    if (entry.Resources.TryGetResource(address, out var resource))
                    {
                        header.TagResourceCount++;
                        addresses.Add(address);
                        buffers.Add(resource.GetBuffer());
                    }
                }

                foreach (ITagBlock lightmapGeometrySectionBlock in ((BlockField)structureLightmapGroup[8]).BlockList)
                {
                    ITagBlock geometry = (ITagBlock)lightmapGeometrySectionBlock[1].Value;
                    int address = (int)geometry[1].Value;

                    if (entry.Resources.TryGetResource(address, out var resource))
                    {
                        header.TagResourceCount++;
                        addresses.Add(address);
                        buffers.Add(resource.GetBuffer());
                    }
                }

                foreach (ITagBlock lightmapVertexBufferBucket in ((BlockField)structureLightmapGroup[10]).BlockList)
                {
                    ITagBlock geometry = (ITagBlock)lightmapVertexBufferBucket[3].Value;
                    int address = (int)geometry[1].Value;

                    if (entry.Resources.TryGetResource(address, out var resource))
                    {
                        header.TagResourceCount++;
                        addresses.Add(address);
                        buffers.Add(resource.GetBuffer());
                    }
                }
            }

            if (header.TagResourceCount > 0)
            {
                header.RawOffsetsOffset = (uint)writer.BaseStream.Position;
                for (int i = 0; i < header.TagResourceCount; i++)
                {
                    writer.Write((int)addresses[i]);
                }

                header.RawLengthsOffset = (uint)writer.BaseStream.Position;
                for (int i = 0; i < header.TagResourceCount; i++)
                {
                    writer.Write(buffers[i].Length);
                }

                header.RawDataOffset = (uint)writer.BaseStream.Position;
                for (int i = 0; i < header.TagResourceCount; i++)
                {
                    writer.Write(buffers[i]);
                }
            }
        }
        private void WeatherSystemTagGroup_CreateRaws(ITagGroup guerillaTagGroup, IndexEntry entry, BinaryWriter writer, ref TagGroupHeader header)
        {
            List<long> addresses = new List<long>();
            List<byte[]> buffers = new List<byte[]>();

            foreach (ITagBlock lightmapGeometrySectionBlock in ((BlockField)guerillaTagGroup[0][0]).BlockList)
            {
                ITagBlock geometry = (ITagBlock)lightmapGeometrySectionBlock[13].Value;
                int address = (int)geometry[1].Value;

                if (entry.Resources.TryGetResource(address, out var resource))
                {
                    header.TagResourceCount++;
                    addresses.Add(address);
                    buffers.Add(resource.GetBuffer());
                }
            }

            if (header.TagResourceCount > 0)
            {
                header.RawOffsetsOffset = (uint)writer.BaseStream.Position;
                for (int i = 0; i < header.TagResourceCount; i++)
                {
                    writer.Write((int)addresses[i]);
                }

                header.RawLengthsOffset = (uint)writer.BaseStream.Position;
                for (int i = 0; i < header.TagResourceCount; i++)
                {
                    writer.Write(buffers[i].Length);
                }

                header.RawDataOffset = (uint)writer.BaseStream.Position;
                for (int i = 0; i < header.TagResourceCount; i++)
                {
                    writer.Write(buffers[i]);
                }
            }
        }
        private void DecoratorSetTagGroup_CreateRaws(ITagGroup guerillaTagGroup, IndexEntry entry, BinaryWriter writer, ref TagGroupHeader header)
        {
            List<long> addresses = new List<long>();
            List<byte[]> buffers = new List<byte[]>();

            ITagBlock geometry = (ITagBlock)guerillaTagGroup[0][8].Value;
            int address = (int)geometry[1].Value;

            if (entry.Resources.TryGetResource(address, out var resource))
            {
                header.TagResourceCount++;
                addresses.Add(address);
                buffers.Add(resource.GetBuffer());
            }

            if (header.TagResourceCount > 0)
            {
                header.RawOffsetsOffset = (uint)writer.BaseStream.Position;
                for (int i = 0; i < header.TagResourceCount; i++)
                {
                    writer.Write((int)addresses[i]);
                }

                header.RawLengthsOffset = (uint)writer.BaseStream.Position;
                for (int i = 0; i < header.TagResourceCount; i++)
                {
                    writer.Write(buffers[i].Length);
                }

                header.RawDataOffset = (uint)writer.BaseStream.Position;
                for (int i = 0; i < header.TagResourceCount; i++)
                {
                    writer.Write(buffers[i]);
                }
            }
        }
        private void ParticleModelTagGroup_CreateRaws(ITagGroup guerillaTagGroup, IndexEntry entry, BinaryWriter writer, ref TagGroupHeader header)
        {
            List<long> addresses = new List<long>();
            List<byte[]> buffers = new List<byte[]>();

            ITagBlock geometry = (ITagBlock)guerillaTagGroup[0][22].Value;
            int address = (int)geometry[1].Value;

            if (entry.Resources.TryGetResource(address, out var resource))
            {
                header.TagResourceCount++;
                addresses.Add(address);
                buffers.Add(resource.GetBuffer());
            }

            if (header.TagResourceCount > 0)
            {
                header.RawOffsetsOffset = (uint)writer.BaseStream.Position;
                for (int i = 0; i < header.TagResourceCount; i++)
                {
                    writer.Write((int)addresses[i]);
                }

                header.RawLengthsOffset = (uint)writer.BaseStream.Position;
                for (int i = 0; i < header.TagResourceCount; i++)
                {
                    writer.Write(buffers[i].Length);
                }

                header.RawDataOffset = (uint)writer.BaseStream.Position;
                for (int i = 0; i < header.TagResourceCount; i++)
                {
                    writer.Write(buffers[i]);
                }
            }
        }
        private void AnimationTagGroup_CreateRaws(ITagGroup guerillaTagGroup, IndexEntry entry, BinaryWriter writer, ref TagGroupHeader header)
        {
            List<long> addresses = new List<long>();
            List<byte[]> buffers = new List<byte[]>();

            foreach (ITagBlock animationData in ((BlockField)guerillaTagGroup[0][6]).BlockList)
            {
                int address = (int)animationData[2].Value;
                if (entry.Resources.TryGetResource(address, out var resource))
                {
                    header.TagResourceCount++;
                    addresses.Add(address);
                    buffers.Add(resource.GetBuffer());
                }
            }

            if (header.TagResourceCount > 0)
            {
                header.RawOffsetsOffset = (uint)writer.BaseStream.Position;
                for (int i = 0; i < header.TagResourceCount; i++)
                {
                    writer.Write((int)addresses[i]);
                }

                header.RawLengthsOffset = (uint)writer.BaseStream.Position;
                for (int i = 0; i < header.TagResourceCount; i++)
                {
                    writer.Write(buffers[i].Length);
                }

                header.RawDataOffset = (uint)writer.BaseStream.Position;
                for (int i = 0; i < header.TagResourceCount; i++)
                {
                    writer.Write(buffers[i]);
                }
            }
        }
        private void BitmapTagGroup_CreateRaws(ITagGroup guerillaTagGroup, IndexEntry entry, BinaryWriter writer, ref TagGroupHeader header)
        {
            List<long> addresses = new List<long>();
            List<byte[]> buffers = new List<byte[]>();

            foreach (ITagBlock bitmapData in ((BlockField)guerillaTagGroup[0][29]).BlockList)
            {
                using (MemoryStream ms = new MemoryStream((byte[])bitmapData[12].Value))
                using (BinaryReader reader = new BinaryReader(ms))
                {
                    for (int i = 0; i < 3; i++)
                    {
                        int address = reader.ReadInt32();
                        if (entry.Resources.TryGetResource(address, out var resource))
                        {
                            header.TagResourceCount++;
                            addresses.Add(address);
                            buffers.Add(resource.GetBuffer());
                        }
                    }
                }
            }

            if (header.TagResourceCount > 0)
            {
                header.RawOffsetsOffset = (uint)writer.BaseStream.Position;
                for (int i = 0; i < header.TagResourceCount; i++)
                {
                    writer.Write((int)addresses[i]);
                }

                header.RawLengthsOffset = (uint)writer.BaseStream.Position;
                for (int i = 0; i < header.TagResourceCount; i++)
                {
                    writer.Write(buffers[i].Length);
                }

                header.RawDataOffset = (uint)writer.BaseStream.Position;
                for (int i = 0; i < header.TagResourceCount; i++)
                {
                    writer.Write(buffers[i]);
                }
            }
        }
        private int TagGroup_CalculateChecksum(ITagGroup tagGroup)
        {
            int checksum = 0;

            using (VirtualStream tagStream = new VirtualStream(TagGroupHeader.Size))
            using (BinaryWriter writer = new BinaryWriter(tagStream))
            {
                tagGroup.Write(writer);
                _ = tagStream.Align(4);

                if (tagStream.Length == 0)
                {
                    return 0;
                }

                byte[] tagGroupBuffer = tagStream.ToArray();
                checksum = BitConverter.ToInt32(tagGroupBuffer, 0);
                for (int i = 1; i < tagGroupBuffer.Length / 4; i++)
                {
                    checksum ^= BitConverter.ToInt32(tagGroupBuffer, i * 4);
                }
            }

            return checksum;
        }
    }
}
