//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Abide.HaloLibrary.Halo2.Retail.Tag.Generated
{
    using System;
    using Abide.HaloLibrary;
    using Abide.HaloLibrary.Halo2.Retail.Tag;
    
    /// <summary>
    /// Represents the generated platform_sound_filter_block tag block.
    /// </summary>
    public sealed class PlatformSoundFilterBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlatformSoundFilterBlock"/> class.
        /// </summary>
        public PlatformSoundFilterBlock()
        {
            this.Fields.Add(new ExplanationField("parameter description", @"DLS2 filtering:
    resonance gain range: [0, 22.5] dB

parametric EQ:
    gain range: [-64, 14] dB

for mono sounds:
    the left filter controls the DLS 2 parameters
    the right filter controls the Parametric EQ parameters

for stereo sounds:
    both left and right channels must have the same filter
    i.e., filter type both is invalid"));
            this.Fields.Add(new LongEnumField("filter type", "parametric EQ", "DLS2", "both (only valid for mono)"));
            this.Fields.Add(new LongIntegerField("filter width:[0,7]"));
            this.Fields.Add(new ExplanationField("left filter frequency", "in Hz [0,8000]"));
            this.Fields.Add(new StructField<SoundPlaybackParameterDefinitionBlock>("left filter frequency"));
            this.Fields.Add(new ExplanationField("left filter gain", "in dB"));
            this.Fields.Add(new StructField<SoundPlaybackParameterDefinitionBlock>("left filter gain"));
            this.Fields.Add(new ExplanationField("right filter frequency", "in Hz [0,8000]"));
            this.Fields.Add(new StructField<SoundPlaybackParameterDefinitionBlock>("right filter frequency"));
            this.Fields.Add(new ExplanationField("right filter gain", "in dB"));
            this.Fields.Add(new StructField<SoundPlaybackParameterDefinitionBlock>("right filter gain"));
        }
        /// <summary>
        /// Gets and returns the name of the platform_sound_filter_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "platform_sound_filter_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the platform_sound_filter_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "platform_sound_filter_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the platform_sound_filter_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the platform_sound_filter_block tag block.
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
