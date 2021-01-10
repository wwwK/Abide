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
    /// Represents the generated scenario_cluster_data_resource (clu*) tag group.
    /// </summary>
    internal class ScenarioClusterDataResource : Group
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScenarioClusterDataResource"/> class.
        /// </summary>
        public ScenarioClusterDataResource()
        {
            // Add tag block to list.
            this.TagBlocks.Add(new ScenarioClusterDataResourceBlock());
        }
        /// <summary>
        /// Gets and returns the name of the scenario_cluster_data_resource tag group.
        /// </summary>
        public override string GroupName
        {
            get
            {
                return "scenario_cluster_data_resource";
            }
        }
        /// <summary>
        /// Gets and returns the group tag of the scenario_cluster_data_resource tag group.
        /// </summary>
        public override TagFourCc GroupTag
        {
            get
            {
                return "clu*";
            }
        }
    }
}
