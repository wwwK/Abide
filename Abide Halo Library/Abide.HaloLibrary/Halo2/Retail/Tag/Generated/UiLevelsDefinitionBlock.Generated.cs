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
    /// Represents the generated ui_levels_definition_block tag block.
    /// </summary>
    internal sealed class UiLevelsDefinitionBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UiLevelsDefinitionBlock"/> class.
        /// </summary>
        public UiLevelsDefinitionBlock()
        {
            this.Fields.Add(new BlockField<UiCampaignBlock>("Campaigns", 4));
            this.Fields.Add(new BlockField<GlobalUiCampaignLevelBlock>("Campaign Levels", 20));
            this.Fields.Add(new BlockField<GlobalUiMultiplayerLevelBlock>("Multiplayer Levels", 50));
        }
        /// <summary>
        /// Gets and returns the name of the ui_levels_definition_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "ui_levels_definition_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the ui_levels_definition_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "ui_levels_definition_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the ui_levels_definition_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the ui_levels_definition_block tag block.
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
