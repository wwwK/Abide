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
    /// Represents the generated sound_effect_struct_definition_block tag block.
    /// </summary>
    public sealed class SoundEffectStructDefinitionBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SoundEffectStructDefinitionBlock"/> class.
        /// </summary>
        public SoundEffectStructDefinitionBlock()
        {
            this.Fields.Add(new TagReferenceField("", "<fx>"));
            this.Fields.Add(new BlockField<SoundEffectComponentBlock>("components", 16));
            this.Fields.Add(new BlockField<SoundEffectOverridesBlock>("", 128));
            this.Fields.Add(new DataField("", 1, 4));
            this.Fields.Add(new BlockField<PlatformSoundEffectCollectionBlock>("", 1));
        }
        /// <summary>
        /// Gets and returns the name of the sound_effect_struct_definition_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "sound_effect_struct_definition_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the sound_effect_struct_definition_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "sound_effect_struct_definition";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the sound_effect_struct_definition_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the sound_effect_struct_definition_block tag block.
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
