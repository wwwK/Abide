//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Abide.Tag.Guerilla.Generated
{
    using Abide.Tag;
    
    /// <summary>
    /// Represents the generated scenario_light_palette_block tag block.
    /// </summary>
    public sealed class ScenarioLightPaletteBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScenarioLightPaletteBlock"/> class.
        /// </summary>
        public ScenarioLightPaletteBlock()
        {
            this.Fields.Add(new TagReferenceField("Name^", "ligh"));
            this.Fields.Add(new PadField("", 32));
        }
        /// <summary>
        /// Gets and returns the name of the scenario_light_palette_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "scenario_light_palette_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the scenario_light_palette_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "scenario_light_palette_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the scenario_light_palette_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 256;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the scenario_light_palette_block tag block.
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