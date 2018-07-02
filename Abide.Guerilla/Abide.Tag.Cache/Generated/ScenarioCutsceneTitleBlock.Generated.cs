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
    /// Represents the generated scenario_cutscene_title_block tag block.
    /// </summary>
    public sealed class ScenarioCutsceneTitleBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScenarioCutsceneTitleBlock"/> class.
        /// </summary>
        public ScenarioCutsceneTitleBlock()
        {
            this.Fields.Add(new StringIdField("name^"));
            this.Fields.Add(new Rectangle2dField("text bounds (on screen)"));
            this.Fields.Add(new EnumField("justification", "left", "right", "center", "custom_text_entry"));
            this.Fields.Add(new EnumField("font", "terminal font", "body text font", "title font", "super large font", "large body text font", "split screen hud message font", "full screen hud message font", "english body text font", "hud number font", "subtitle font", "main menu font", "text chat font"));
            this.Fields.Add(new RgbColorField("text color"));
            this.Fields.Add(new RgbColorField("shadow color"));
            this.Fields.Add(new RealField("fade in time [seconds]"));
            this.Fields.Add(new RealField("up time [seconds]"));
            this.Fields.Add(new RealField("fade out time [seconds]"));
            this.Fields.Add(new PadField("", 2));
        }
        /// <summary>
        /// Gets and returns the name of the scenario_cutscene_title_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "scenario_cutscene_title_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the scenario_cutscene_title_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "scenario_cutscene_title_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the scenario_cutscene_title_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 128;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the scenario_cutscene_title_block tag block.
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
