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
    /// Represents the generated sound_effect_override_parameters_block tag block.
    /// </summary>
    public sealed class SoundEffectOverrideParametersBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SoundEffectOverrideParametersBlock"/> class.
        /// </summary>
        public SoundEffectOverrideParametersBlock()
        {
            this.Fields.Add(new StringIdField("name"));
            this.Fields.Add(new StringIdField("input"));
            this.Fields.Add(new StringIdField("range"));
            this.Fields.Add(new RealField("time period: seconds"));
            this.Fields.Add(new LongIntegerField("integer value"));
            this.Fields.Add(new RealField("real value"));
            this.Fields.Add(new StructField<MappingFunctionBlock>("function value"));
        }
        /// <summary>
        /// Gets and returns the name of the sound_effect_override_parameters_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "sound_effect_override_parameters_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the sound_effect_override_parameters_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "sound_effect_override_parameters_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the sound_effect_override_parameters_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 128;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the sound_effect_override_parameters_block tag block.
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
