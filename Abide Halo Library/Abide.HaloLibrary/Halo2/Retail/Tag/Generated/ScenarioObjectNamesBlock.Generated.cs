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
    /// Represents the generated scenario_object_names_block tag block.
    /// </summary>
    public sealed class ScenarioObjectNamesBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScenarioObjectNamesBlock"/> class.
        /// </summary>
        public ScenarioObjectNamesBlock()
        {
            this.Fields.Add(new StringField("Name^"));
            this.Fields.Add(new ShortBlockIndexField(""));
            this.Fields.Add(new ShortBlockIndexField(""));
        }
        /// <summary>
        /// Gets and returns the name of the scenario_object_names_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "scenario_object_names_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the scenario_object_names_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "scenario_object_names_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the scenario_object_names_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 640;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the scenario_object_names_block tag block.
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
