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
    /// Represents the generated animation_frame_event_block tag block.
    /// </summary>
    public sealed class AnimationFrameEventBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnimationFrameEventBlock"/> class.
        /// </summary>
        public AnimationFrameEventBlock()
        {
            this.Fields.Add(new EnumField("type", "primary_keyframe", "secondary_keyframe", "left_foot", "right_foot", "allow_interruption", "transition A", "transition B", "transition C", "transition D", "both-feet shuffle", "body impact"));
            this.Fields.Add(new ShortIntegerField("frame"));
        }
        /// <summary>
        /// Gets and returns the name of the animation_frame_event_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "animation_frame_event_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the animation_frame_event_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "animation_frame_event_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the animation_frame_event_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 512;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the animation_frame_event_block tag block.
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
