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
    /// Represents the generated global_damage_section_block tag block.
    /// </summary>
    internal sealed class GlobalDamageSectionBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalDamageSectionBlock"/> class.
        /// </summary>
        public GlobalDamageSectionBlock()
        {
            this.Fields.Add(new StringIdField("name^"));
            this.Fields.Add(new ExplanationField("damage section flags", "* absorbs body damage: damage to this section does not count against body vitalit" +
                        "y\n* headshottable: takes extra headshot damage when shot\n* ignores shields: dama" +
                        "ge to this section bypasses shields"));
            this.Fields.Add(new LongFlagsField("flags", "absorbs body damage", "takes full dmg when object dies", "cannot die with riders", "takes full dmg when obj dstryd", "restored on ressurection", "unused", "unused", "heatshottable", "ignores shields"));
            this.Fields.Add(new RealFractionField("vitality percentage:[0.1]#percentage of total object vitality"));
            this.Fields.Add(new BlockField<InstantaneousDamageRepsonseBlock>("instant responses", 16));
            this.Fields.Add(new BlockField<GNullBlock>("", 0));
            this.Fields.Add(new BlockField<GNullBlock>("", 0));
            this.Fields.Add(new RealField("stun time:seconds"));
            this.Fields.Add(new RealField("recharge time:seconds"));
            this.Fields.Add(new PadField("", 4));
            this.Fields.Add(new StringIdField("resurrection restored region name"));
            this.Fields.Add(new PadField("", 4));
        }
        /// <summary>
        /// Gets and returns the name of the global_damage_section_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "global_damage_section_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the global_damage_section_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "global_damage_section_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the global_damage_section_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 16;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the global_damage_section_block tag block.
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
