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
    /// Represents the generated model_variant_region_block tag block.
    /// </summary>
    public sealed class ModelVariantRegionBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelVariantRegionBlock"/> class.
        /// </summary>
        public ModelVariantRegionBlock()
        {
            this.Fields.Add(new StringIdField("region name^:must match region name in render_model"));
            this.Fields.Add(new PadField("", 1));
            this.Fields.Add(new PadField("", 1));
            this.Fields.Add(new ShortBlockIndexField("parent variant"));
            this.Fields.Add(new BlockField<ModelVariantPermutationBlock>("permutations", 32));
            this.Fields.Add(new EnumField("sort order#negative values mean closer to the camera", "no sorting", "-5 (closest)", "-4", "-3", "-2", "-1", "0 (same as model)", "1", "2", "3", "4", "5 (farthest)"));
            this.Fields.Add(new PadField("", 2));
        }
        /// <summary>
        /// Gets and returns the name of the model_variant_region_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "model_variant_region_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the model_variant_region_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "region";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the model_variant_region_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 16;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the model_variant_region_block tag block.
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