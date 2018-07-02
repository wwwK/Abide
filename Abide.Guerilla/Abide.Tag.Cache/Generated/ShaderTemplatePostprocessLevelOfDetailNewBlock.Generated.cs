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
    /// Represents the generated shader_template_postprocess_level_of_detail_new_block tag block.
    /// </summary>
    public sealed class ShaderTemplatePostprocessLevelOfDetailNewBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShaderTemplatePostprocessLevelOfDetailNewBlock"/> class.
        /// </summary>
        public ShaderTemplatePostprocessLevelOfDetailNewBlock()
        {
            this.Fields.Add(new StructField<TagBlockIndexStructBlock>("layers"));
            this.Fields.Add(new LongIntegerField("available layers"));
            this.Fields.Add(new RealField("projected height percentage"));
        }
        /// <summary>
        /// Gets and returns the name of the shader_template_postprocess_level_of_detail_new_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "shader_template_postprocess_level_of_detail_new_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the shader_template_postprocess_level_of_detail_new_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "shader_template_postprocess_level_of_detail_new_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the shader_template_postprocess_level_of_detail_new_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1024;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the shader_template_postprocess_level_of_detail_new_block tag block.
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
