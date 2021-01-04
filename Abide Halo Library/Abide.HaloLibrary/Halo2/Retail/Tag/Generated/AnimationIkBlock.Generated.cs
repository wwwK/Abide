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
    /// Represents the generated animation_ik_block tag block.
    /// </summary>
    public sealed class AnimationIkBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnimationIkBlock"/> class.
        /// </summary>
        public AnimationIkBlock()
        {
            this.Fields.Add(new StringIdField("marker#the marker name on the object being attached"));
            this.Fields.Add(new StringIdField("attach to marker#the marker name object (weapon, vehicle, etc.) the above marker " +
                        "is being attached to"));
        }
        /// <summary>
        /// Gets and returns the name of the animation_ik_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "animation_ik_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the animation_ik_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "animation_ik_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the animation_ik_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 8;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the animation_ik_block tag block.
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
