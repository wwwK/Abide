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
    /// Represents the generated projectile_block tag block.
    /// </summary>
    public sealed class ProjectileBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectileBlock"/> class.
        /// </summary>
        public ProjectileBlock()
        {
            this.Fields.Add(new ExplanationField("$$$ PROJECTILE $$$", ""));
            this.Fields.Add(new LongFlagsField("flags", "oriented along velocity", "AI must use ballistic aiming", "detonation max time if attached", "has super combining explosion", "damage scales based on distance", "travels instantaneously", "steering adjusts orientation", "don\'t noise up steering", "can track behind itself", "ROBOTRON STEERING!", "faster when owned by player"));
            this.Fields.Add(new EnumField("detonation timer starts", "immediately", "after first bounce", "when at rest", "after first bounce off any surface"));
            this.Fields.Add(new EnumField("impact noise", "silent", "medium", "loud", "shout", "quiet"));
            this.Fields.Add(new RealField("AI perception radius:world units"));
            this.Fields.Add(new RealField("collision radius:world units"));
            this.Fields.Add(new ExplanationField("detonation", ""));
            this.Fields.Add(new RealField("arming time:seconds#won\'t detonate before this time elapses"));
            this.Fields.Add(new RealField("danger radius:world units"));
            this.Fields.Add(new RealBoundsField("timer:seconds#detonation countdown (zero is untimed)"));
            this.Fields.Add(new RealField("minimum velocity:world units per second#detonates when slowed below this velocity" +
                        ""));
            this.Fields.Add(new RealField("maximum range:world units#detonates after travelling this distance"));
            this.Fields.Add(new EnumField("detonation noise", "silent", "medium", "loud", "shout", "quiet"));
            this.Fields.Add(new ShortIntegerField("super det. projectile count"));
            this.Fields.Add(new TagReferenceField("detonation started", 1701209701));
            this.Fields.Add(new TagReferenceField("detonation effect (airborne)", 1701209701));
            this.Fields.Add(new TagReferenceField("detonation effect (ground)", 1701209701));
            this.Fields.Add(new TagReferenceField("detonation damage", 1785754657));
            this.Fields.Add(new TagReferenceField("attached detonation damage", 1785754657));
            this.Fields.Add(new TagReferenceField("super detonation", 1701209701));
            this.Fields.Add(new StructField<SuperDetonationDamageStructBlock>("your momma!"));
            this.Fields.Add(new TagReferenceField("detonation sound", 1936614433));
            this.Fields.Add(new CharEnumField("damage reporting type", "teh guardians!!1!!1!", "falling damage", "generic collision damage", "generic melee damage", "generic explosion", "magnum pistol", "plasma pistol", "needler", "smg", "plasma rifle", "battle rifle", "carbine", "shotgun", "sniper rifle", "beam rifle", "rocket launcher", "flak cannon", "brute shot", "disintegrator", "brute plasma rifle", "energy sword", "frag grenade", "plasma grenade", "flag melee damage", "bomb melee damage", "bomb explosion damage", "ball melee damage", "human turret", "plasma turret", "banshee", "ghost", "mongoose", "scorpion", "spectre driver", "spectre gunner", "warthog driver", "warthog gunner", "wraith", "tank", "sentinel beam", "sentinel rpg", "teleporter"));
            this.Fields.Add(new PadField("", 3));
            this.Fields.Add(new TagReferenceField("super attached detonation damage", 1785754657));
            this.Fields.Add(new RealField("material effect radius#radius within we will generate material effects"));
            this.Fields.Add(new ExplanationField("flyby/impact", ""));
            this.Fields.Add(new TagReferenceField("flyby sound", 1936614433));
            this.Fields.Add(new TagReferenceField("impact effect", 1701209701));
            this.Fields.Add(new TagReferenceField("impact damage", 1785754657));
            this.Fields.Add(new ExplanationField("boarding fields", ""));
            this.Fields.Add(new RealField("boarding detonation time"));
            this.Fields.Add(new TagReferenceField("boarding detonation damage", 1785754657));
            this.Fields.Add(new TagReferenceField("boarding attached detonation damage", 1785754657));
            this.Fields.Add(new ExplanationField("physics", ""));
            this.Fields.Add(new RealField("air gravity scale#the proportion of normal gravity applied to the projectile when" +
                        " in air."));
            this.Fields.Add(new RealBoundsField("air damage range:world units#the range over which damage is scaled when the proje" +
                        "ctile is in air."));
            this.Fields.Add(new RealField("water gravity scale#the proportion of normal gravity applied to the projectile wh" +
                        "en in water."));
            this.Fields.Add(new RealBoundsField("water damage range:world units#the range over which damage is scaled when the pro" +
                        "jectile is in water."));
            this.Fields.Add(new RealField("initial velocity:world units per second#bullet\'s velocity when inflicting maximum" +
                        " damage"));
            this.Fields.Add(new RealField("final velocity:world units per second#bullet\'s velocity when inflicting minimum d" +
                        "amage"));
            this.Fields.Add(new StructField<AngularVelocityLowerBoundStructBlock>("blah"));
            this.Fields.Add(new AngleField("guided angular velocity (upper):degrees per second"));
            this.Fields.Add(new RealBoundsField("acceleration range:world units#what distance range the projectile goes from initi" +
                        "al velocity to final velocity"));
            this.Fields.Add(new PadField("", 4));
            this.Fields.Add(new RealFractionField("targeted leading fraction"));
            this.Fields.Add(new BlockField<ProjectileMaterialResponseBlock>("material responses", 200));
        }
        /// <summary>
        /// Gets and returns the name of the projectile_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "projectile_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the projectile_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "projectile";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the projectile_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the projectile_block tag block.
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
