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
    /// Represents the generated unit_hud_sound_block tag block.
    /// </summary>
    internal sealed class UnitHudSoundBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnitHudSoundBlock"/> class.
        /// </summary>
        public UnitHudSoundBlock()
        {
            this.Fields.Add(new TagReferenceField("sound^", -3));
            this.Fields.Add(new LongFlagsField("latched to", "shield recharging", "shield damaged", "shield low", "shield empty", "health low", "health empty", "health minor damage", "health major damage"));
            this.Fields.Add(new RealField("scale"));
            this.Fields.Add(new PadField("", 32));
        }
        /// <summary>
        /// Gets and returns the name of the unit_hud_sound_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "unit_hud_sound_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the unit_hud_sound_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "unit_hud_sound_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the unit_hud_sound_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 12;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the unit_hud_sound_block tag block.
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
