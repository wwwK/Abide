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
    /// Represents the generated hud_globals_waypoint_arrow_block tag block.
    /// </summary>
    internal sealed class HudGlobalsWaypointArrowBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HudGlobalsWaypointArrowBlock"/> class.
        /// </summary>
        public HudGlobalsWaypointArrowBlock()
        {
            this.Fields.Add(new StringField("name^"));
            this.Fields.Add(new PadField("", 8));
            this.Fields.Add(new RgbColorField("color"));
            this.Fields.Add(new RealField("opacity"));
            this.Fields.Add(new RealField("translucency"));
            this.Fields.Add(new ShortIntegerField("on screen sequence index"));
            this.Fields.Add(new ShortIntegerField("off screen sequence index"));
            this.Fields.Add(new ShortIntegerField("occluded sequence index"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new PadField("", 16));
            this.Fields.Add(new LongFlagsField("flags", "don\'t rotate when pointing offscreen"));
            this.Fields.Add(new PadField("", 24));
        }
        /// <summary>
        /// Gets and returns the name of the hud_globals_waypoint_arrow_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "hud_globals_waypoint_arrow_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the hud_globals_waypoint_arrow_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "hud_waypoint_arrow_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the hud_globals_waypoint_arrow_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 16;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the hud_globals_waypoint_arrow_block tag block.
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
