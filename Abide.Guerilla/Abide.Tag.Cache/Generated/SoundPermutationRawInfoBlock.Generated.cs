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
    /// Represents the generated sound_permutation_raw_info_block tag block.
    /// </summary>
    public sealed class SoundPermutationRawInfoBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SoundPermutationRawInfoBlock"/> class.
        /// </summary>
        public SoundPermutationRawInfoBlock()
        {
            this.Fields.Add(new StringIdField("skip fraction name"));
            this.Fields.Add(new DataField("", 1));
            this.Fields.Add(new DataField("", 1));
            this.Fields.Add(new DataField("", 1));
            this.Fields.Add(new BlockField<SoundPermutationMarkerBlock>("", 65535));
            this.Fields.Add(new EnumField("compression*", "none (big endian)", "xbox adpcm", "ima adpcm", "none (little endian)", "wma"));
            this.Fields.Add(new CharEnumField("language*", "english", "japanese", "german", "french", "spanish", "italian", "korean", "chinese", "portuguese"));
            this.Fields.Add(new PadField("", 1));
        }
        /// <summary>
        /// Gets and returns the name of the sound_permutation_raw_info_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "sound_permutation_raw_info_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the sound_permutation_raw_info_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "sound_permutation_raw_info_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the sound_permutation_raw_info_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 18;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the sound_permutation_raw_info_block tag block.
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
