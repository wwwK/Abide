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
    
    [Abide.Guerilla.Tags.FieldSetAttribute(504, 4)]
    [Abide.Guerilla.Tags.TagGroupAttribute("grenade_hud_interface", "grhi", "����", typeof(GrenadeHudInterfaceBlock))]
    public class GrenadeHudInterfaceBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("anchor", typeof(Int16))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(AnchorOptions), false)]
        public Int16 Anchor;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(2)]
        public Byte[] EmptyString1;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(32)]
        public Byte[] EmptyString2;
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
        public Byte[] EmptyString3;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(20)]
        public Byte[] EmptyString4;
        [Abide.Guerilla.Tags.FieldAttribute("interface bitmap", typeof(TagReference))]
        public TagReference InterfaceBitmap;
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
        public Byte[] EmptyString5;
        [Abide.Guerilla.Tags.FieldAttribute("sequence index", typeof(Int16))]
        public Int16 SequenceIndex;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(2)]
        public Byte[] EmptyString6;
        [Abide.Guerilla.Tags.FieldAttribute("multitex overlay", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("Global Hud Multitexture Overlay Definition", 30, typeof(GlobalHudMultitextureOverlayDefinition))]
        public TagBlock MultitexOverlay;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(4)]
        public Byte[] EmptyString7;
        [Abide.Guerilla.Tags.FieldAttribute("anchor offset", typeof(Vector2))]
        public Vector2 AnchorOffset1;
        [Abide.Guerilla.Tags.FieldAttribute("width scale", typeof(Single))]
        public Single WidthScale1;
        [Abide.Guerilla.Tags.FieldAttribute("height scale", typeof(Single))]
        public Single HeightScale1;
        [Abide.Guerilla.Tags.FieldAttribute("scaling flags", typeof(Int16))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(ScalingFlagsOptions1), true)]
        public Int16 ScalingFlags1;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(2)]
        public Byte[] EmptyString8;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(20)]
        public Byte[] EmptyString9;
        [Abide.Guerilla.Tags.FieldAttribute("interface bitmap", typeof(TagReference))]
        public TagReference InterfaceBitmap1;
        [Abide.Guerilla.Tags.FieldAttribute("default color", typeof(ColorArgb))]
        public ColorArgb DefaultColor1;
        [Abide.Guerilla.Tags.FieldAttribute("flashing color", typeof(ColorArgb))]
        public ColorArgb FlashingColor1;
        [Abide.Guerilla.Tags.FieldAttribute("flash period", typeof(Single))]
        public Single FlashPeriod1;
        [Abide.Guerilla.Tags.FieldAttribute("flash delay#time between flashes", typeof(Single))]
        public Single FlashDelay1;
        [Abide.Guerilla.Tags.FieldAttribute("number of flashes", typeof(Int16))]
        public Int16 NumberOfFlashes1;
        [Abide.Guerilla.Tags.FieldAttribute("flash flags", typeof(Int16))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(FlashFlagsOptions1), true)]
        public Int16 FlashFlags1;
        [Abide.Guerilla.Tags.FieldAttribute("flash length#time of each flash", typeof(Single))]
        public Single FlashLength1;
        [Abide.Guerilla.Tags.FieldAttribute("disabled color", typeof(ColorArgb))]
        public ColorArgb DisabledColor1;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(4)]
        public Byte[] EmptyString10;
        [Abide.Guerilla.Tags.FieldAttribute("sequence index", typeof(Int16))]
        public Int16 SequenceIndex1;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(2)]
        public Byte[] EmptyString11;
        [Abide.Guerilla.Tags.FieldAttribute("multitex overlay", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("Global Hud Multitexture Overlay Definition", 30, typeof(GlobalHudMultitextureOverlayDefinition))]
        public TagBlock MultitexOverlay1;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(4)]
        public Byte[] EmptyString12;
        [Abide.Guerilla.Tags.FieldAttribute("anchor offset", typeof(Vector2))]
        public Vector2 AnchorOffset2;
        [Abide.Guerilla.Tags.FieldAttribute("width scale", typeof(Single))]
        public Single WidthScale2;
        [Abide.Guerilla.Tags.FieldAttribute("height scale", typeof(Single))]
        public Single HeightScale2;
        [Abide.Guerilla.Tags.FieldAttribute("scaling flags", typeof(Int16))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(ScalingFlagsOptions2), true)]
        public Int16 ScalingFlags2;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(2)]
        public Byte[] EmptyString13;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(20)]
        public Byte[] EmptyString14;
        [Abide.Guerilla.Tags.FieldAttribute("default color", typeof(ColorArgb))]
        public ColorArgb DefaultColor2;
        [Abide.Guerilla.Tags.FieldAttribute("flashing color", typeof(ColorArgb))]
        public ColorArgb FlashingColor2;
        [Abide.Guerilla.Tags.FieldAttribute("flash period", typeof(Single))]
        public Single FlashPeriod2;
        [Abide.Guerilla.Tags.FieldAttribute("flash delay#time between flashes", typeof(Single))]
        public Single FlashDelay2;
        [Abide.Guerilla.Tags.FieldAttribute("number of flashes", typeof(Int16))]
        public Int16 NumberOfFlashes2;
        [Abide.Guerilla.Tags.FieldAttribute("flash flags", typeof(Int16))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(FlashFlagsOptions2), true)]
        public Int16 FlashFlags2;
        [Abide.Guerilla.Tags.FieldAttribute("flash length#time of each flash", typeof(Single))]
        public Single FlashLength2;
        [Abide.Guerilla.Tags.FieldAttribute("disabled color", typeof(ColorArgb))]
        public ColorArgb DisabledColor2;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(4)]
        public Byte[] EmptyString15;
        [Abide.Guerilla.Tags.FieldAttribute("maximum number of digits", typeof(Byte))]
        public Byte MaximumNumberOfDigits;
        [Abide.Guerilla.Tags.FieldAttribute("flags", typeof(Byte))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(FlagsOptions), true)]
        public Byte Flags;
        [Abide.Guerilla.Tags.FieldAttribute("number of fractional digits", typeof(Byte))]
        public Byte NumberOfFractionalDigits;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(1)]
        public Byte[] EmptyString16;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(12)]
        public Byte[] EmptyString17;
        [Abide.Guerilla.Tags.FieldAttribute("flash cutoff", typeof(Int16))]
        public Int16 FlashCutoff;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(2)]
        public Byte[] EmptyString18;
        [Abide.Guerilla.Tags.FieldAttribute("Overlay bitmap", typeof(TagReference))]
        public TagReference OverlayBitmap;
        [Abide.Guerilla.Tags.FieldAttribute("Overlays", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("Grenade Hud Overlay Block", 16, typeof(GrenadeHudOverlayBlock))]
        public TagBlock Overlays;
        [Abide.Guerilla.Tags.FieldAttribute("Warning sounds", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("Grenade Hud Sound Block", 12, typeof(GrenadeHudSoundBlock))]
        public TagBlock WarningSounds;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(68)]
        public Byte[] EmptyString19;
        [Abide.Guerilla.Tags.FieldAttribute("sequence index#sequence index into the global hud icon bitmap", typeof(Int16))]
        public Int16 SequenceIndex2;
        [Abide.Guerilla.Tags.FieldAttribute("width offset#extra spacing beyond bitmap width for text alignment", typeof(Int16))]
        public Int16 WidthOffset;
        [Abide.Guerilla.Tags.FieldAttribute("offset from reference corner", typeof(Vector2))]
        public Vector2 OffsetFromReferenceCorner;
        [Abide.Guerilla.Tags.FieldAttribute("override icon color", typeof(ColorArgb))]
        public ColorArgb OverrideIconColor;
        [Abide.Guerilla.Tags.FieldAttribute("frame rate [0,30]", typeof(Byte))]
        public Byte FrameRate030;
        [Abide.Guerilla.Tags.FieldAttribute("flags", typeof(Byte))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(FlagsOptions1), true)]
        public Byte Flags1;
        [Abide.Guerilla.Tags.FieldAttribute("text index", typeof(Int16))]
        public Int16 TextIndex;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(48)]
        public Byte[] EmptyString20;
        public enum AnchorOptions
        {
            TopLeft = 0,
            TopRight = 1,
            BottomLeft = 2,
            BottomRight = 3,
            Center = 4,
            Crosshair = 5,
        }
        public enum ScalingFlagsOptions
        {
            DontScaleOffset = 1,
            DontScaleSize = 2,
        }
        public enum FlashFlagsOptions
        {
            ReverseDefaultflashingColors = 1,
        }
        public enum ScalingFlagsOptions1
        {
            DontScaleOffset = 1,
            DontScaleSize = 2,
        }
        public enum FlashFlagsOptions1
        {
            ReverseDefaultflashingColors = 1,
        }
        public enum ScalingFlagsOptions2
        {
            DontScaleOffset = 1,
            DontScaleSize = 2,
        }
        public enum FlashFlagsOptions2
        {
            ReverseDefaultflashingColors = 1,
        }
        public enum FlagsOptions
        {
            ShowLeadingZeros = 1,
            OnlyShowWhenZoomed = 2,
            DrawATrailingM = 4,
        }
        public enum FlagsOptions1
        {
            UseTextFromStringListInstead = 1,
            OverrideDefaultColor = 2,
            WidthOffsetIsAbsoluteIconWidth = 4,
        }
    }
}
#pragma warning restore CS1591