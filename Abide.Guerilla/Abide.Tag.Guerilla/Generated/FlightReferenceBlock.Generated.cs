//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Abide.Tag.Guerilla.Generated
{
    using System;
    using Abide.HaloLibrary;
    using Abide.Tag;
    
    /// <summary>
    /// Represents the generated flight_reference_block tag block.
    /// </summary>
    public sealed class FlightReferenceBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FlightReferenceBlock"/> class.
        /// </summary>
        public FlightReferenceBlock()
        {
            this.Fields.Add(new ShortIntegerField("flight hint index"));
            this.Fields.Add(new ShortIntegerField("poit index"));
        }
        /// <summary>
        /// Gets and returns the name of the flight_reference_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "flight_reference_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the flight_reference_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "flight_reference_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the flight_reference_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 10;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the flight_reference_block tag block.
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
