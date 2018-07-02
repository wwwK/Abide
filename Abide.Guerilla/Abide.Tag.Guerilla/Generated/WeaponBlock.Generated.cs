//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Abide.Tag.Guerilla.Generated
{
    using Abide.Tag;
    
    /// <summary>
    /// Represents the generated weapon_block tag block.
    /// </summary>
    public sealed class WeaponBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WeaponBlock"/> class.
        /// </summary>
        public WeaponBlock()
        {
            this.Fields.Add(new ExplanationField("$$$ WEAPON $$$", "All weapons should have \'primary trigger\' and \'secondary trigger\' markers as appr" +
                        "opriate.\nBlurred permutations are called \'$primary-blur\' and \'$secondary-blur\'."));
            this.Fields.Add(new LongFlagsField("flags", "vertical heat display", "mutually exclusive triggers", "attacks automatically on bump", "must be readied", "doesn\'t count toward maximum", "aim assists only when zoomed", "prevents grenade throwing", "must be picked up", "holds triggers when dropped", "prevents melee attack", "detonates when dropped", "cannot fire at maximum age", "secondary trigger overrides grenades", "(OBSOLETE)does not depower active camo in multilplayer", "enables integrated night vision", "AIs use weapon melee damage", "forces no binoculars", "loop fp firing animation", "prevents sprinting", "cannot fire while boosting", "prevents driving", "prevents gunning", "can be dual wielded", "can only be dual wielded", "melee only", "cant fire if parent dead", "weapon ages with each kill", "weapon uses old dual fire error code", "primary trigger melee attacks", "cannot be used by player"));
            this.Fields.Add(new OldStringIdField(""));
            this.Fields.Add(new EnumField("secondary trigger mode", "normal", "slaved to primary", "inhibits primary", "loads alterate ammunition", "loads multiple primary ammunition"));
            this.Fields.Add(new ShortIntegerField("maximum alternate shots loaded#if the second trigger loads alternate ammunition, " +
                        "this is the maximum number of shots that can be loaded at a time"));
            this.Fields.Add(new RealField("turn on time#how long after being readied it takes this weapon to switch its \'tur" +
                        "ned_on\' attachment to 1.0"));
            this.Fields.Add(new ExplanationField("old obsolete export to functions", ""));
            this.Fields.Add(new RealField("ready time:seconds"));
            this.Fields.Add(new TagReferenceField("ready effect", "����"));
            this.Fields.Add(new TagReferenceField("ready damage effect", "jpt!"));
            this.Fields.Add(new ExplanationField("heat", ""));
            this.Fields.Add(new RealFractionField("heat recovery threshold:[0,1]#the heat value a weapon must return to before leavi" +
                        "ng the overheated state, once it has become overheated in the first place"));
            this.Fields.Add(new RealFractionField("overheated threshold:[0,1]#the heat value over which a weapon first becomes overh" +
                        "eated (should be greater than the heat recovery threshold)"));
            this.Fields.Add(new RealFractionField("heat detonation threshold:[0,1]#the heat value above which the weapon has a chanc" +
                        "e of exploding each time it is fired"));
            this.Fields.Add(new RealFractionField("heat detonation fraction:[0,1]#the percent chance (between 0.0 and 1.0) the weapo" +
                        "n will explode when fired over the heat detonation threshold"));
            this.Fields.Add(new RealFractionField("heat loss per second:[0,1]#the amount of heat lost each second when the weapon is" +
                        " not being fired"));
            this.Fields.Add(new RealFractionField("heat illumination:[0,1]#the amount of illumination given off when the weapon is o" +
                        "verheated"));
            this.Fields.Add(new RealFractionField("overheated heat loss per second:[0,1]#the amount of heat lost each second when th" +
                        "e weapon is not being fired"));
            this.Fields.Add(new TagReferenceField("overheated", "����"));
            this.Fields.Add(new TagReferenceField("overheated damage effect", "jpt!"));
            this.Fields.Add(new TagReferenceField("detonation", "����"));
            this.Fields.Add(new TagReferenceField("detonation damage effect", "jpt!"));
            this.Fields.Add(new TagReferenceField("player melee damage", "jpt!"));
            this.Fields.Add(new TagReferenceField("player melee response", "jpt!"));
            this.Fields.Add(new ExplanationField("melee aim assist", @"magnetism angle: the maximum angle that magnetism works at full strength
magnetism range: the maximum distance that magnetism works at full strength
throttle magnitude: additional throttle to apply towards target when melee-ing w/ magnetism
throttle minimum distance: minimum distance to target that throttle magnetism kicks in
throttle maximum adjustment angle: maximum angle throttle magnetism will have an effect, relative to the players movement throttle
"));
            this.Fields.Add(new StructField<MeleeAimAssistStructBlock>("melee aim assist"));
            this.Fields.Add(new ExplanationField("melee damage parameters", "damage pyramid angles: defines the frustum from the camera that the melee-attack " +
                        "uses to find targets\ndamage pyramid depth: how far the melee attack searches for" +
                        " a target"));
            this.Fields.Add(new StructField<MeleeDamageParametersStructBlock>("melee damage parameters"));
            this.Fields.Add(new CharEnumField("melee damage reporting type", "teh guardians!!1!!1!", "falling damage", "generic collision damage", "generic melee damage", "generic explosion", "magnum pistol", "plasma pistol", "needler", "smg", "plasma rifle", "battle rifle", "carbine", "shotgun", "sniper rifle", "beam rifle", "rocket launcher", "flak cannon", "brute shot", "disintegrator", "brute plasma rifle", "energy sword", "frag grenade", "plasma grenade", "flag melee damage", "bomb melee damage", "bomb explosion damage", "ball melee damage", "human turret", "plasma turret", "banshee", "ghost", "mongoose", "scorpion", "spectre driver", "spectre gunner", "warthog driver", "warthog gunner", "wraith", "tank", "sentinel beam", "sentinel rpg", "teleporter"));
            this.Fields.Add(new PadField("", 1));
            this.Fields.Add(new ExplanationField("zoom", ""));
            this.Fields.Add(new ShortIntegerField("magnification levels#the number of magnification levels this weapon allows"));
            this.Fields.Add(new RealBoundsField("magnification range"));
            this.Fields.Add(new ExplanationField("weapon aim assist", ""));
            this.Fields.Add(new StructField<AimAssistStructBlock>("weapon aim assist"));
            this.Fields.Add(new ExplanationField("movement", ""));
            this.Fields.Add(new EnumField("movement penalized", "always", "when zoomed", "when zoomed or reloading"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new RealFractionField("forward movement penalty#percent slowdown to forward movement for units carrying " +
                        "this weapon"));
            this.Fields.Add(new RealFractionField("sideways movement penalty#percent slowdown to sideways and backward movement for " +
                        "units carrying this weapon"));
            this.Fields.Add(new ExplanationField("AI targeting parameters", ""));
            this.Fields.Add(new RealField("AI scariness"));
            this.Fields.Add(new ExplanationField("miscellaneous", ""));
            this.Fields.Add(new RealField("weapon power-on time:seconds"));
            this.Fields.Add(new RealField("weapon power-off time:seconds"));
            this.Fields.Add(new TagReferenceField("weapon power-on effect", "����"));
            this.Fields.Add(new TagReferenceField("weapon power-off effect", "����"));
            this.Fields.Add(new RealField("age heat recovery penalty#how much the weapon\'s heat recovery is penalized as it " +
                        "ages"));
            this.Fields.Add(new RealField("age rate of fire penalty#how much the weapon\'s rate of fire is penalized as it ag" +
                        "es"));
            this.Fields.Add(new RealFractionField("age misfire start:[0,1]#the age threshold when the weapon begins to misfire"));
            this.Fields.Add(new RealFractionField("age misfire chance:[0,1]#at age 1.0, the misfire chance per shot"));
            this.Fields.Add(new TagReferenceField("pickup sound", "snd!"));
            this.Fields.Add(new TagReferenceField("zoom-in sound", "snd!"));
            this.Fields.Add(new TagReferenceField("zoom-out sound", "snd!"));
            this.Fields.Add(new RealField("active camo ding#how much to decrease active camo when a round is fired"));
            this.Fields.Add(new RealField("active camo regrowth rate#how fast to increase active camo (per tick) when a roun" +
                        "d is fired"));
            this.Fields.Add(new StringIdField("handle node#the node that get\'s attached to the unit\'s hand"));
            this.Fields.Add(new ExplanationField("weapon labels", ""));
            this.Fields.Add(new StringIdField("weapon class"));
            this.Fields.Add(new StringIdField("weapon name"));
            this.Fields.Add(new EnumField("multiplayer weapon type", "none", "ctf flag", "oddball ball", "headhunter head", "juggernaut powerup"));
            this.Fields.Add(new ExplanationField("more miscellaneous", ""));
            this.Fields.Add(new EnumField("weapon type", "undefined", "shotgun", "needler", "plasma pistol", "plasma rifle", "rocket launcher"));
            this.Fields.Add(new StructField<WeaponTrackingStructBlock>("tracking"));
            this.Fields.Add(new StructField<WeaponInterfaceStructBlock>("player interface"));
            this.Fields.Add(new BlockField<PredictedResourceBlock>("predicted resources", 2048));
            this.Fields.Add(new BlockField<Magazines>("magazines", 2));
            this.Fields.Add(new BlockField<WeaponTriggers>("new triggers", 2));
            this.Fields.Add(new BlockField<WeaponBarrels>("barrels", 2));
            this.Fields.Add(new PadField("", 8));
            this.Fields.Add(new ExplanationField("first-person movement control", ""));
            this.Fields.Add(new RealField("max movement acceleration"));
            this.Fields.Add(new RealField("max movement velocity"));
            this.Fields.Add(new RealField("max turning acceleration"));
            this.Fields.Add(new RealField("max turning velocity"));
            this.Fields.Add(new TagReferenceField("deployed vehicle", "vehi"));
            this.Fields.Add(new TagReferenceField("age effect", "effe"));
            this.Fields.Add(new TagReferenceField("aged weapon", "weap"));
            this.Fields.Add(new RealVector3dField("first person weapon offset"));
            this.Fields.Add(new RealVector2dField("first person scope size"));
        }
        /// <summary>
        /// Gets and returns the name of the weapon_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "weapon_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the weapon_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "weapon";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the weapon_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the weapon_block tag block.
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
