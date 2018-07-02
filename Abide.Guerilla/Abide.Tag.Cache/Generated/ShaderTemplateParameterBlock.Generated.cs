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
    /// Represents the generated shader_template_parameter_block tag block.
    /// </summary>
    public sealed class ShaderTemplateParameterBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShaderTemplateParameterBlock"/> class.
        /// </summary>
        public ShaderTemplateParameterBlock()
        {
            this.Fields.Add(new StringIdField("Name^"));
            this.Fields.Add(new DataField("Explanation", 1, 4));
            this.Fields.Add(new EnumField("Type", "Bitmap", "Value", "Color", "Switch"));
            this.Fields.Add(new WordFlagsField("Flags", "Animated", "Hide Bitmap Reference"));
            this.Fields.Add(new TagReferenceField("Default Bitmap", "bitm"));
            this.Fields.Add(new RealField("Default Const Value"));
            this.Fields.Add(new RealRgbColorField("Default Const Color"));
            this.Fields.Add(new EnumField("Bitmap Type", "2D", "3D", "Cube Map"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new WordFlagsField("Bitmap Animation Flags", "Scale Uniform", "Scale", "Translation", "Rotation", "Index"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new RealField("Bitmap Scale"));
        }
        /// <summary>
        /// Gets and returns the name of the shader_template_parameter_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "shader_template_parameter_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the shader_template_parameter_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "parameter";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the shader_template_parameter_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 64;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the shader_template_parameter_block tag block.
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
