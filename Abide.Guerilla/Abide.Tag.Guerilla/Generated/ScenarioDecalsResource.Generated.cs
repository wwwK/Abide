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
    using Abide.Tag;
    using HaloTag = Abide.HaloLibrary.TagFourCc;
    
    /// <summary>
    /// Represents the generated scenario_decals_resource (dec*) tag group.
    /// </summary>
    public class ScenarioDecalsResource : Group
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScenarioDecalsResource"/> class.
        /// </summary>
        public ScenarioDecalsResource()
        {
            // Add tag block to list.
            this.TagBlocks.Add(new ScenarioDecalsResourceBlock());
        }
        /// <summary>
        /// Gets and returns the name of the scenario_decals_resource tag group.
        /// </summary>
        public override string Name
        {
            get
            {
                return "scenario_decals_resource";
            }
        }
        /// <summary>
        /// Gets and returns the group tag of the scenario_decals_resource tag group.
        /// </summary>
        public override HaloTag GroupTag
        {
            get
            {
                return "dec*";
            }
        }
    }
}
