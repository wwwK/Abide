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
    using System;
    using Abide.HaloLibrary;
    using Abide.Tag;
    
    /// <summary>
    /// Represents the generated scenario_decorators_resource_block tag block.
    /// </summary>
    public sealed class ScenarioDecoratorsResourceBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScenarioDecoratorsResourceBlock"/> class.
        /// </summary>
        public ScenarioDecoratorsResourceBlock()
        {
            this.Fields.Add(new BlockField<DecoratorPlacementDefinitionBlock>("Decorator", 1));
            this.Fields.Add(new BlockField<ScenarioDecoratorSetPaletteEntryBlock>("Decorator Palette", 32));
        }
        /// <summary>
        /// Gets and returns the name of the scenario_decorators_resource_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "scenario_decorators_resource_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the scenario_decorators_resource_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "scenario_decorators_resource";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the scenario_decorators_resource_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the scenario_decorators_resource_block tag block.
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
