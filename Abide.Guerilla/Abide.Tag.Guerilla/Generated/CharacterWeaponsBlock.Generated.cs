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
    /// Represents the generated character_weapons_block tag block.
    /// </summary>
    public sealed class CharacterWeaponsBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterWeaponsBlock"/> class.
        /// </summary>
        public CharacterWeaponsBlock()
        {
            this.Fields.Add(new LongFlagsField("weapons flags", "bursting inhibits movement", "must crouch to shoot", "use extended safe-to-save range"));
            this.Fields.Add(new TagReferenceField("weapon^", "weap"));
            this.Fields.Add(new ExplanationField("Combat ranges", ""));
            this.Fields.Add(new RealField("maximum firing range:world units#we can only fire our weapon at targets within th" +
                        "is distance"));
            this.Fields.Add(new RealField("minimum firing range#weapon will not be fired at target closer than given distanc" +
                        "e"));
            this.Fields.Add(new RealBoundsField("normal combat range:world units"));
            this.Fields.Add(new RealField("bombardment range#we offset our burst targets randomly by this range when firing " +
                        "at non-visible enemies (zero = never)"));
            this.Fields.Add(new RealField("Max special target distance:world units#Specific target regions on a vehicle or u" +
                        "nit will be fired upon only under the given distance"));
            this.Fields.Add(new RealBoundsField("timid combat range:world units"));
            this.Fields.Add(new RealBoundsField("aggressive combat range:world units"));
            this.Fields.Add(new ExplanationField("Ballistic Firing", ""));
            this.Fields.Add(new RealField("super-ballistic range#we try to aim our shots super-ballistically if target is ou" +
                        "tside this range (zero = never)"));
            this.Fields.Add(new RealBoundsField("Ballistic firing bounds:world units#At the min range, the min ballistic fraction " +
                        "is used, at the max, the max ballistic fraction is used"));
            this.Fields.Add(new RealBoundsField("Ballistic fraction bounds:[0-1]#Controls speed and degree of arc. 0 = high, slow," +
                        " 1 = low, fast"));
            this.Fields.Add(new ExplanationField("Behavior", ""));
            this.Fields.Add(new RealBoundsField("first burst delay time:seconds"));
            this.Fields.Add(new RealField("surprise delay time:seconds"));
            this.Fields.Add(new RealField("surprise fire-wildly time:seconds"));
            this.Fields.Add(new RealField("death fire-wildly chance:[0,1]"));
            this.Fields.Add(new RealField("death fire-wildly time:seconds"));
            this.Fields.Add(new RealVector3dField("custom stand gun offset#custom standing gun offset for overriding the default in " +
                        "the base actor"));
            this.Fields.Add(new RealVector3dField("custom crouch gun offset#custom crouching gun offset for overriding the default i" +
                        "n the base actor"));
            this.Fields.Add(new ExplanationField("special-case firing properties", ""));
            this.Fields.Add(new EnumField("special-fire mode#the type of special weapon fire that we can use", "none", "overcharge", "secondary trigger"));
            this.Fields.Add(new EnumField("special-fire situation#when we will decide to use our special weapon fire mode", "never", "enemy visible", "enemy out of sight", "strafing"));
            this.Fields.Add(new RealField("special-fire chance:[0,1]#how likely we are to use our special weapon fire mode"));
            this.Fields.Add(new RealField("special-fire delay:seconds#how long we must wait between uses of our special weap" +
                        "on fire mode"));
            this.Fields.Add(new RealField("special damage modifier:[0,1]#damage modifier for special weapon fire (applied in" +
                        " addition to the normal damage modifier. zero = no change)"));
            this.Fields.Add(new AngleField("special projectile error:degrees#projectile error angle for special weapon fire (" +
                        "applied in addition to the normal error)"));
            this.Fields.Add(new ExplanationField("Weapon drop when killed", ""));
            this.Fields.Add(new RealBoundsField("drop weapon loaded#amount of ammo loaded into the weapon that we drop (in fractio" +
                        "ns of a clip, e.g. 0.3 to 0.5)"));
            this.Fields.Add(new ShortBoundsField("drop weapon ammo#total number of rounds in the weapon that we drop (ignored for e" +
                        "nergy weapons)"));
            this.Fields.Add(new ExplanationField("Accuracy", @"Parameters control how accuracy changes over the duration of a series of bursts
Accuracy is an analog value between 0 and 1. At zero, the parameters of the first
firing-pattern block is used. At 1, the parameters in the second block is used. In
between, all the values are linearly interpolated"));
            this.Fields.Add(new RealBoundsField("normal accuracy bounds#Indicates starting and ending accuracies at normal difficu" +
                        "lty"));
            this.Fields.Add(new RealField("normal accuracy time#The amount of time it takes the accuracy to go from starting" +
                        " to ending"));
            this.Fields.Add(new RealBoundsField("heroic accuracy bounds#Indicates starting and ending accuracies at heroic difficu" +
                        "lty"));
            this.Fields.Add(new RealField("heroic accuracy time#The amount of time it takes the accuracy to go from starting" +
                        " to ending"));
            this.Fields.Add(new RealBoundsField("legendary accuracy bounds#Indicates starting and ending accuracies at legendary d" +
                        "ifficulty"));
            this.Fields.Add(new RealField("legendary accuracy time#The amount of time it takes the accuracy to go from start" +
                        "ing to ending"));
            this.Fields.Add(new BlockField<CharacterFiringPatternBlock>("firing patterns", 2));
            this.Fields.Add(new TagReferenceField("weapon melee damage", "jpt!"));
        }
        /// <summary>
        /// Gets and returns the name of the character_weapons_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "character_weapons_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the character_weapons_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "character_weapons_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the character_weapons_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 100;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the character_weapons_block tag block.
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
