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
    /// Represents the generated unit_seat_block tag block.
    /// </summary>
    public sealed class UnitSeatBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnitSeatBlock"/> class.
        /// </summary>
        public UnitSeatBlock()
        {
            this.Fields.Add(new LongFlagsField("flags", "invisible", "locked", "driver", "gunner", "third person camera", "allows weapons", "third person on enter", "first person camera slaved to gun.", "allow vehicle communication animations", "not valid without driver", "allow AI noncombatants", "boarding seat", "ai firing disabled by max acceleration", "boarding enters seat", "boarding need any passenger", "controls open and close", "invalid for player", "invalid for non-player", "gunner (player only)", "invisible under major damage"));
            this.Fields.Add(new OldStringIdField("label^"));
            this.Fields.Add(new OldStringIdField("marker name"));
            this.Fields.Add(new StringIdField("entry marker(s) name"));
            this.Fields.Add(new StringIdField("boarding grenade marker"));
            this.Fields.Add(new StringIdField("boarding grenade string"));
            this.Fields.Add(new StringIdField("boarding melee string"));
            this.Fields.Add(new RealFractionField("ping scale#nathan is too lazy to make pings for each seat."));
            this.Fields.Add(new RealField("turnover time:seconds#how much time it takes to evict a rider from a flipped vehi" +
                        "cle"));
            this.Fields.Add(new StructField<UnitSeatAccelerationStructBlock>("acceleration"));
            this.Fields.Add(new RealField("AI scariness"));
            this.Fields.Add(new EnumField("ai seat type", "NONE", "passenger", "gunner", "small cargo", "large cargo", "driver"));
            this.Fields.Add(new ShortBlockIndexField("boarding seat"));
            this.Fields.Add(new RealFractionField("listener interpolation factor#how far to interpolate listener position from camer" +
                        "a to occupant\'s head"));
            this.Fields.Add(new ExplanationField("speed dependant turn rates", @"when the unit velocity is 0, the yaw/pitch rates are the left values
at [max speed reference], the yaw/pitch rates are the right values.
the max speed reference is what the code uses to generate a clamped speed from 0..1
the exponent controls how midrange speeds are interpreted."));
            this.Fields.Add(new RealBoundsField("yaw rate bounds:degrees per second"));
            this.Fields.Add(new RealBoundsField("pitch rate bounds:degrees per second"));
            this.Fields.Add(new RealField("min speed reference"));
            this.Fields.Add(new RealField("max speed reference"));
            this.Fields.Add(new RealField("speed exponent"));
            this.Fields.Add(new ExplanationField("camera fields", ""));
            this.Fields.Add(new StructField<UnitCameraStructBlock>("unit camera"));
            this.Fields.Add(new BlockField<UnitHudReferenceBlock>("unit hud interface", 2));
            this.Fields.Add(new StringIdField("enter seat string"));
            this.Fields.Add(new AngleField("yaw minimum"));
            this.Fields.Add(new AngleField("yaw maximum"));
            this.Fields.Add(new TagReferenceField("built-in gunner", 1667785074));
            this.Fields.Add(new ExplanationField("entry fields", "note: the entry radius shouldn\'t exceed 3 world units, \nas that is as far as the " +
                        "player will search for a vehicle\nto enter."));
            this.Fields.Add(new RealField("entry radius#how close to the entry marker a unit must be"));
            this.Fields.Add(new AngleField("entry marker cone angle#angle from marker forward the unit must be"));
            this.Fields.Add(new AngleField("entry marker facing angle#angle from unit facing the marker must be"));
            this.Fields.Add(new RealField("maximum relative velocity"));
            this.Fields.Add(new StringIdField("invisible seat region"));
            this.Fields.Add(new LongIntegerField("runtime invisible seat region index*"));
        }
        /// <summary>
        /// Gets and returns the name of the unit_seat_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "unit_seat_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the unit_seat_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "unit_seat_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the unit_seat_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 32;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the unit_seat_block tag block.
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
