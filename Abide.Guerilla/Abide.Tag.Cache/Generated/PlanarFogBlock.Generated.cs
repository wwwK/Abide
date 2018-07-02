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
    /// Represents the generated planar_fog_block tag block.
    /// </summary>
    public sealed class PlanarFogBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlanarFogBlock"/> class.
        /// </summary>
        public PlanarFogBlock()
        {
            this.Fields.Add(new ExplanationField("PLANAR FOG", "Please don\'t use these flags unless you know what you\'re doing! Come talk to Bern" +
                        "ie first."));
            this.Fields.Add(new WordFlagsField("flags", "render only submerged geometry", "extend infinitely while visible", "don\'t floodfill", "aggressive floodfill", "do not render", "do not render unless submerged"));
            this.Fields.Add(new ShortIntegerField("priority"));
            this.Fields.Add(new StringIdField("global material name"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new ExplanationField("DENSITY", ""));
            this.Fields.Add(new RealFractionField("maximum density:[0,1]#planar fog density is clamped to this value"));
            this.Fields.Add(new RealField("opaque distance:world units#the fog becomes opaque (maximum density) at this dist" +
                        "ance from the viewer"));
            this.Fields.Add(new RealField("opaque depth:world units#the fog becomes opaque at this distance below fog plane"));
            this.Fields.Add(new ExplanationField("DENSITY (ADVANCED CONTROLS)", ""));
            this.Fields.Add(new RealBoundsField("atmospheric-planar depth:world units#distances above fog plane where atmospheric " +
                        "fog supercedes planar fog and visa-versa"));
            this.Fields.Add(new RealField("eye offset scale:[-1,1]#negative numbers are bad, mmmkay?"));
            this.Fields.Add(new ExplanationField("COLOR", ""));
            this.Fields.Add(new RealRgbColorField("color"));
            this.Fields.Add(new BlockField<PlanarFogPatchyFogBlock>("patchy fog", 1));
            this.Fields.Add(new ExplanationField("SOUND", ""));
            this.Fields.Add(new TagReferenceField("background sound", "lsnd"));
            this.Fields.Add(new TagReferenceField("sound environment", "snde"));
            this.Fields.Add(new RealField("environment damping factor#scales the surrounding background sound by this much"));
            this.Fields.Add(new RealField("background sound gain#scale for fog background sound"));
            this.Fields.Add(new TagReferenceField("enter sound", "snd!"));
            this.Fields.Add(new TagReferenceField("exit sound", "snd!"));
        }
        /// <summary>
        /// Gets and returns the name of the planar_fog_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "planar_fog_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the planar_fog_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "planar_fog";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the planar_fog_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the planar_fog_block tag block.
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
