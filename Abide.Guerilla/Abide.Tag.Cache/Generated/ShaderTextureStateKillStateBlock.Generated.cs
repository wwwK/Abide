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
    /// Represents the generated shader_texture_state_kill_state_block tag block.
    /// </summary>
    public sealed class ShaderTextureStateKillStateBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShaderTextureStateKillStateBlock"/> class.
        /// </summary>
        public ShaderTextureStateKillStateBlock()
        {
            this.Fields.Add(new WordFlagsField("flags", "alpha kill"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new EnumField("colorkey mode", "disabled", "zero alpha", "zero ARGB", "kill"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new RgbColorField("colorkey color"));
        }
        /// <summary>
        /// Gets and returns the name of the shader_texture_state_kill_state_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "shader_texture_state_kill_state_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the shader_texture_state_kill_state_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "kill state";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the shader_texture_state_kill_state_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the shader_texture_state_kill_state_block tag block.
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
