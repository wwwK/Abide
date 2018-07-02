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
    /// Represents the generated sound_references_block tag block.
    /// </summary>
    public sealed class SoundReferencesBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SoundReferencesBlock"/> class.
        /// </summary>
        public SoundReferencesBlock()
        {
            this.Fields.Add(new WordFlagsField("flags", "new vocalization"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new StringIdField("vocalization^"));
            this.Fields.Add(new TagReferenceField("sound", "snd!"));
        }
        /// <summary>
        /// Gets and returns the name of the sound_references_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "sound_references_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the sound_references_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "sound_references_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the sound_references_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 500;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the sound_references_block tag block.
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
