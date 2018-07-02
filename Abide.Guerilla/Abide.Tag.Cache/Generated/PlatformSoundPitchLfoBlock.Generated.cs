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
    /// Represents the generated platform_sound_pitch_lfo_block tag block.
    /// </summary>
    public sealed class PlatformSoundPitchLfoBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlatformSoundPitchLfoBlock"/> class.
        /// </summary>
        public PlatformSoundPitchLfoBlock()
        {
            this.Fields.Add(new ExplanationField("delay", "seconds"));
            this.Fields.Add(new StructField<SoundPlaybackParameterDefinitionBlock>("delay"));
            this.Fields.Add(new ExplanationField("frequency", "Hz[0,43.7]"));
            this.Fields.Add(new StructField<SoundPlaybackParameterDefinitionBlock>("frequency"));
            this.Fields.Add(new ExplanationField("pitch modulation", "octaves[-1,1]"));
            this.Fields.Add(new StructField<SoundPlaybackParameterDefinitionBlock>("pitch modulation"));
        }
        /// <summary>
        /// Gets and returns the name of the platform_sound_pitch_lfo_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "platform_sound_pitch_lfo_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the platform_sound_pitch_lfo_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "platform_sound_pitch_lfo_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the platform_sound_pitch_lfo_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the platform_sound_pitch_lfo_block tag block.
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
