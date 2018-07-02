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
    using Abide.Tag;
    
    /// <summary>
    /// Represents the generated scenario_weapon_datum_struct_block tag block.
    /// </summary>
    public sealed class ScenarioWeaponDatumStructBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScenarioWeaponDatumStructBlock"/> class.
        /// </summary>
        public ScenarioWeaponDatumStructBlock()
        {
            this.Fields.Add(new ShortIntegerField("Rounds Left"));
            this.Fields.Add(new ShortIntegerField("Rounds Loaded"));
            this.Fields.Add(new LongFlagsField("Flags", "Initially at Rest (Does Not Fall)", "Obsolete", "Does Accelerate (Moves Due to Explosions)"));
        }
        /// <summary>
        /// Gets and returns the name of the scenario_weapon_datum_struct_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "scenario_weapon_datum_struct_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the scenario_weapon_datum_struct_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "scenario_weapon_datum_struct";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the scenario_weapon_datum_struct_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the scenario_weapon_datum_struct_block tag block.
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
