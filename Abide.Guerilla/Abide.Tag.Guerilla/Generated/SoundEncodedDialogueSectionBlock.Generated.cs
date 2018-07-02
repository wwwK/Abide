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
    /// Represents the generated sound_encoded_dialogue_section_block tag block.
    /// </summary>
    public sealed class SoundEncodedDialogueSectionBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SoundEncodedDialogueSectionBlock"/> class.
        /// </summary>
        public SoundEncodedDialogueSectionBlock()
        {
            this.Fields.Add(new DataField("encoded data", 1, 4));
            this.Fields.Add(new BlockField<SoundPermutationDialogueInfoBlock>("sound dialogue info", 288));
        }
        /// <summary>
        /// Gets and returns the name of the sound_encoded_dialogue_section_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "sound_encoded_dialogue_section_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the sound_encoded_dialogue_section_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "sound_encoded_dialogue_section_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the sound_encoded_dialogue_section_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the sound_encoded_dialogue_section_block tag block.
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
