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
    /// Represents the generated unit_hud_auxilary_overlay_block tag block.
    /// </summary>
    public sealed class UnitHudAuxilaryOverlayBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnitHudAuxilaryOverlayBlock"/> class.
        /// </summary>
        public UnitHudAuxilaryOverlayBlock()
        {
            this.Fields.Add(new Point2dField("anchor offset"));
            this.Fields.Add(new RealField("width scale"));
            this.Fields.Add(new RealField("height scale"));
            this.Fields.Add(new WordFlagsField("scaling flags", "don\'t scale offset", "don\'t scale size"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new PadField("", 20));
            this.Fields.Add(new TagReferenceField("interface bitmap", "bitm"));
            this.Fields.Add(new ArgbColorField("default color"));
            this.Fields.Add(new ArgbColorField("flashing color"));
            this.Fields.Add(new RealField("flash period"));
            this.Fields.Add(new RealField("flash delay#time between flashes"));
            this.Fields.Add(new ShortIntegerField("number of flashes"));
            this.Fields.Add(new WordFlagsField("flash flags", "reverse default/flashing colors"));
            this.Fields.Add(new RealField("flash length#time of each flash"));
            this.Fields.Add(new ArgbColorField("disabled color"));
            this.Fields.Add(new PadField("", 4));
            this.Fields.Add(new ShortIntegerField("sequence index"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new BlockField<GlobalHudMultitextureOverlayDefinition>("multitex overlay", 30));
            this.Fields.Add(new PadField("", 4));
            this.Fields.Add(new EnumField("type", "team icon"));
            this.Fields.Add(new WordFlagsField("flags", "use team color"));
            this.Fields.Add(new PadField("", 24));
        }
        /// <summary>
        /// Gets and returns the name of the unit_hud_auxilary_overlay_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "unit_hud_auxilary_overlay_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the unit_hud_auxilary_overlay_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "unit_hud_auxilary_overlay_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the unit_hud_auxilary_overlay_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 16;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the unit_hud_auxilary_overlay_block tag block.
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
