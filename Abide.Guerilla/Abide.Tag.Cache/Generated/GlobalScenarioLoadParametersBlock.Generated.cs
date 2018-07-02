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
    /// Represents the generated global_scenario_load_parameters_block tag block.
    /// </summary>
    public sealed class GlobalScenarioLoadParametersBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalScenarioLoadParametersBlock"/> class.
        /// </summary>
        public GlobalScenarioLoadParametersBlock()
        {
            this.Fields.Add(new ExplanationField("SCENARIO LOAD PARAMETERS", "strip-variant <variant-name>\nstrips a given variant out of the model tag\nstrip-di" +
                        "alogue\nstrips all the dialogue for this model i.e. cinematic only"));
            this.Fields.Add(new TagReferenceField("scenario^", "scnr"));
            this.Fields.Add(new DataField("parameters", 1, 4));
            this.Fields.Add(new PadField("", 32));
        }
        /// <summary>
        /// Gets and returns the name of the global_scenario_load_parameters_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "global_scenario_load_parameters_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the global_scenario_load_parameters_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "scenario load parameters";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the global_scenario_load_parameters_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 32;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the global_scenario_load_parameters_block tag block.
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
