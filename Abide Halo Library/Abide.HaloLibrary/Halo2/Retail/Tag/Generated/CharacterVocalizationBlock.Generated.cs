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
    /// Represents the generated character_vocalization_block tag block.
    /// </summary>
    internal sealed class CharacterVocalizationBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterVocalizationBlock"/> class.
        /// </summary>
        public CharacterVocalizationBlock()
        {
            this.Fields.Add(new RealField("look comment time:s#How long does the player look at an AI before the AI responds" +
                        "?"));
            this.Fields.Add(new RealField("look long comment time:s#How long does the player look at the AI before he respon" +
                        "ds with his \'long look\' comment?"));
        }
        /// <summary>
        /// Gets and returns the name of the character_vocalization_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "character_vocalization_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the character_vocalization_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "character_vocalization_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the character_vocalization_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the character_vocalization_block tag block.
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
