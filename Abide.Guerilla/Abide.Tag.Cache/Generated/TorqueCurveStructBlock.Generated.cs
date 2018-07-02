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
    using Abide.Tag;
    
    /// <summary>
    /// Represents the generated torque_curve_struct_block tag block.
    /// </summary>
    public sealed class TorqueCurveStructBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TorqueCurveStructBlock"/> class.
        /// </summary>
        public TorqueCurveStructBlock()
        {
            this.Fields.Add(new RealField("min torque"));
            this.Fields.Add(new RealField("max torque"));
            this.Fields.Add(new RealField("peak torque scale"));
            this.Fields.Add(new RealField("past peak torque exponent"));
            this.Fields.Add(new RealField("torque at max angular velocity#generally 0 for loading torque and something less " +
                        "than max torque for cruising torque"));
            this.Fields.Add(new RealField("torque at 2x max angular velocity"));
        }
        /// <summary>
        /// Gets and returns the name of the torque_curve_struct_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "torque_curve_struct_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the torque_curve_struct_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "torque_curve_struct";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the torque_curve_struct_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the torque_curve_struct_block tag block.
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
