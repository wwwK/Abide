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
    /// Represents the generated vehicle_permutation tag block.
    /// </summary>
    internal sealed class VehiclePermutation : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VehiclePermutation"/> class.
        /// </summary>
        public VehiclePermutation()
        {
            this.Fields.Add(new RealField("weight#relatively how likely this vehicle will be chosen"));
            this.Fields.Add(new TagReferenceField("vehicle^#which vehicle to ", 1986357353));
            this.Fields.Add(new StringIdField("variant name"));
        }
        /// <summary>
        /// Gets and returns the name of the vehicle_permutation tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "vehicle_permutation";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the vehicle_permutation tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "vehicle_permutation";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the vehicle_permutation tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 32;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the vehicle_permutation tag block.
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
