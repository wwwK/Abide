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
    
    [Abide.Guerilla.Tags.FieldSetAttribute(92, 4)]
    public class BeamBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("shader", typeof(TagReference))]
        public TagReference Shader;
        [Abide.Guerilla.Tags.FieldAttribute("location", typeof(Int16))]
        public Int16 Location;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(2)]
        public Byte[] EmptyString;
        [Abide.Guerilla.Tags.FieldAttribute("color", typeof(ColorFunctionStructBlock))]
        public ColorFunctionStructBlock Color1;
        [Abide.Guerilla.Tags.FieldAttribute("alpha", typeof(ScalarFunctionStructBlock))]
        public ScalarFunctionStructBlock Alpha1;
        [Abide.Guerilla.Tags.FieldAttribute("width", typeof(ScalarFunctionStructBlock))]
        public ScalarFunctionStructBlock Width1;
        [Abide.Guerilla.Tags.FieldAttribute("length", typeof(ScalarFunctionStructBlock))]
        public ScalarFunctionStructBlock Length1;
        [Abide.Guerilla.Tags.FieldAttribute("yaw", typeof(ScalarFunctionStructBlock))]
        public ScalarFunctionStructBlock Yaw1;
        [Abide.Guerilla.Tags.FieldAttribute("pitch", typeof(ScalarFunctionStructBlock))]
        public ScalarFunctionStructBlock Pitch1;
    }
}
#pragma warning restore CS1591