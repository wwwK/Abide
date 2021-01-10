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
    /// Represents the generated inherited_animation_block tag block.
    /// </summary>
    internal sealed class InheritedAnimationBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InheritedAnimationBlock"/> class.
        /// </summary>
        public InheritedAnimationBlock()
        {
            this.Fields.Add(new TagReferenceField("inherited graph*", 1785553252));
            this.Fields.Add(new BlockField<InheritedAnimationNodeMapBlock>("node map*", 255));
            this.Fields.Add(new BlockField<InheritedAnimationNodeMapFlagBlock>("node map flags*", 255));
            this.Fields.Add(new RealField("root z offset*"));
            this.Fields.Add(new LongIntegerField("inheritance_flags*"));
        }
        /// <summary>
        /// Gets and returns the name of the inherited_animation_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "inherited_animation_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the inherited_animation_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "inherited_animation_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the inherited_animation_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 8;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the inherited_animation_block tag block.
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
