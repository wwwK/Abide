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
    /// Represents the generated color_table_block tag block.
    /// </summary>
    public sealed class ColorTableBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ColorTableBlock"/> class.
        /// </summary>
        public ColorTableBlock()
        {
            this.Fields.Add(new BlockField<ColorBlock>("colors", 512));
        }
        /// <summary>
        /// Gets and returns the name of the color_table_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "color_table_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the color_table_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "color_table";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the color_table_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the color_table_block tag block.
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
