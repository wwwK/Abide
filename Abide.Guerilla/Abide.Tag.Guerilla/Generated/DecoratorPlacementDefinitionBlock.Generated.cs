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
    
    /// <summary>
    /// Represents the generated decorator_placement_definition_block tag block.
    /// </summary>
    public sealed class DecoratorPlacementDefinitionBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DecoratorPlacementDefinitionBlock"/> class.
        /// </summary>
        public DecoratorPlacementDefinitionBlock()
        {
            this.Fields.Add(new RealPoint3dField("Grid Origin"));
            this.Fields.Add(new LongIntegerField("Cell Count per Dimension"));
            this.Fields.Add(new BlockField<DecoratorCacheBlockBlock>("Cache Blocks", 4096));
            this.Fields.Add(new BlockField<DecoratorGroupBlock>("Groups", 131072));
            this.Fields.Add(new BlockField<DecoratorCellCollectionBlock>("Cells", 65535));
            this.Fields.Add(new BlockField<DecoratorProjectedDecalBlock>("Decals", 32768));
        }
        /// <summary>
        /// Gets and returns the name of the decorator_placement_definition_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "decorator_placement_definition_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the decorator_placement_definition_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "decorator_placement_definition_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the decorator_placement_definition_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the decorator_placement_definition_block tag block.
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
