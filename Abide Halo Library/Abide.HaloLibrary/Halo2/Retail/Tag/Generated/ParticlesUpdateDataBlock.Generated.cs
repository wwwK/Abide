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
    /// Represents the generated particles_update_data_block tag block.
    /// </summary>
    public sealed class ParticlesUpdateDataBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ParticlesUpdateDataBlock"/> class.
        /// </summary>
        public ParticlesUpdateDataBlock()
        {
            this.Fields.Add(new RealField("velocity.x*"));
            this.Fields.Add(new RealField("velocity.y*"));
            this.Fields.Add(new RealField("velocity.z*"));
            this.Fields.Add(new PadField("", 12));
            this.Fields.Add(new RealField("mass*"));
            this.Fields.Add(new RealField("creation time stamp*"));
        }
        /// <summary>
        /// Gets and returns the name of the particles_update_data_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "particles_update_data_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the particles_update_data_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "particles_update_data_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the particles_update_data_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 4096;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the particles_update_data_block tag block.
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
