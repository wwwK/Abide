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
    using Abide.Tag;
    
    /// <summary>
    /// Represents the generated large_bsp2d_nodes_block tag block.
    /// </summary>
    public sealed class LargeBsp2dNodesBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LargeBsp2dNodesBlock"/> class.
        /// </summary>
        public LargeBsp2dNodesBlock()
        {
            this.Fields.Add(new RealPlane2dField("Plane*"));
            this.Fields.Add(new LongIntegerField("Left Child*"));
            this.Fields.Add(new LongIntegerField("Right Child*"));
        }
        /// <summary>
        /// Gets and returns the name of the large_bsp2d_nodes_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "large_bsp2d_nodes_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the large_bsp2d_nodes_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "bsp2d node";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the large_bsp2d_nodes_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 131072;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the large_bsp2d_nodes_block tag block.
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