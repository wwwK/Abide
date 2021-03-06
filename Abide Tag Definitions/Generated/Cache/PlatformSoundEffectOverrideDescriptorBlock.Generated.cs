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
    /// Represents the generated platform_sound_effect_override_descriptor_block tag block.
    /// </summary>
    public sealed class PlatformSoundEffectOverrideDescriptorBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlatformSoundEffectOverrideDescriptorBlock"/> class.
        /// </summary>
        public PlatformSoundEffectOverrideDescriptorBlock()
        {
            this.Fields.Add(new CharIntegerField("override descriptor"));
        }
        /// <summary>
        /// Gets and returns the name of the platform_sound_effect_override_descriptor_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "platform_sound_effect_override_descriptor_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the platform_sound_effect_override_descriptor_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "platform_sound_effect_override_descriptor_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the platform_sound_effect_override_descriptor_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 16;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the platform_sound_effect_override_descriptor_block tag block.
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
