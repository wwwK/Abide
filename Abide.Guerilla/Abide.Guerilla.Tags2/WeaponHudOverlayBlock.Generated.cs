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
    
    [Abide.Guerilla.Tags.FieldSetAttribute(136, 4)]
    public class WeaponHudOverlayBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("anchor offset", typeof(Vector2))]
        public Vector2 AnchorOffset;
        [Abide.Guerilla.Tags.FieldAttribute("width scale", typeof(Single))]
        public Single WidthScale;
        [Abide.Guerilla.Tags.FieldAttribute("height scale", typeof(Single))]
        public Single HeightScale;
        [Abide.Guerilla.Tags.FieldAttribute("scaling flags", typeof(Int16))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(ScalingFlagsOptions), true)]
        public Int16 ScalingFlags;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(2)]
        public Byte[] EmptyString;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(20)]
        public Byte[] EmptyString1;
        [Abide.Guerilla.Tags.FieldAttribute("default color", typeof(ColorArgb))]
        public ColorArgb DefaultColor;
        [Abide.Guerilla.Tags.FieldAttribute("flashing color", typeof(ColorArgb))]
        public ColorArgb FlashingColor;
        [Abide.Guerilla.Tags.FieldAttribute("flash period", typeof(Single))]
        public Single FlashPeriod;
        [Abide.Guerilla.Tags.FieldAttribute("flash delay#time between flashes", typeof(Single))]
        public Single FlashDelay;
        [Abide.Guerilla.Tags.FieldAttribute("number of flashes", typeof(Int16))]
        public Int16 NumberOfFlashes;
        [Abide.Guerilla.Tags.FieldAttribute("flash flags", typeof(Int16))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(FlashFlagsOptions), true)]
        public Int16 FlashFlags;
        [Abide.Guerilla.Tags.FieldAttribute("flash length#time of each flash", typeof(Single))]
        public Single FlashLength;
        [Abide.Guerilla.Tags.FieldAttribute("disabled color", typeof(ColorArgb))]
        public ColorArgb DisabledColor;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(4)]
        public Byte[] EmptyString2;
        [Abide.Guerilla.Tags.FieldAttribute("frame rate", typeof(Int16))]
        public Int16 FrameRate;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(2)]
        public Byte[] EmptyString3;
        [Abide.Guerilla.Tags.FieldAttribute("sequence index", typeof(Int16))]
        public Int16 SequenceIndex;
        [Abide.Guerilla.Tags.FieldAttribute("type", typeof(Int16))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(TypeOptions), true)]
        public Int16 Type;
        [Abide.Guerilla.Tags.FieldAttribute("flags", typeof(Int32))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(FlagsOptions), true)]
        public Int32 Flags;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(16)]
        public Byte[] EmptyString4;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(40)]
        public Byte[] EmptyString5;
        public enum ScalingFlagsOptions
        {
            DontScaleOffset = 1,
            DontScaleSize = 2,
        }
        public enum FlashFlagsOptions
        {
            ReverseDefaultflashingColors = 1,
        }
        public enum TypeOptions
        {
            ShowOnFlashing = 1,
            ShowOnEmpty = 2,
            ShowOnReloadoverheating = 4,
            ShowOnDefault = 8,
            ShowAlways = 16,
        }
        public enum FlagsOptions
        {
            FlashesWhenActive = 1,
        }
    }
}
#pragma warning restore CS1591