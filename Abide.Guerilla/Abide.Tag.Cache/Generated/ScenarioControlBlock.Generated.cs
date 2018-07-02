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
    /// Represents the generated scenario_control_block tag block.
    /// </summary>
    public sealed class ScenarioControlBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScenarioControlBlock"/> class.
        /// </summary>
        public ScenarioControlBlock()
        {
            this.Fields.Add(new ShortBlockIndexField("Type"));
            this.Fields.Add(new ShortBlockIndexField("Name^"));
            this.Fields.Add(new StructField<ScenarioObjectDatumStructBlock>("Object Data"));
            this.Fields.Add(new StructField<ScenarioDeviceStructBlock>("Device Data"));
            this.Fields.Add(new StructField<ScenarioControlStructBlock>("Control Data"));
        }
        /// <summary>
        /// Gets and returns the name of the scenario_control_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "scenario_control_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the scenario_control_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "scenario_control_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the scenario_control_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 100;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the scenario_control_block tag block.
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
