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
    using System;
    using Abide.HaloLibrary;
    using Abide.Tag;
    
    /// <summary>
    /// Represents the generated sound_dialogue_constants (spk!) tag group.
    /// </summary>
    public class SoundDialogueConstants : Group
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SoundDialogueConstants"/> class.
        /// </summary>
        public SoundDialogueConstants()
        {
            // Add tag block to list.
            this.TagBlocks.Add(new SoundDialogueConstantsBlock());
        }
        /// <summary>
        /// Gets and returns the name of the sound_dialogue_constants tag group.
        /// </summary>
        public override string GroupName
        {
            get
            {
                return "sound_dialogue_constants";
            }
        }
        /// <summary>
        /// Gets and returns the group tag of the sound_dialogue_constants tag group.
        /// </summary>
        public override TagFourCc GroupTag
        {
            get
            {
                return "spk!";
            }
        }
    }
}
