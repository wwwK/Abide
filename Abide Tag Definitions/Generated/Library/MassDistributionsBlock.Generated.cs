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
    /// Represents the generated mass_distributions_block tag block.
    /// </summary>
    public sealed class MassDistributionsBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MassDistributionsBlock"/> class.
        /// </summary>
        public MassDistributionsBlock()
        {
            this.Fields.Add(new RealVector3dField("center of mass*"));
            this.Fields.Add(new SkipField("", 4));
            this.Fields.Add(new RealVector3dField("inertia tensor i*"));
            this.Fields.Add(new SkipField("", 4));
            this.Fields.Add(new RealVector3dField("inertia tensor j*"));
            this.Fields.Add(new SkipField("", 4));
            this.Fields.Add(new RealVector3dField("inertia tensor k*"));
            this.Fields.Add(new SkipField("", 4));
        }
        /// <summary>
        /// Gets and returns the name of the mass_distributions_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "mass_distributions_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the mass_distributions_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "mass_distributions_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the mass_distributions_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 256;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the mass_distributions_block tag block.
        /// </summary>
        public override int Alignment
        {
            get
            {
                return 16;
            }
        }
    }
}