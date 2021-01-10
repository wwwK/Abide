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
    /// Represents the generated character_movement_block tag block.
    /// </summary>
    internal sealed class CharacterMovementBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterMovementBlock"/> class.
        /// </summary>
        public CharacterMovementBlock()
        {
            this.Fields.Add(new LongFlagsField("movement flags", "danger crouch allow movement", "no side-step", "prefer to combar near friends", "hop (to cover path segements)", "perch", "has flying mode", "disallow crouch"));
            this.Fields.Add(new RealField("pathfinding radius"));
            this.Fields.Add(new RealField("destination radius"));
            this.Fields.Add(new RealField("dive grenade chance"));
            this.Fields.Add(new EnumField("obstacle leap min size", "none", "tiny", "small", "medium", "large", "huge", "immobile"));
            this.Fields.Add(new EnumField("obstacle leap max size", "none", "tiny", "small", "medium", "large", "huge", "immobile"));
            this.Fields.Add(new EnumField("obstacle ignore size", "none", "tiny", "small", "medium", "large", "huge", "immobile"));
            this.Fields.Add(new EnumField("obstacle smashable size", "none", "tiny", "small", "medium", "large", "huge", "immobile"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new EnumField("jump height", "NONE", "down", "step", "crouch", "stand", "storey", "tower", "infinite"));
            this.Fields.Add(new LongFlagsField("movement hints", "vault step", "vault crouch", "", "", "", "mount step", "mount crouch", "mount stand", "", "", "", "hoist crouch", "hoist stand", "", "", ""));
            this.Fields.Add(new RealField("throttle scale"));
        }
        /// <summary>
        /// Gets and returns the name of the character_movement_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "character_movement_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the character_movement_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "character_movement_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the character_movement_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the character_movement_block tag block.
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
