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
    /// Represents the generated render_model_node_map_block tag block.
    /// </summary>
    internal sealed class RenderModelNodeMapBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RenderModelNodeMapBlock"/> class.
        /// </summary>
        public RenderModelNodeMapBlock()
        {
            this.Fields.Add(new CharIntegerField("node index*"));
        }
        /// <summary>
        /// Gets and returns the name of the render_model_node_map_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "render_model_node_map_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the render_model_node_map_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "index";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the render_model_node_map_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 40;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the render_model_node_map_block tag block.
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
