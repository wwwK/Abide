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
    /// Represents the generated user_hint_climb_block tag block.
    /// </summary>
    internal sealed class UserHintClimbBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserHintClimbBlock"/> class.
        /// </summary>
        public UserHintClimbBlock()
        {
            this.Fields.Add(new WordFlagsField("Flags", "bidirectional", "closed"));
            this.Fields.Add(new ShortBlockIndexField("geometry index*"));
        }
        /// <summary>
        /// Gets and returns the name of the user_hint_climb_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "user_hint_climb_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the user_hint_climb_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "user_hint_climb_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the user_hint_climb_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 200;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the user_hint_climb_block tag block.
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
