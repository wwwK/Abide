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
    /// Represents the generated light_volume_volume_block tag block.
    /// </summary>
    internal sealed class LightVolumeVolumeBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LightVolumeVolumeBlock"/> class.
        /// </summary>
        public LightVolumeVolumeBlock()
        {
            this.Fields.Add(new ExplanationField("VOLUME", @"If no bitmap is selected, the default glow bitmap will be used. Sprite count controls how many sprites are used to render this volume. Using more sprites will result in a smoother and brighter effect, at a slight performance penalty. Don't touch the flags unless you know what you're doing (they should be off by default).

Be careful with the 'fuzzy' flag! It should be used on very wide light volumes to make them blend smoothly into solid geometry rather than ""cutting"" into the zbuffer. Using this feature will make light volumes several times slower when they fill a large portion of the screen."));
            this.Fields.Add(new LongFlagsField("flags", "force linear radius function", "force linear offset", "force differential evaluation", "fuzzy", "not scaled by event duration", "scaled by marker"));
            this.Fields.Add(new TagReferenceField("bitmap", 1651078253));
            this.Fields.Add(new LongIntegerField("sprite count:[4,256]"));
            this.Fields.Add(new ExplanationField("OFFSET", @"This function controls the offset along the projected forward axis of the light volume. The output range of this function is the distance in WORLD UNITS from the origin where the first and last sprite are rendered. The input to this function is the fractional value (from 0 to 1) along the projected axis. Using a transition function such as ""late"" will result in more sprites being bunched up towards the origin and spaced further apart near the end.

Note that this and other functions in this tag have a range-input, which is controlled by the output of the FACING function below."));
            this.Fields.Add(new StructField<ScalarFunctionStructBlock>("offset function"));
            this.Fields.Add(new ExplanationField("RADIUS", "This function controls the radius in WORLD UNITS of each sprite along the project" +
                        "ed forward axis. Using a smaller min value and a larger max value results in a l" +
                        "ight volume that looks like a cone."));
            this.Fields.Add(new StructField<ScalarFunctionStructBlock>("radius function"));
            this.Fields.Add(new ExplanationField("BRIGHTNESS", @"This function controls the overall brightness (in [0,1]) of each sprite along the projected forward axis. Note that since the sprites are additive, they will be brighter in areas where they overlap more even if this function is constant, so it may be useful to use the brightness function to compensate for this."));
            this.Fields.Add(new StructField<ScalarFunctionStructBlock>("brightness function"));
            this.Fields.Add(new ExplanationField("COLOR", "This function controls the color of each sprite along the projected forward axis." +
                        " Color is multiplied by brightness to produce the final color that will be appli" +
                        "ed to the sprite."));
            this.Fields.Add(new StructField<ColorFunctionStructBlock>("color function"));
            this.Fields.Add(new ExplanationField("FACING", @"The input to this function is the facing angle between the light volume and the camera. Zero represents facing towards (parallel) or away from the camera and 1.0 represents facing perpendicular to the camera.

The output of this function is fed into the range-input of the functions above."));
            this.Fields.Add(new StructField<ScalarFunctionStructBlock>("facing function"));
            this.Fields.Add(new BlockField<LightVolumeAspectBlock>("aspect", 1));
            this.Fields.Add(new ExplanationField("POSTPROCESS CONTROL", "ADVANCED STUFF!! Don\'t change these values!!"));
            this.Fields.Add(new RealFractionField("radius frac min*:[0.00390625, 1.0]"));
            this.Fields.Add(new RealFractionField("DEPRECATED!! x-step exponent*:[0.5, 0.875]"));
            this.Fields.Add(new LongIntegerField("DEPRECATED!! x-buffer length*:[32, 512]"));
            this.Fields.Add(new LongIntegerField("x-buffer spacing*:[1, 256]"));
            this.Fields.Add(new LongIntegerField("x-buffer min iterations*:[1, 256]"));
            this.Fields.Add(new LongIntegerField("x-buffer max iterations*:[1, 256]"));
            this.Fields.Add(new RealFractionField("x-delta max error*:[0.001, 0.1]"));
            this.Fields.Add(new SkipField("", 4));
            this.Fields.Add(new BlockField<LightVolumeRuntimeOffsetBlock>("*", 256));
            this.Fields.Add(new SkipField("", 48));
        }
        /// <summary>
        /// Gets and returns the name of the light_volume_volume_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "light_volume_volume_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the light_volume_volume_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "volume";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the light_volume_volume_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 16;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the light_volume_volume_block tag block.
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
