//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Abide.Tag.Guerilla.Generated
{
    using System;
    using Abide.HaloLibrary;
    using Abide.Tag;
    
    /// <summary>
    /// Represents the generated prt_vertex_buffers_block tag block.
    /// </summary>
    public sealed class PrtVertexBuffersBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrtVertexBuffersBlock"/> class.
        /// </summary>
        public PrtVertexBuffersBlock()
        {
            this.Fields.Add(new VertexBufferField("vertex buffer*"));
        }
        /// <summary>
        /// Gets and returns the name of the prt_vertex_buffers_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "prt_vertex_buffers_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the prt_vertex_buffers_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "vertex buffers";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the prt_vertex_buffers_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 255;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the prt_vertex_buffers_block tag block.
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
