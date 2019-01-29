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
    /// Represents the generated scenario_object_datum_struct_block tag block.
    /// </summary>
    public sealed class ScenarioObjectDatumStructBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScenarioObjectDatumStructBlock"/> class.
        /// </summary>
        public ScenarioObjectDatumStructBlock()
        {
            this.Fields.Add(new LongFlagsField("Placement Flags", "Not Automatically", "Unused", "Unused", "Unused", "Lock Type to Env. Object", "Lock Transform to Env. Object", "Never Placed", "Lock Name to Env. Object", "Create at Rest"));
            this.Fields.Add(new RealPoint3dField("Position"));
            this.Fields.Add(new EulerAngles3dField("Rotation"));
            this.Fields.Add(new RealField("Scale"));
            this.Fields.Add(new WordFlagsField(")Transform Flags", "Mirrored"));
            this.Fields.Add(new WordFlagsField("Manual BSP Flags*"));
            this.Fields.Add(new StructField<ScenarioObjectIdStructBlock>("Object ID"));
            this.Fields.Add(new CharEnumField("BSP Policy", "Default", "Always Placed", "Manual BSP Placement"));
            this.Fields.Add(new PadField("", 1));
            this.Fields.Add(new ShortBlockIndexField("Editor Folder"));
        }
        /// <summary>
        /// Gets and returns the name of the scenario_object_datum_struct_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "scenario_object_datum_struct_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the scenario_object_datum_struct_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "scenario_object_datum_struct";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the scenario_object_datum_struct_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the scenario_object_datum_struct_block tag block.
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