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
    /// Represents the generated weapon_hud_crosshair_item_block tag block.
    /// </summary>
    public sealed class WeaponHudCrosshairItemBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WeaponHudCrosshairItemBlock"/> class.
        /// </summary>
        public WeaponHudCrosshairItemBlock()
        {
            this.Fields.Add(new Point2dField("anchor offset"));
            this.Fields.Add(new RealField("width scale"));
            this.Fields.Add(new RealField("height scale"));
            this.Fields.Add(new WordFlagsField("scaling flags", "don\'t scale offset", "don\'t scale size"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new PadField("", 20));
            this.Fields.Add(new ArgbColorField("default color"));
            this.Fields.Add(new ArgbColorField("flashing color"));
            this.Fields.Add(new RealField("flash period"));
            this.Fields.Add(new RealField("flash delay#time between flashes"));
            this.Fields.Add(new ShortIntegerField("number of flashes"));
            this.Fields.Add(new WordFlagsField("flash flags", "reverse default/flashing colors"));
            this.Fields.Add(new RealField("flash length#time of each flash"));
            this.Fields.Add(new ArgbColorField("disabled color"));
            this.Fields.Add(new PadField("", 4));
            this.Fields.Add(new ShortIntegerField("frame rate"));
            this.Fields.Add(new ShortIntegerField("sequence index"));
            this.Fields.Add(new LongFlagsField("flags", "flashes when active", "not a sprite", "show only when zoomed", "show sniper data", "hide area outside reticle", "one zoom level", "don\'t show when zoomed"));
            this.Fields.Add(new PadField("", 32));
        }
        /// <summary>
        /// Gets and returns the name of the weapon_hud_crosshair_item_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "weapon_hud_crosshair_item_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the weapon_hud_crosshair_item_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "weapon_hud_crosshair_item_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the weapon_hud_crosshair_item_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 16;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the weapon_hud_crosshair_item_block tag block.
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
