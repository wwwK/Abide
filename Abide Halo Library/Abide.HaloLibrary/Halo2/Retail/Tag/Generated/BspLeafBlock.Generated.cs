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
    /// Represents the generated bsp_leaf_block tag block.
    /// </summary>
    internal sealed class BspLeafBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BspLeafBlock"/> class.
        /// </summary>
        public BspLeafBlock()
        {
            this.Fields.Add(new ShortIntegerField("cluster*"));
            this.Fields.Add(new ShortIntegerField("surface reference count*"));
            this.Fields.Add(new LongIntegerField("first surface reference index*"));
        }
        /// <summary>
        /// Gets and returns the name of the bsp_leaf_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "bsp_leaf_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the bsp_leaf_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "bsp_leaf_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the bsp_leaf_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 65536;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the bsp_leaf_block tag block.
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
