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
    
    [Abide.Guerilla.Tags.FieldSetAttribute(76, 4)]
    public class LiquidCoreBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(12)]
        public Byte[] EmptyString;
        [Abide.Guerilla.Tags.FieldAttribute("bitmap index", typeof(Int16))]
        public Int16 BitmapIndex;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(2)]
        public Byte[] EmptyString1;
        [Abide.Guerilla.Tags.FieldAttribute("thickness", typeof(ScalarFunctionStructBlock))]
        public ScalarFunctionStructBlock Thickness1;
        [Abide.Guerilla.Tags.FieldAttribute("color", typeof(ColorFunctionStructBlock))]
        public ColorFunctionStructBlock Color1;
        [Abide.Guerilla.Tags.FieldAttribute("brightness-time", typeof(ScalarFunctionStructBlock))]
        public ScalarFunctionStructBlock Brightnesstime1;
        [Abide.Guerilla.Tags.FieldAttribute("brightness-facing", typeof(ScalarFunctionStructBlock))]
        public ScalarFunctionStructBlock Brightnessfacing1;
        [Abide.Guerilla.Tags.FieldAttribute("along-axis scale", typeof(ScalarFunctionStructBlock))]
        public ScalarFunctionStructBlock AlongaxisScale1;
    }
}
#pragma warning restore CS1591