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
    /// Represents the generated bsp2d_nodes_block tag block.
    /// </summary>
    public sealed class Bsp2dNodesBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Bsp2dNodesBlock"/> class.
        /// </summary>
        public Bsp2dNodesBlock()
        {
            this.Fields.Add(new RealPlane2dField("Plane*"));
            this.Fields.Add(new ShortIntegerField("Left Child*"));
            this.Fields.Add(new ShortIntegerField("Right Child*"));
        }
        /// <summary>
        /// Gets and returns the name of the bsp2d_nodes_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "bsp2d_nodes_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the bsp2d_nodes_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "bsp2d_nodes_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the bsp2d_nodes_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 131072;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the bsp2d_nodes_block tag block.
        /// </summary>
        public override int Alignment
        {
            get
            {
                return 16;
            }
        }
    }
}
