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
    /// Represents the generated light_brightness_animation_block tag block.
    /// </summary>
    public sealed class LightBrightnessAnimationBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LightBrightnessAnimationBlock"/> class.
        /// </summary>
        public LightBrightnessAnimationBlock()
        {
            this.Fields.Add(new StructField<MappingFunctionBlock>("function"));
        }
        /// <summary>
        /// Gets and returns the name of the light_brightness_animation_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "light_brightness_animation_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the light_brightness_animation_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "brightness animation";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the light_brightness_animation_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the light_brightness_animation_block tag block.
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
