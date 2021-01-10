//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Abide.HaloLibrary.Halo2.Retail.Tag.Generated
{
    using System;
    using Abide.HaloLibrary;
    using Abide.HaloLibrary.Halo2.Retail.Tag;
    
    /// <summary>
    /// Represents the generated bitmap_data_block tag block.
    /// </summary>
    internal sealed class BitmapDataBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BitmapDataBlock"/> class.
        /// </summary>
        public BitmapDataBlock()
        {
            this.Fields.Add(new TagField("Signature*"));
            this.Fields.Add(new ShortIntegerField("Width*:pixels"));
            this.Fields.Add(new ShortIntegerField("Height*:pixels"));
            this.Fields.Add(new CharIntegerField("Depth*:pixels#Depth is 1 for 2D textures and cube maps."));
            this.Fields.Add(new ByteFlagsField("More Flags", "Delete from Cache File", "bitmap create attempted", ""));
            this.Fields.Add(new EnumField("Type*#Determines bitmap \"geometry.\"", "2D Texture", "3D Texture", "Cube Map"));
            this.Fields.Add(new EnumField("Format*#Determines how pixels are represented internally.", "a8", "y8", "ay8", "a8y8", "unused1", "unused2", "r5g6b5", "unused3", "a1r5g5b5", "a4r4g4b4", "x8r8g8b8", "a8r8g8b8", "unused4", "unused5", "dxt1", "dxt3", "dxt5", "p8-bump", "p8", "argbfp32", "rgbfp32", "rgbfp16", "v8u8", "g8b8"));
            this.Fields.Add(new WordFlagsField("Flags*", "Power of Two Dimensions", "Compressed", "Palettized", "Swizzled", "Linear", "v16u16", "MIP Map Debug Level", "Prefer Stutter (Prefer Low Detail)"));
            this.Fields.Add(new Point2dField("Registration Point*"));
            this.Fields.Add(new ShortIntegerField("mipmap Count*"));
            this.Fields.Add(new ShortIntegerField("Low-Detail mipmap Count*"));
            this.Fields.Add(new LongIntegerField("Pixels Offset*"));
            this.Fields.Add(new SkipField("", 12));
            this.Fields.Add(new SkipField("", 12));
            this.Fields.Add(new SkipField("", 12));
            this.Fields.Add(new SkipField("", 12));
            this.Fields.Add(new TagIndexField(""));
            this.Fields.Add(new SkipField("", 4));
            this.Fields.Add(new SkipField("", 4));
            this.Fields.Add(new SkipField("", 4));
            this.Fields.Add(new SkipField("", 20));
            this.Fields.Add(new SkipField("", 4));
        }
        /// <summary>
        /// Gets and returns the name of the bitmap_data_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "bitmap_data_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the bitmap_data_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "bitmap_data_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the bitmap_data_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 65536;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the bitmap_data_block tag block.
        /// </summary>
        public override int Alignment
        {
            get
            {
                return 4;
            }
        }
    }
}
