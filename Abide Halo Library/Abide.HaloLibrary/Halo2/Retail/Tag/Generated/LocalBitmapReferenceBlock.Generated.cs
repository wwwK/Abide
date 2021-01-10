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
    /// Represents the generated local_bitmap_reference_block tag block.
    /// </summary>
    internal sealed class LocalBitmapReferenceBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocalBitmapReferenceBlock"/> class.
        /// </summary>
        public LocalBitmapReferenceBlock()
        {
            this.Fields.Add(new TagReferenceField("bitmap", 1651078253));
        }
        /// <summary>
        /// Gets and returns the name of the local_bitmap_reference_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "local_bitmap_reference_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the local_bitmap_reference_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "local_bitmap_reference_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the local_bitmap_reference_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 16;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the local_bitmap_reference_block tag block.
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
