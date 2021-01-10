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
    /// Represents the generated sound_global_mix_struct_block tag block.
    /// </summary>
    internal sealed class SoundGlobalMixStructBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SoundGlobalMixStructBlock"/> class.
        /// </summary>
        public SoundGlobalMixStructBlock()
        {
            this.Fields.Add(new RealField("mono unspatialized gain:dB"));
            this.Fields.Add(new RealField("stereo to 3d gain:dB"));
            this.Fields.Add(new RealField("rear surround to front stereo gain:dB"));
            this.Fields.Add(new ExplanationField("surround center mix", "for sounds that use the center speaker"));
            this.Fields.Add(new RealField("front speaker gain:dB"));
            this.Fields.Add(new RealField("center speaker gain:dB"));
            this.Fields.Add(new ExplanationField("stereo center mix", "for sounds that use the center speaker"));
            this.Fields.Add(new RealField("front speaker gain:dB"));
            this.Fields.Add(new RealField("center speaker gain:dB"));
            this.Fields.Add(new ExplanationField("more sound lovin\'", "for sounds that use the center speaker"));
            this.Fields.Add(new RealField("stereo unspatialized gain:dB"));
            this.Fields.Add(new ExplanationField("last minute values", ""));
            this.Fields.Add(new RealField("solo player fade out delay: seconds"));
            this.Fields.Add(new RealField("solo player fade out time: seconds"));
            this.Fields.Add(new RealField("solo player fade in time: seconds"));
            this.Fields.Add(new RealField("game music fade out time: seconds"));
        }
        /// <summary>
        /// Gets and returns the name of the sound_global_mix_struct_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "sound_global_mix_struct_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the sound_global_mix_struct_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "sound_global_mix_struct";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the sound_global_mix_struct_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the sound_global_mix_struct_block tag block.
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
