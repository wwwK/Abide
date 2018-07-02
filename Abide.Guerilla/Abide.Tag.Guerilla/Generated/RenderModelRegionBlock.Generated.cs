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
    /// Represents the generated render_model_region_block tag block.
    /// </summary>
    public sealed class RenderModelRegionBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RenderModelRegionBlock"/> class.
        /// </summary>
        public RenderModelRegionBlock()
        {
            this.Fields.Add(new OldStringIdField("name*^"));
            this.Fields.Add(new ShortIntegerField("node map offset (OLD)*"));
            this.Fields.Add(new ShortIntegerField("node map size (OLD)*"));
            this.Fields.Add(new BlockField<RenderModelPermutationBlock>("permutations*", 32));
        }
        /// <summary>
        /// Gets and returns the name of the render_model_region_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "render_model_region_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the render_model_region_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "region";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the render_model_region_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 16;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the render_model_region_block tag block.
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
