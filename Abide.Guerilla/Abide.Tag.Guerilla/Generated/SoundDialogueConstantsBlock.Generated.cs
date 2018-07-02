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
    /// Represents the generated sound_dialogue_constants_block tag block.
    /// </summary>
    public sealed class SoundDialogueConstantsBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SoundDialogueConstantsBlock"/> class.
        /// </summary>
        public SoundDialogueConstantsBlock()
        {
            this.Fields.Add(new ExplanationField("named playing fractions", "these values correspond to the named play fractions in the dialogue editor (It\'s " +
                        "really skip fractions, but who cares?)"));
            this.Fields.Add(new RealField("almost never"));
            this.Fields.Add(new RealField("rarely"));
            this.Fields.Add(new RealField("somewhat"));
            this.Fields.Add(new RealField("often"));
            this.Fields.Add(new PadField("", 24));
        }
        /// <summary>
        /// Gets and returns the name of the sound_dialogue_constants_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "sound_dialogue_constants_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the sound_dialogue_constants_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "sound_dialogue_constants";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the sound_dialogue_constants_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the sound_dialogue_constants_block tag block.
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
