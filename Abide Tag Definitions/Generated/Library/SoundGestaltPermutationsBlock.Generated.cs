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
    /// Represents the generated sound_gestalt_permutations_block tag block.
    /// </summary>
    public sealed class SoundGestaltPermutationsBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SoundGestaltPermutationsBlock"/> class.
        /// </summary>
        public SoundGestaltPermutationsBlock()
        {
            this.Fields.Add(new ShortBlockIndexField("name^"));
            this.Fields.Add(new ShortIntegerField("encoded skip fraction"));
            this.Fields.Add(new CharIntegerField("encoded gain:dB"));
            this.Fields.Add(new CharIntegerField("permutation info index"));
            this.Fields.Add(new ShortIntegerField("language neutral time:ms"));
            this.Fields.Add(new LongIntegerField("sample size"));
            this.Fields.Add(new ShortBlockIndexField("first chunk"));
            this.Fields.Add(new ShortIntegerField("chunk count"));
        }
        /// <summary>
        /// Gets and returns the name of the sound_gestalt_permutations_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "sound_gestalt_permutations_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the sound_gestalt_permutations_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "sound_gestalt_permutations_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the sound_gestalt_permutations_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 32767;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the sound_gestalt_permutations_block tag block.
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