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
    /// Represents the generated lens_flare_color_animation_block tag block.
    /// </summary>
    public sealed class LensFlareColorAnimationBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LensFlareColorAnimationBlock"/> class.
        /// </summary>
        public LensFlareColorAnimationBlock()
        {
            this.Fields.Add(new StructField<ColorFunctionStructBlock>("function"));
        }
        /// <summary>
        /// Gets and returns the name of the lens_flare_color_animation_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "lens_flare_color_animation_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the lens_flare_color_animation_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "lens_flare_color_animation_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the lens_flare_color_animation_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the lens_flare_color_animation_block tag block.
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
