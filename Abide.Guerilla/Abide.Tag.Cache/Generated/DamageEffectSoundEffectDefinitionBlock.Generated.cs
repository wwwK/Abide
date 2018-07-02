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
    /// Represents the generated damage_effect_sound_effect_definition_block tag block.
    /// </summary>
    public sealed class DamageEffectSoundEffectDefinitionBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DamageEffectSoundEffectDefinitionBlock"/> class.
        /// </summary>
        public DamageEffectSoundEffectDefinitionBlock()
        {
            this.Fields.Add(new StringIdField("effect name"));
            this.Fields.Add(new RealField("duration:seconds"));
            this.Fields.Add(new StructField<MappingFunctionBlock>("effect scale function"));
        }
        /// <summary>
        /// Gets and returns the name of the damage_effect_sound_effect_definition_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "damage_effect_sound_effect_definition_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the damage_effect_sound_effect_definition_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "damage_effect_sound_effect_definition";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the damage_effect_sound_effect_definition_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the damage_effect_sound_effect_definition_block tag block.
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
