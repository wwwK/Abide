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

namespace Abide.Guerilla.Tags2
{
    using Abide.Guerilla.Types;
    using Abide.HaloLibrary;
    using System;
    
    [Abide.Guerilla.Tags.FieldSetAttribute(20, 4)]
    public class ModelRegionBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("name*^", typeof(StringId))]
        public StringId Name;
        [Abide.Guerilla.Tags.FieldAttribute("collision region index*", typeof(Byte))]
        public Byte CollisionRegionIndex;
        [Abide.Guerilla.Tags.FieldAttribute("physics region index*", typeof(Byte))]
        public Byte PhysicsRegionIndex;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(2)]
        public Byte[] EmptyString;
        [Abide.Guerilla.Tags.FieldAttribute("permutations*", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("Model Permutation Block", 32, typeof(ModelPermutationBlock))]
        public TagBlock Permutations;
    }
}
#pragma warning restore CS1591