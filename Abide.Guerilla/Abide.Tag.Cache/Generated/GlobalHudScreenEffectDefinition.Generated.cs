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
    /// Represents the generated global_hud_screen_effect_definition tag block.
    /// </summary>
    public sealed class GlobalHudScreenEffectDefinition : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalHudScreenEffectDefinition"/> class.
        /// </summary>
        public GlobalHudScreenEffectDefinition()
        {
            this.Fields.Add(new PadField("", 4));
            this.Fields.Add(new ExplanationField("Mask", "Mask bitmap overlay. Use either a 2D bitmap or an interface bitmap."));
            this.Fields.Add(new WordFlagsField("flags", "only when zoomed", "mirror horizontally", "mirror vertically", "use new hotness"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new PadField("", 16));
            this.Fields.Add(new TagReferenceField("mask (fullscreen)", "bitm"));
            this.Fields.Add(new TagReferenceField("mask (splitscreen)", "bitm"));
            this.Fields.Add(new PadField("", 8));
            this.Fields.Add(new PadField("", 20));
            this.Fields.Add(new PadField("", 24));
            this.Fields.Add(new PadField("", 8));
            this.Fields.Add(new PadField("", 24));
            this.Fields.Add(new PadField("", 20));
            this.Fields.Add(new PadField("", 24));
            this.Fields.Add(new ExplanationField("Screen effect (fullscreen)", ""));
            this.Fields.Add(new LongFlagsField("screen effect flags", "only when zoomed"));
            this.Fields.Add(new PadField("", 32));
            this.Fields.Add(new TagReferenceField("screen effect", "egor"));
            this.Fields.Add(new PadField("", 32));
            this.Fields.Add(new ExplanationField("Screen effect (splitscreen)", ""));
            this.Fields.Add(new LongFlagsField("screen effect flags", "only when zoomed"));
            this.Fields.Add(new PadField("", 32));
            this.Fields.Add(new TagReferenceField("screen effect", "egor"));
            this.Fields.Add(new PadField("", 32));
        }
        /// <summary>
        /// Gets and returns the name of the global_hud_screen_effect_definition tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "global_hud_screen_effect_definition";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the global_hud_screen_effect_definition tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "global_hud_screen_effect_definition";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the global_hud_screen_effect_definition tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the global_hud_screen_effect_definition tag block.
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
