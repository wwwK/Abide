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
    /// Represents the generated animation_reference_block tag block.
    /// </summary>
    public sealed class AnimationReferenceBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnimationReferenceBlock"/> class.
        /// </summary>
        public AnimationReferenceBlock()
        {
            this.Fields.Add(new LongFlagsField("flags", "unused"));
            this.Fields.Add(new ExplanationField("Primary Intro Transition", "Defines the primary intro transitional animation"));
            this.Fields.Add(new LongIntegerField("animation period:milliseconds"));
            this.Fields.Add(new BlockField<ScreenAnimationKeyframeReferenceBlock>("keyframes", 64));
            this.Fields.Add(new ExplanationField("Primary Outro Transition", "Defines the primary outro transitional animation"));
            this.Fields.Add(new LongIntegerField("animation period:milliseconds"));
            this.Fields.Add(new BlockField<ScreenAnimationKeyframeReferenceBlock>("keyframes", 64));
            this.Fields.Add(new ExplanationField("Ambient Animation", "Defines the ambient animation"));
            this.Fields.Add(new LongIntegerField("animation period:milliseconds"));
            this.Fields.Add(new EnumField("ambient animation looping style", "NONE", "reverse loop", "loop", "don\'t loop"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new BlockField<ScreenAnimationKeyframeReferenceBlock>("keyframes", 64));
        }
        /// <summary>
        /// Gets and returns the name of the animation_reference_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "animation_reference_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the animation_reference_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "animation_reference_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the animation_reference_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 64;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the animation_reference_block tag block.
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