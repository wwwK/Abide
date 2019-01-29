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
    /// Represents the generated animation_transition_state_struct_block tag block.
    /// </summary>
    public sealed class AnimationTransitionStateStructBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnimationTransitionStateStructBlock"/> class.
        /// </summary>
        public AnimationTransitionStateStructBlock()
        {
            this.Fields.Add(new StringIdField("state name*#name of the state"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new CharIntegerField("index a*#first level sub-index into state"));
            this.Fields.Add(new CharIntegerField("index b*#second level sub-index into state"));
        }
        /// <summary>
        /// Gets and returns the name of the animation_transition_state_struct_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "animation_transition_state_struct_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the animation_transition_state_struct_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "animation_transition_state_struct";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the animation_transition_state_struct_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the animation_transition_state_struct_block tag block.
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