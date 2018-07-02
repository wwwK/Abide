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
    /// Represents the generated texture_stage_state_parameter_block tag block.
    /// </summary>
    public sealed class TextureStageStateParameterBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TextureStageStateParameterBlock"/> class.
        /// </summary>
        public TextureStageStateParameterBlock()
        {
            this.Fields.Add(new CharIntegerField("parameter index"));
            this.Fields.Add(new CharIntegerField("parameter type"));
            this.Fields.Add(new CharIntegerField("state index"));
            this.Fields.Add(new CharIntegerField("stage index"));
        }
        /// <summary>
        /// Gets and returns the name of the texture_stage_state_parameter_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "texture_stage_state_parameter_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the texture_stage_state_parameter_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "texture_stage_state_parameter_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the texture_stage_state_parameter_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1024;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the texture_stage_state_parameter_block tag block.
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
