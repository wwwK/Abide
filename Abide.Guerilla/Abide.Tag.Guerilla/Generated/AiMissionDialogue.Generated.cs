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
    using HaloTag = Abide.HaloLibrary.TagFourCc;
    
    /// <summary>
    /// Represents the generated ai_mission_dialogue (mdlg) tag group.
    /// </summary>
    public class AiMissionDialogue : Group
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AiMissionDialogue"/> class.
        /// </summary>
        public AiMissionDialogue()
        {
            // Add tag block to list.
            this.TagBlocks.Add(new AiMissionDialogueBlock());
        }
        /// <summary>
        /// Gets and returns the name of the ai_mission_dialogue tag group.
        /// </summary>
        public override string Name
        {
            get
            {
                return "ai_mission_dialogue";
            }
        }
        /// <summary>
        /// Gets and returns the group tag of the ai_mission_dialogue tag group.
        /// </summary>
        public override HaloTag GroupTag
        {
            get
            {
                return "mdlg";
            }
        }
    }
}
