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
    /// Represents the generated scenario_cutscene_flag_block tag block.
    /// </summary>
    internal sealed class ScenarioCutsceneFlagBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScenarioCutsceneFlagBlock"/> class.
        /// </summary>
        public ScenarioCutsceneFlagBlock()
        {
            this.Fields.Add(new PadField("", 4));
            this.Fields.Add(new StringField("Name^"));
            this.Fields.Add(new RealPoint3dField("Position"));
            this.Fields.Add(new EulerAngles2dField("Facing"));
        }
        /// <summary>
        /// Gets and returns the name of the scenario_cutscene_flag_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "scenario_cutscene_flag_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the scenario_cutscene_flag_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "scenario_cutscene_flag_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the scenario_cutscene_flag_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 512;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the scenario_cutscene_flag_block tag block.
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
