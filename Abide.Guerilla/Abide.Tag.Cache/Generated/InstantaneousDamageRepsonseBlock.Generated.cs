//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Abide.Tag.Cache.Generated
{
    using System;
    using Abide.HaloLibrary;
    using Abide.Tag;
    
    /// <summary>
    /// Represents the generated instantaneous_damage_repsonse_block tag block.
    /// </summary>
    public sealed class InstantaneousDamageRepsonseBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstantaneousDamageRepsonseBlock"/> class.
        /// </summary>
        public InstantaneousDamageRepsonseBlock()
        {
            this.Fields.Add(new EnumField("response type", "receives all damage", "receives area effect damage", "receives local damage"));
            this.Fields.Add(new ExplanationField("Constraint damage type", "* if you specify a constraint group name (see lower section of this block)\n  you " +
                        "can specify a constraint damage\n* loosening a constraint takes it out of the rig" +
                        "id state - activates it\n* destroying a constraint sets the attached body free"));
            this.Fields.Add(new EnumField("constraint damage type", "none", "destroy one of group", "destroy entire group", "loosen one of group", "loosen entire group"));
            this.Fields.Add(new ExplanationField("Damage response flags", @"* kills object: when the response fires the object dies regardless of its current health
* inhibits <x>: from halo 1 - disallows basic behaviors for a unit
* forces drop weapon: from halo 1 - makes the unit drop its current weapon
* kills weapon <x> trigger: destroys the <x> trigger on the unit's current weapon
* destroys object: when the response fires the object is destroyed"));
            this.Fields.Add(new LongFlagsField("flags", "kills object", "inhibits melee attack", "inhibits weapon attack", "inhibits walking", "forces drop weapon", "kills weapon primary trigger", "kills weapon secondary trigger", "destroys object", "damages weapon primary trigger", "damages weapon secondary trigger", "light damage left turn", "major damage left turn", "light damage right turn", "major damage right turn", "light damage engine", "major damage engine", "kills object (no player solo)", "causes detonation", "destroy all group constraints", "kills variant objects", "force unattached effects", "fires under threshold", "triggers special death", "only on special death", "only NOT on special death"));
            this.Fields.Add(new RealField("damage threshold#repsonse fires after crossing this threshold.  1=full health"));
            this.Fields.Add(new TagReferenceField("transition effect", 1701209701));
            this.Fields.Add(new StructField<InstantaneousResponseDamageEffectStructBlock>("damage effect"));
            this.Fields.Add(new StringIdField("region"));
            this.Fields.Add(new EnumField("new state", "default", "minor damage", "medium damage", "major damage", "destroyed"));
            this.Fields.Add(new ShortIntegerField("runtime region index*"));
            this.Fields.Add(new StringIdField("effect marker name"));
            this.Fields.Add(new StructField<InstantaneousResponseDamageEffectMarkerStructBlock>("damage effect marker"));
            this.Fields.Add(new ExplanationField("Response delay", "If desired, you can specify a delay until the response fires.This delay is pre-em" +
                        "pted if another timed response for the same section fires.The delay effect plays" +
                        " while the timer is counting down"));
            this.Fields.Add(new RealField("response delay#in seconds"));
            this.Fields.Add(new TagReferenceField("delay effect", 1701209701));
            this.Fields.Add(new StringIdField("delay effect marker name"));
            this.Fields.Add(new ExplanationField("Constraint destruction", @"- a response can destroy a single constraint by naming it explicitly.
- alternatively it can randomly destroy a single constraint from a specified group if the ""destroy one group constraint"" flag is set
- also it can destroy all constraints in a specified group if the ""destroy all group constraints"" flag is set
"));
            this.Fields.Add(new StringIdField("constraint/group name"));
            this.Fields.Add(new ExplanationField("seat ejaculation", ""));
            this.Fields.Add(new StringIdField("ejecting seat label"));
            this.Fields.Add(new ExplanationField("skip fraction", "0.0 always fires, 1.0 never fires"));
            this.Fields.Add(new RealFractionField("skip fraction"));
            this.Fields.Add(new ExplanationField("destroyed child object marker name", "when this response fires, any children objects created at the supplied marker nam" +
                        "e will be destroyed"));
            this.Fields.Add(new StringIdField("destroyed child object marker name"));
            this.Fields.Add(new ExplanationField("total damage threshold", "scale on total damage section vitality"));
            this.Fields.Add(new RealFractionField("total damage threshold"));
        }
        /// <summary>
        /// Gets and returns the name of the instantaneous_damage_repsonse_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "instantaneous_damage_repsonse_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the instantaneous_damage_repsonse_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "instantaneous_damage_repsonse_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the instantaneous_damage_repsonse_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 16;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the instantaneous_damage_repsonse_block tag block.
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
