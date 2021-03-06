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
    using System;
    using Abide.HaloLibrary;
    using Abide.Tag;
    
    /// <summary>
    /// Represents the generated scenario_object_id_struct_block tag block.
    /// </summary>
    public sealed class ScenarioObjectIdStructBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScenarioObjectIdStructBlock"/> class.
        /// </summary>
        public ScenarioObjectIdStructBlock()
        {
            this.Fields.Add(new LongIntegerField("Unique ID*"));
            this.Fields.Add(new ShortBlockIndexField("Origin BSP Index*"));
            this.Fields.Add(new CharEnumField("Type*", "Biped", "Vehicle", "Weapon", "Equipment", "Garbage", "Projectile", "Scenery", "Machine", "Control", "light_fixture", "sound_scenery", "Crate", "Creature"));
            this.Fields.Add(new CharEnumField("Source*", "Structure", "Editor", "Dynamic", "Legacy"));
        }
        /// <summary>
        /// Gets and returns the name of the scenario_object_id_struct_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "scenario_object_id_struct_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the scenario_object_id_struct_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "scenario_object_id_struct";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the scenario_object_id_struct_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the scenario_object_id_struct_block tag block.
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
