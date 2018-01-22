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
    
    [Abide.Guerilla.Tags.FieldSetAttribute(556, 4)]
    [Abide.Guerilla.Tags.TagGroupAttribute("cellular_automata2d", "whip", "����", typeof(CellularAutomata2dBlock))]
    public class CellularAutomata2dBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("updates per second:Hz", typeof(Int16))]
        public Int16 UpdatesPerSecond;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(2)]
        public Byte[] EmptyString;
        [Abide.Guerilla.Tags.FieldAttribute("dead cell penalty", typeof(Single))]
        public Single DeadCellPenalty;
        [Abide.Guerilla.Tags.FieldAttribute("live cell bonus", typeof(Single))]
        public Single LiveCellBonus;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(80)]
        public Byte[] EmptyString1;
        [Abide.Guerilla.Tags.FieldAttribute("width:cells", typeof(Int16))]
        public Int16 Width;
        [Abide.Guerilla.Tags.FieldAttribute("height:cells", typeof(Int16))]
        public Int16 Height;
        [Abide.Guerilla.Tags.FieldAttribute("cell width:world units", typeof(Single))]
        public Single CellWidth;
        [Abide.Guerilla.Tags.FieldAttribute("height:world units", typeof(Single))]
        public Single Height1;
        [Abide.Guerilla.Tags.FieldAttribute("velocity:cells/update", typeof(Vector2))]
        public Vector2 Velocity;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(28)]
        public Byte[] EmptyString2;
        [Abide.Guerilla.Tags.FieldAttribute("marker", typeof(StringId))]
        public StringId Marker;
        [Abide.Guerilla.Tags.FieldAttribute("interpolation flags", typeof(Int32))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(InterpolationFlagsOptions), true)]
        public Int32 InterpolationFlags;
        [Abide.Guerilla.Tags.FieldAttribute("base color", typeof(ColorRgbF))]
        public ColorRgbF BaseColor;
        [Abide.Guerilla.Tags.FieldAttribute("peak color", typeof(ColorRgbF))]
        public ColorRgbF PeakColor;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(76)]
        public Byte[] EmptyString3;
        [Abide.Guerilla.Tags.FieldAttribute("width:cells", typeof(Int16))]
        public Int16 Width1;
        [Abide.Guerilla.Tags.FieldAttribute("height:cells", typeof(Int16))]
        public Int16 Height2;
        [Abide.Guerilla.Tags.FieldAttribute("cell width:world units", typeof(Single))]
        public Single CellWidth1;
        [Abide.Guerilla.Tags.FieldAttribute("velocity:cells/update", typeof(Vector2))]
        public Vector2 Velocity1;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(48)]
        public Byte[] EmptyString4;
        [Abide.Guerilla.Tags.FieldAttribute("marker", typeof(StringId))]
        public StringId Marker1;
        [Abide.Guerilla.Tags.FieldAttribute("texture width:cells", typeof(Int16))]
        public Int16 TextureWidth;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(2)]
        public Byte[] EmptyString5;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(48)]
        public Byte[] EmptyString6;
        [Abide.Guerilla.Tags.FieldAttribute("texture", typeof(TagReference))]
        public TagReference Texture;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(160)]
        public Byte[] EmptyString7;
        [Abide.Guerilla.Tags.FieldAttribute("rules", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("Rules Block", 16, typeof(RulesBlock))]
        public TagBlock Rules;
        public enum InterpolationFlagsOptions
        {
            BlendInHsv = 1,
            MoreColors = 2,
        }
    }
}
#pragma warning restore CS1591