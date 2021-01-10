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
    /// Represents the generated special_movement_block tag block.
    /// </summary>
    internal sealed class SpecialMovementBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpecialMovementBlock"/> class.
        /// </summary>
        public SpecialMovementBlock()
        {
            this.Fields.Add(new LongFlagsField("Special movement 1", "jump", "climb", "vault", "mount", "hoist", "wall jump", "n/a"));
        }
        /// <summary>
        /// Gets and returns the name of the special_movement_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "special_movement_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the special_movement_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "special_movement_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the special_movement_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the special_movement_block tag block.
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
