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
    /// Represents the generated single_animation_reference_block tag block.
    /// </summary>
    internal sealed class SingleAnimationReferenceBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SingleAnimationReferenceBlock"/> class.
        /// </summary>
        public SingleAnimationReferenceBlock()
        {
            this.Fields.Add(new LongFlagsField("flags", "unused"));
            this.Fields.Add(new LongIntegerField("animation period:milliseconds"));
            this.Fields.Add(new BlockField<ScreenAnimationKeyframeReferenceBlock>("keyframes", 64));
        }
        /// <summary>
        /// Gets and returns the name of the single_animation_reference_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "single_animation_reference_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the single_animation_reference_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "single_animation_reference_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the single_animation_reference_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 7;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the single_animation_reference_block tag block.
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
