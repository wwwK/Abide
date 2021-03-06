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
    /// Represents the generated node_render_leaves_block tag block.
    /// </summary>
    internal sealed class NodeRenderLeavesBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NodeRenderLeavesBlock"/> class.
        /// </summary>
        public NodeRenderLeavesBlock()
        {
            this.Fields.Add(new BlockField<BspLeafBlock>("collision leaves*", 65536));
            this.Fields.Add(new BlockField<BspSurfaceReferenceBlock>("surface references*", 262144));
        }
        /// <summary>
        /// Gets and returns the name of the node_render_leaves_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "node_render_leaves_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the node_render_leaves_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "node_render_leaves_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the node_render_leaves_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 64;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the node_render_leaves_block tag block.
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
