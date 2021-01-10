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
    /// Represents the generated animation_aiming_screen_struct_block tag block.
    /// </summary>
    internal sealed class AnimationAimingScreenStructBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnimationAimingScreenStructBlock"/> class.
        /// </summary>
        public AnimationAimingScreenStructBlock()
        {
            this.Fields.Add(new AngleField("right yaw per frame"));
            this.Fields.Add(new AngleField("left yaw per frame"));
            this.Fields.Add(new ShortIntegerField("right frame count"));
            this.Fields.Add(new ShortIntegerField("left frame count"));
            this.Fields.Add(new AngleField("down pitch per frame"));
            this.Fields.Add(new AngleField("up pitch per frame"));
            this.Fields.Add(new ShortIntegerField("down pitch frame count"));
            this.Fields.Add(new ShortIntegerField("up pitch frame count"));
        }
        /// <summary>
        /// Gets and returns the name of the animation_aiming_screen_struct_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "animation_aiming_screen_struct_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the animation_aiming_screen_struct_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "animation_aiming_screen_struct";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the animation_aiming_screen_struct_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the animation_aiming_screen_struct_block tag block.
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
