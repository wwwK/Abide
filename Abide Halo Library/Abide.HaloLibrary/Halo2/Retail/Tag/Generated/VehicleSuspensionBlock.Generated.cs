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
    /// Represents the generated vehicle_suspension_block tag block.
    /// </summary>
    internal sealed class VehicleSuspensionBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VehicleSuspensionBlock"/> class.
        /// </summary>
        public VehicleSuspensionBlock()
        {
            this.Fields.Add(new StringIdField("label^"));
            this.Fields.Add(new StructField<AnimationIndexStructBlock>("animation*"));
            this.Fields.Add(new StringIdField("marker name"));
            this.Fields.Add(new RealField("mass point offset"));
            this.Fields.Add(new RealField("full extension ground_depth"));
            this.Fields.Add(new RealField("full compression ground_depth"));
            this.Fields.Add(new ExplanationField("Destroyed Suspension", "Only Necessary for suspensions with a destroyed state"));
            this.Fields.Add(new StringIdField("region name"));
            this.Fields.Add(new RealField("destroyed mass point offset"));
            this.Fields.Add(new RealField("destroyed full extension ground_depth"));
            this.Fields.Add(new RealField("destroyed full compression ground_depth"));
        }
        /// <summary>
        /// Gets and returns the name of the vehicle_suspension_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "vehicle_suspension_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the vehicle_suspension_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "vehicle_suspension_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the vehicle_suspension_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 32;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the vehicle_suspension_block tag block.
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
