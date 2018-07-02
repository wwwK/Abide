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
    /// Represents the generated sound_scale_modifiers_struct_block tag block.
    /// </summary>
    public sealed class SoundScaleModifiersStructBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SoundScaleModifiersStructBlock"/> class.
        /// </summary>
        public SoundScaleModifiersStructBlock()
        {
            this.Fields.Add(new ExplanationField("scale modifiers", "as the sound\'s input scale changes from zero to one, these modifiers move between" +
                        " the two values specified here. the sound will play using the current scale modi" +
                        "fier multiplied by the values specified above. (0 values are ignored.)"));
            this.Fields.Add(new RealBoundsField("gain modifier:dB"));
            this.Fields.Add(new ShortBoundsField("pitch modifier:cents"));
            this.Fields.Add(new RealFractionBoundsField("skip fraction modifier"));
        }
        /// <summary>
        /// Gets and returns the name of the sound_scale_modifiers_struct_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "sound_scale_modifiers_struct_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the sound_scale_modifiers_struct_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "sound_scale_modifiers_struct";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the sound_scale_modifiers_struct_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the sound_scale_modifiers_struct_block tag block.
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
