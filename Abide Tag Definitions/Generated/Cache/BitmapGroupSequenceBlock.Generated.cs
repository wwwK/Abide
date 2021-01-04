//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Abide.Tag.Cache.Generated
{
    using System;
    using Abide.HaloLibrary;
    using Abide.Tag;
    
    /// <summary>
    /// Represents the generated bitmap_group_sequence_block tag block.
    /// </summary>
    public sealed class BitmapGroupSequenceBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BitmapGroupSequenceBlock"/> class.
        /// </summary>
        public BitmapGroupSequenceBlock()
        {
            this.Fields.Add(new StringField("Name^"));
            this.Fields.Add(new ShortIntegerField("First Bitmap Index*"));
            this.Fields.Add(new ShortIntegerField("Bitmap Count*"));
            this.Fields.Add(new PadField("", 16));
            this.Fields.Add(new BlockField<BitmapGroupSpriteBlock>("Sprites*", 64));
        }
        /// <summary>
        /// Gets and returns the name of the bitmap_group_sequence_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "bitmap_group_sequence_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the bitmap_group_sequence_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "bitmap_group_sequence_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the bitmap_group_sequence_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 256;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the bitmap_group_sequence_block tag block.
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