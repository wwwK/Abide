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
    /// Represents the generated character_cover_block tag block.
    /// </summary>
    public sealed class CharacterCoverBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterCoverBlock"/> class.
        /// </summary>
        public CharacterCoverBlock()
        {
            this.Fields.Add(new LongFlagsField("cover flags", "Flag1"));
            this.Fields.Add(new RealBoundsField("hide behind cover time:seconds#how long we stay behind cover after seeking cover"));
            this.Fields.Add(new RealField("Cover vitality threshold#When vitality drops below this level, possibly trigger a" +
                        " cover"));
            this.Fields.Add(new RealField("Cover shield fraction#trigger cover when shield drops below this fraction (low sh" +
                        "ield cover impulse must be enabled)"));
            this.Fields.Add(new RealField("Cover check delay#amount of time I will wait before trying again after covering"));
            this.Fields.Add(new RealField("Emerge from cover when shield fraction reaches threshold#Emerge from cover when s" +
                        "hield fraction reaches threshold"));
            this.Fields.Add(new RealField("Cover danger threshold#Danger must be this high to cover. At a danger level of \'d" +
                        "anger threshold\', the chance of seeking cover is the cover chance lower bound (b" +
                        "elow)"));
            this.Fields.Add(new RealField("Danger upper threshold#At or above danger level of upper threshold, the chance of" +
                        " seeking cover is the cover chance upper bound (below)"));
            this.Fields.Add(new ExplanationField("Cover chance", @"The Bounds on the chance of seeking cover.
The lower bound is valid when the danger is at 'danger threshold'
The upper bound is valid when the danger is at or above 'danger upper threshold'.
It is interpolated linearly everywhere in between.
 All chances are expressed as 'chance of triggering cover in a 1 second period'."));
            this.Fields.Add(new RealBoundsField("Cover chance#Bounds on the chances of seeking cover."));
            this.Fields.Add(new RealField("Proximity self-preserve:wus#When the proximity_self_preservation impulse is enabl" +
                        "ed, triggers self-preservation when target within this distance"));
            this.Fields.Add(new RealField("Disallow cover distance:world units#Disallow covering from visible target under t" +
                        "he given distance away"));
            this.Fields.Add(new RealField("proximity melee distance#When self preserving from a target less than given dista" +
                        "nce, causes melee attack (assuming proximity_melee_impulse is enabled)"));
            this.Fields.Add(new RealField("unreachable enemy danger threshold#When danger from an unreachable enemy surpasse" +
                        "s threshold, actor cover (assuming unreachable_enemy_cover impulse is enabled)"));
            this.Fields.Add(new RealField("scary target threshold#When target is aware of me and surpasses the given scarine" +
                        "ss, self-preserve (scary_target_cover_impulse)"));
        }
        /// <summary>
        /// Gets and returns the name of the character_cover_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "character_cover_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the character_cover_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "character_cover_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the character_cover_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 3;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the character_cover_block tag block.
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
