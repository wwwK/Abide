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
    /// Represents the generated character_retreat_block tag block.
    /// </summary>
    internal sealed class CharacterRetreatBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterRetreatBlock"/> class.
        /// </summary>
        public CharacterRetreatBlock()
        {
            this.Fields.Add(new LongFlagsField("Retreat flags", "Zig-zag when fleeing", "Unused1"));
            this.Fields.Add(new RealField("Shield threshold#When shield vitality drops below given amount, retreat is trigge" +
                        "red by low_shield_retreat_impulse"));
            this.Fields.Add(new RealField("Scary target threshold#When confronting an enemy of over the given scariness, ret" +
                        "reat is triggered by scary_target_retreat_impulse"));
            this.Fields.Add(new RealField("Danger threshold#When perceived danger rises above the given threshold, retreat i" +
                        "s triggered by danger_retreat_impulse"));
            this.Fields.Add(new RealField("Proximity threshold#When enemy closer than given threshold, retreat is triggered " +
                        "by proximity_retreat_impulse"));
            this.Fields.Add(new RealBoundsField("min/max forced cower time bounds#actor cowers for at least the given amount of ti" +
                        "me"));
            this.Fields.Add(new RealBoundsField("min/max cower timeout bounds#actor times out of cower after the given amount of t" +
                        "ime"));
            this.Fields.Add(new RealField("proximity ambush threshold#If target reaches is within the given proximity, an am" +
                        "bush is triggered by the proximity ambush impulse"));
            this.Fields.Add(new RealField("awareness ambush threshold#If target is less than threshold (0-1) aware of me, an" +
                        " ambush is triggered by the vulnerable enemy ambush impulse"));
            this.Fields.Add(new RealField("leader dead retreat chance#If leader-dead-retreat-impulse is active, gives the ch" +
                        "ance that we will flee when our leader dies within 4 world units of us"));
            this.Fields.Add(new RealField("peer dead retreat chance#If peer-dead-retreat-impulse is active, gives the chance" +
                        " that we will flee when one of our peers (friend of the same race) dies within 4" +
                        " world units of us"));
            this.Fields.Add(new RealField("second peer dead retreat chance#If peer-dead-retreat-impulse is active, gives the" +
                        " chance that we will flee when a second peer (friend of the same race) dies with" +
                        "in 4 world units of us"));
            this.Fields.Add(new AngleField("zig-zag angle:degrees#The angle from the intended destination direction that a zi" +
                        "g-zag will cause"));
            this.Fields.Add(new RealField("zig-zag period:seconds#How long it takes to zig left and then zag right."));
            this.Fields.Add(new RealField("retreat grenade chance#The likelihood of throwing down a grenade to cover our ret" +
                        "reat"));
            this.Fields.Add(new TagReferenceField("backup weapon#If I want to flee and I don\'t have flee animations with my current " +
                        "weapon, throw it away and try a ...", 2003132784));
        }
        /// <summary>
        /// Gets and returns the name of the character_retreat_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "character_retreat_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the character_retreat_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "character_retreat_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the character_retreat_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 3;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the character_retreat_block tag block.
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
