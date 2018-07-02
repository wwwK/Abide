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
    /// Represents the generated breakable_surface_block tag block.
    /// </summary>
    public sealed class BreakableSurfaceBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BreakableSurfaceBlock"/> class.
        /// </summary>
        public BreakableSurfaceBlock()
        {
            this.Fields.Add(new RealField("maximum vitality"));
            this.Fields.Add(new TagReferenceField("effect", "effe"));
            this.Fields.Add(new TagReferenceField("sound", "snd!"));
            this.Fields.Add(new BlockField<ParticleSystemDefinitionBlockNew>("particle effects", 32));
            this.Fields.Add(new RealField("particle density"));
        }
        /// <summary>
        /// Gets and returns the name of the breakable_surface_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "breakable_surface_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the breakable_surface_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "breakable_surface";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the breakable_surface_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the breakable_surface_block tag block.
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
