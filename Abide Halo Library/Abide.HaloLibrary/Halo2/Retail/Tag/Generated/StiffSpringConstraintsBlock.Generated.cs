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
    /// Represents the generated stiff_spring_constraints_block tag block.
    /// </summary>
    internal sealed class StiffSpringConstraintsBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StiffSpringConstraintsBlock"/> class.
        /// </summary>
        public StiffSpringConstraintsBlock()
        {
            this.Fields.Add(new StructField<ConstraintBodiesStructBlock>("constraint bodies*"));
            this.Fields.Add(new PadField("", 4));
            this.Fields.Add(new RealField("spring_length*"));
        }
        /// <summary>
        /// Gets and returns the name of the stiff_spring_constraints_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "stiff_spring_constraints_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the stiff_spring_constraints_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "stiff_spring_constraints_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the stiff_spring_constraints_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 64;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the stiff_spring_constraints_block tag block.
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
