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
    using System;
    using Abide.HaloLibrary;
    using Abide.Tag;
    
    /// <summary>
    /// Represents the generated angular_velocity_lower_bound_struct_block tag block.
    /// </summary>
    public sealed class AngularVelocityLowerBoundStructBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AngularVelocityLowerBoundStructBlock"/> class.
        /// </summary>
        public AngularVelocityLowerBoundStructBlock()
        {
            this.Fields.Add(new AngleField("guided angular velocity (lower):degrees per second"));
        }
        /// <summary>
        /// Gets and returns the name of the angular_velocity_lower_bound_struct_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "angular_velocity_lower_bound_struct_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the angular_velocity_lower_bound_struct_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "angular_velocity_lower_bound_struct";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the angular_velocity_lower_bound_struct_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the angular_velocity_lower_bound_struct_block tag block.
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