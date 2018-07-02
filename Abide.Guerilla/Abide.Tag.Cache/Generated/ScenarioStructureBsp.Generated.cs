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
    using HaloTag = Abide.HaloLibrary.TagFourCc;
    
    /// <summary>
    /// Represents the generated scenario_structure_bsp (sbsp) tag group.
    /// </summary>
    public class ScenarioStructureBsp : Group
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScenarioStructureBsp"/> class.
        /// </summary>
        public ScenarioStructureBsp()
        {
            // Add tag block to list.
            this.TagBlocks.Add(new ScenarioStructureBspBlock());
        }
        /// <summary>
        /// Gets and returns the name of the scenario_structure_bsp tag group.
        /// </summary>
        public override string Name
        {
            get
            {
                return "scenario_structure_bsp";
            }
        }
        /// <summary>
        /// Gets and returns the group tag of the scenario_structure_bsp tag group.
        /// </summary>
        public override HaloTag GroupTag
        {
            get
            {
                return "sbsp";
            }
        }
    }
}
