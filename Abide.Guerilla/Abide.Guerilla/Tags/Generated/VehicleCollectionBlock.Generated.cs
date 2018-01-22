#pragma warning disable CS1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Abide.Guerilla.Tags
{
    using Abide.Guerilla.Types;
    using Abide.HaloLibrary;
    using System;
    using System.IO;
    
    [FieldSetAttribute(16, 4)]
    [TagGroupAttribute("vehicle_collection", 1986357347u, 4294967293u, typeof(VehicleCollectionBlock))]
    public sealed class VehicleCollectionBlock : AbideTagBlock
    {
        private TagBlockList<VehiclePermutation> vehiclePermutationsList = new TagBlockList<VehiclePermutation>(32);
        [FieldAttribute("vehicle permutations", typeof(TagBlock))]
        [BlockAttribute("vehicle_permutation", 32, typeof(VehiclePermutation))]
        public TagBlock VehiclePermutations;
        [FieldAttribute("spawn time (in seconds, 0 = default)", typeof(Int16))]
        public Int16 SpawnTimeInSeconds0EqualsDefault;
        [FieldAttribute("", typeof(Byte[]))]
        [PaddingAttribute(2)]
        public Byte[] EmptyString;
        public TagBlockList<VehiclePermutation> VehiclePermutationsList
        {
            get
            {
                return this.vehiclePermutationsList;
            }
        }
        public override int Size
        {
            get
            {
                return 16;
            }
        }
        public override void Initialize()
        {
            this.vehiclePermutationsList.Clear();
            this.VehiclePermutations = TagBlock.Zero;
            this.SpawnTimeInSeconds0EqualsDefault = 0;
            this.EmptyString = new byte[2];
        }
        public override void Read(BinaryReader reader)
        {
            this.VehiclePermutations = reader.ReadInt64();
            this.vehiclePermutationsList.Read(reader, this.VehiclePermutations);
            this.SpawnTimeInSeconds0EqualsDefault = reader.ReadInt16();
            this.EmptyString = reader.ReadBytes(2);
        }
        public override void Write(BinaryWriter writer)
        {
        }
        [FieldSetAttribute(24, 4)]
        public sealed class VehiclePermutation : AbideTagBlock
        {
            [FieldAttribute("weight#relatively how likely this vehicle will be chosen", typeof(Single))]
            public Single Weight;
            [FieldAttribute("vehicle^#which vehicle to ", typeof(TagReference))]
            public TagReference Vehicle;
            [FieldAttribute("variant name", typeof(StringId))]
            public StringId VariantName;
            public override int Size
            {
                get
                {
                    return 24;
                }
            }
            public override void Initialize()
            {
                this.Weight = 0;
                this.Vehicle = TagReference.Null;
                this.VariantName = StringId.Zero;
            }
            public override void Read(BinaryReader reader)
            {
                this.Weight = reader.ReadSingle();
                this.Vehicle = reader.Read<TagReference>();
                this.VariantName = reader.ReadInt32();
            }
            public override void Write(BinaryWriter writer)
            {
            }
        }
    }
}
#pragma warning restore CS1591