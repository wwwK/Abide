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
    using System;
    using Abide.HaloLibrary;
    using Abide.Tag;
    
    /// <summary>
    /// Represents the generated sound_effect_overrides_block tag block.
    /// </summary>
    public sealed class SoundEffectOverridesBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SoundEffectOverridesBlock"/> class.
        /// </summary>
        public SoundEffectOverridesBlock()
        {
            this.Fields.Add(new StringIdField("name"));
            this.Fields.Add(new BlockField<SoundEffectOverrideParametersBlock>("overrides", 128));
        }
        /// <summary>
        /// Gets and returns the name of the sound_effect_overrides_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "sound_effect_overrides_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the sound_effect_overrides_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "sound_effect_overrides_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the sound_effect_overrides_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 128;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the sound_effect_overrides_block tag block.
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
