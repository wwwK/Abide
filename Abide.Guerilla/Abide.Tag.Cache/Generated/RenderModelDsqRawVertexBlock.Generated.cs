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
    /// Represents the generated render_model_dsq_raw_vertex_block tag block.
    /// </summary>
    public sealed class RenderModelDsqRawVertexBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RenderModelDsqRawVertexBlock"/> class.
        /// </summary>
        public RenderModelDsqRawVertexBlock()
        {
            this.Fields.Add(new RealPoint3dField("position*"));
            this.Fields.Add(new RealPlane3dField("plane*"));
            this.Fields.Add(new LongIntegerField("node index*"));
        }
        /// <summary>
        /// Gets and returns the name of the render_model_dsq_raw_vertex_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "render_model_dsq_raw_vertex_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the render_model_dsq_raw_vertex_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "vertex";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the render_model_dsq_raw_vertex_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 65536;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the render_model_dsq_raw_vertex_block tag block.
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
