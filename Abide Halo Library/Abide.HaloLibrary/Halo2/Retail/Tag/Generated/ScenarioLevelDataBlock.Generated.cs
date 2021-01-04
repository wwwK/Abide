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
    /// Represents the generated scenario_level_data_block tag block.
    /// </summary>
    public sealed class ScenarioLevelDataBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScenarioLevelDataBlock"/> class.
        /// </summary>
        public ScenarioLevelDataBlock()
        {
            this.Fields.Add(new TagReferenceField("Level Description", 1970170211));
            this.Fields.Add(new BlockField<GlobalUiCampaignLevelBlock>("Campaign Level Data", 20));
            this.Fields.Add(new BlockField<GlobalUiMultiplayerLevelBlock>("Multiplayer", 50));
        }
        /// <summary>
        /// Gets and returns the name of the scenario_level_data_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "scenario_level_data_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the scenario_level_data_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "scenario_level_data_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the scenario_level_data_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the scenario_level_data_block tag block.
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