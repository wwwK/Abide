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
    /// Represents the generated scenario_interpolator_block tag block.
    /// </summary>
    internal sealed class ScenarioInterpolatorBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScenarioInterpolatorBlock"/> class.
        /// </summary>
        public ScenarioInterpolatorBlock()
        {
            this.Fields.Add(new StringIdField("Name^"));
            this.Fields.Add(new StringIdField("Accelerator Name:Interpolator"));
            this.Fields.Add(new StringIdField("Multiplier Name:Interpolator"));
            this.Fields.Add(new StructField<ScalarFunctionStructBlock>("Function"));
            this.Fields.Add(new SkipField("", 2));
            this.Fields.Add(new SkipField("", 2));
        }
        /// <summary>
        /// Gets and returns the name of the scenario_interpolator_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "scenario_interpolator_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the scenario_interpolator_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "interpolators";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the scenario_interpolator_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 16;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the scenario_interpolator_block tag block.
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
