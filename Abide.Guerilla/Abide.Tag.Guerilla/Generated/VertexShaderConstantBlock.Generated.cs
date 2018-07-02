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
    using Abide.Tag;
    
    /// <summary>
    /// Represents the generated vertex_shader_constant_block tag block.
    /// </summary>
    public sealed class VertexShaderConstantBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VertexShaderConstantBlock"/> class.
        /// </summary>
        public VertexShaderConstantBlock()
        {
            this.Fields.Add(new CharIntegerField("register index"));
            this.Fields.Add(new CharIntegerField("parameter index"));
            this.Fields.Add(new CharIntegerField("destination mask"));
            this.Fields.Add(new CharIntegerField("scale by texture stage"));
        }
        /// <summary>
        /// Gets and returns the name of the vertex_shader_constant_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "vertex_shader_constant_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the vertex_shader_constant_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "vertex_shader_constant_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the vertex_shader_constant_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1024;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the vertex_shader_constant_block tag block.
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
