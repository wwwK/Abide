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
    /// Represents the generated shader_pass_postprocess_texture_new_block tag block.
    /// </summary>
    public sealed class ShaderPassPostprocessTextureNewBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShaderPassPostprocessTextureNewBlock"/> class.
        /// </summary>
        public ShaderPassPostprocessTextureNewBlock()
        {
            this.Fields.Add(new CharIntegerField("bitmap parameter index"));
            this.Fields.Add(new CharIntegerField("bitmap extern index"));
            this.Fields.Add(new CharIntegerField("texture stage index"));
            this.Fields.Add(new CharIntegerField("flags"));
        }
        /// <summary>
        /// Gets and returns the name of the shader_pass_postprocess_texture_new_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "shader_pass_postprocess_texture_new_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the shader_pass_postprocess_texture_new_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "shader_pass_postprocess_texture_new_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the shader_pass_postprocess_texture_new_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1024;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the shader_pass_postprocess_texture_new_block tag block.
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