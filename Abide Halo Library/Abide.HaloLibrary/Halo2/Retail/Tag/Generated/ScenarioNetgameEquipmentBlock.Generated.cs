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
    /// Represents the generated scenario_netgame_equipment_block tag block.
    /// </summary>
    internal sealed class ScenarioNetgameEquipmentBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScenarioNetgameEquipmentBlock"/> class.
        /// </summary>
        public ScenarioNetgameEquipmentBlock()
        {
            this.Fields.Add(new LongFlagsField("Flags", "Levitate", "Destroy Existing on New Spawn"));
            this.Fields.Add(new EnumField("Game Type 1", "NONE", "Capture the Flag", "Slayer", "Oddball", "King of the Hill", "Race", "Headhunter", "Juggernaut", "Territories", "stub", "ignored3", "ignored4", "All Game Types", "All Except CTF", "All Except CTF & Race"));
            this.Fields.Add(new EnumField("Game Type 2", "NONE", "Capture the Flag", "Slayer", "Oddball", "King of the Hill", "Race", "Headhunter", "Juggernaut", "Territories", "stub", "ignored3", "ignored4", "All Game Types", "All Except CTF", "All Except CTF & Race"));
            this.Fields.Add(new EnumField("Game Type 3", "NONE", "Capture the Flag", "Slayer", "Oddball", "King of the Hill", "Race", "Headhunter", "Juggernaut", "Territories", "stub", "ignored3", "ignored4", "All Game Types", "All Except CTF", "All Except CTF & Race"));
            this.Fields.Add(new EnumField("Game Type 4", "NONE", "Capture the Flag", "Slayer", "Oddball", "King of the Hill", "Race", "Headhunter", "Juggernaut", "Territories", "stub", "ignored3", "ignored4", "All Game Types", "All Except CTF", "All Except CTF & Race"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new ShortIntegerField("Spawn Time (in seconds, 0 = default)"));
            this.Fields.Add(new ShortIntegerField("Respawn on Empty Time:seconds"));
            this.Fields.Add(new EnumField("Respawn Timer Starts", "On Pick Up", "On Body Depletion"));
            this.Fields.Add(new CharEnumField("Classification", "Weapon", "Primary Light Land", "Secondary Light Land", "Primary Heavy Land", "Primary Flying", "Secondary Heavy Land", "Primary Turret", "Secondary Turret", "Grenade", "Powerup"));
            this.Fields.Add(new PadField("", 3));
            this.Fields.Add(new PadField("", 40));
            this.Fields.Add(new RealPoint3dField("Position"));
            this.Fields.Add(new StructField<ScenarioNetgameEquipmentOrientationStructBlock>("Orientation"));
            this.Fields.Add(new TagReferenceField("Item/Vehicle Collection", -3));
            this.Fields.Add(new PadField("", 48));
        }
        /// <summary>
        /// Gets and returns the name of the scenario_netgame_equipment_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "scenario_netgame_equipment_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the scenario_netgame_equipment_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "scenario_netgame_equipment_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the scenario_netgame_equipment_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 100;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the scenario_netgame_equipment_block tag block.
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
