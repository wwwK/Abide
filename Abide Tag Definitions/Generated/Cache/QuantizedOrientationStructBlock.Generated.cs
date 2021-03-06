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
    /// Represents the generated quantized_orientation_struct_block tag block.
    /// </summary>
    public sealed class QuantizedOrientationStructBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuantizedOrientationStructBlock"/> class.
        /// </summary>
        public QuantizedOrientationStructBlock()
        {
            this.Fields.Add(new ShortIntegerField("rotation x*"));
            this.Fields.Add(new ShortIntegerField("rotation y*"));
            this.Fields.Add(new ShortIntegerField("rotation z*"));
            this.Fields.Add(new ShortIntegerField("rotation w*"));
            this.Fields.Add(new RealPoint3dField("default translation*"));
            this.Fields.Add(new RealField("default scale*"));
        }
        /// <summary>
        /// Gets and returns the name of the quantized_orientation_struct_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "quantized_orientation_struct_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the quantized_orientation_struct_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "quantized_orientation_struct";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the quantized_orientation_struct_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the quantized_orientation_struct_block tag block.
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
