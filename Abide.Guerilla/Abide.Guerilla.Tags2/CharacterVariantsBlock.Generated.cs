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
    
    [Abide.Guerilla.Tags.FieldSetAttribute(12, 4)]
    public class CharacterVariantsBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("variant name^", typeof(StringId))]
        public StringId VariantName;
        [Abide.Guerilla.Tags.FieldAttribute("variant index*", typeof(Int16))]
        public Int16 VariantIndex;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(2)]
        public Byte[] EmptyString;
        [Abide.Guerilla.Tags.FieldAttribute("variant designator*", typeof(StringId))]
        public StringId VariantDesignator;
    }
}
#pragma warning restore CS1591