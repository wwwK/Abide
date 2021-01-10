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
    /// Represents the generated character_engage_block tag block.
    /// </summary>
    internal sealed class CharacterEngageBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterEngageBlock"/> class.
        /// </summary>
        public CharacterEngageBlock()
        {
            this.Fields.Add(new LongFlagsField("flags", "engage perch", "fight constant movement", "flight fight constant movement"));
            this.Fields.Add(new RealField("Crouch danger threshold#When danger rises above the threshold, the actor crouches" +
                        ""));
            this.Fields.Add(new RealField("Stand danger threshold#When danger drops below this threshold, the actor can stan" +
                        "d again."));
            this.Fields.Add(new RealField("Fight danger move threshold#When danger goes above given level, this actor switch" +
                        "es firing positions"));
        }
        /// <summary>
        /// Gets and returns the name of the character_engage_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "character_engage_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the character_engage_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "character_engage_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the character_engage_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 3;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the character_engage_block tag block.
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
