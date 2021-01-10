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
    /// Represents the generated effect_accelerations_block tag block.
    /// </summary>
    internal sealed class EffectAccelerationsBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EffectAccelerationsBlock"/> class.
        /// </summary>
        public EffectAccelerationsBlock()
        {
            this.Fields.Add(new EnumField("create in", "any environment", "air only", "water only", "space only"));
            this.Fields.Add(new EnumField("create in", "either mode", "violent mode only", "nonviolent mode only"));
            this.Fields.Add(new ShortBlockIndexField("location"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new RealField("acceleration"));
            this.Fields.Add(new RealField("inner cone angle:degrees"));
            this.Fields.Add(new RealField("outer cone angle:degrees"));
        }
        /// <summary>
        /// Gets and returns the name of the effect_accelerations_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "effect_accelerations_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the effect_accelerations_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "effect_accelerations_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the effect_accelerations_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 32;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the effect_accelerations_block tag block.
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
