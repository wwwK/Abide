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
    /// Represents the generated mouse_cursor_bitmap_reference_block tag block.
    /// </summary>
    public sealed class MouseCursorBitmapReferenceBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MouseCursorBitmapReferenceBlock"/> class.
        /// </summary>
        public MouseCursorBitmapReferenceBlock()
        {
            this.Fields.Add(new TagReferenceField("bitmap", 1651078253));
        }
        /// <summary>
        /// Gets and returns the name of the mouse_cursor_bitmap_reference_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "mouse_cursor_bitmap_reference_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the mouse_cursor_bitmap_reference_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "mouse_cursor_bitmap_reference_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the mouse_cursor_bitmap_reference_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 4;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the mouse_cursor_bitmap_reference_block tag block.
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