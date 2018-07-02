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
    /// Represents the generated lens_flare_reflection_block tag block.
    /// </summary>
    public sealed class LensFlareReflectionBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LensFlareReflectionBlock"/> class.
        /// </summary>
        public LensFlareReflectionBlock()
        {
            this.Fields.Add(new WordFlagsField("flags", "align rotation with screen center", "radius NOT scaled by distance", "radius scaled by occlusion factor", "occluded by solid objects", "ignore light color", "not affected by inner occlusion"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new ShortIntegerField("bitmap index"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new RealField("position:along flare axis#0 is on top of light, 1 is opposite light, 0.5 is the c" +
                        "enter of the screen, etc."));
            this.Fields.Add(new RealField("rotation offset:degrees"));
            this.Fields.Add(new RealBoundsField("radius:world units#interpolated by external input"));
            this.Fields.Add(new RealFractionBoundsField("brightness:[0,1]#interpolated by external input"));
            this.Fields.Add(new ExplanationField("TINT COLOR", @"Tinting and modulating are not the same; 'tinting' a reflection will color the darker regions but leave the highlights, while 'modulating' will color everything uniformly. The modulation factor controls how much the reflection is modulated as opposed to tinted (0 is tinted, 1 is modulated)."));
            this.Fields.Add(new RealFractionField("modulation factor:[0,1]"));
            this.Fields.Add(new RealRgbColorField("color"));
        }
        /// <summary>
        /// Gets and returns the name of the lens_flare_reflection_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "lens_flare_reflection_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the lens_flare_reflection_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "reflection";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the lens_flare_reflection_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 32;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the lens_flare_reflection_block tag block.
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
