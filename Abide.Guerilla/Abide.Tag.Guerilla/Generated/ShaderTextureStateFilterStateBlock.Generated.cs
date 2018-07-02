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
    /// Represents the generated shader_texture_state_filter_state_block tag block.
    /// </summary>
    public sealed class ShaderTextureStateFilterStateBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShaderTextureStateFilterStateBlock"/> class.
        /// </summary>
        public ShaderTextureStateFilterStateBlock()
        {
            this.Fields.Add(new EnumField("mag filter", "none", "point sampled", "linear", "anisotropic", "quincunx", "gaussian cubic"));
            this.Fields.Add(new EnumField("min filter", "none", "point sampled", "linear", "anisotropic", "quincunx", "gaussian cubic"));
            this.Fields.Add(new EnumField("mip filter", "none", "point sampled", "linear", "anisotropic", "quincunx", "gaussian cubic"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new RealField("mipmap bias"));
            this.Fields.Add(new ShortIntegerField("max mipmap index#0 means all mipmap levels are used"));
            this.Fields.Add(new EnumField("anisotropy", "non anisotropic", "2-tap", "3-tap", "4-tap"));
        }
        /// <summary>
        /// Gets and returns the name of the shader_texture_state_filter_state_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "shader_texture_state_filter_state_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the shader_texture_state_filter_state_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "filter state";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the shader_texture_state_filter_state_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the shader_texture_state_filter_state_block tag block.
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
