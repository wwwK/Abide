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
    /// Represents the generated mission_dialogue_variants_block tag block.
    /// </summary>
    public sealed class MissionDialogueVariantsBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MissionDialogueVariantsBlock"/> class.
        /// </summary>
        public MissionDialogueVariantsBlock()
        {
            this.Fields.Add(new StringIdField("variant designation^#3-letter designation for the character"));
            this.Fields.Add(new TagReferenceField("sound", 1936614433));
            this.Fields.Add(new StringIdField("sound effect"));
        }
        /// <summary>
        /// Gets and returns the name of the mission_dialogue_variants_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "mission_dialogue_variants_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the mission_dialogue_variants_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "mission_dialogue_variants_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the mission_dialogue_variants_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 10;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the mission_dialogue_variants_block tag block.
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
