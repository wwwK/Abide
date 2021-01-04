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
    /// Represents the generated byte_block tag block.
    /// </summary>
    public sealed class ByteBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ByteBlock"/> class.
        /// </summary>
        public ByteBlock()
        {
            this.Fields.Add(new CharIntegerField("Value"));
        }
        /// <summary>
        /// Gets and returns the name of the byte_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "byte_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the byte_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "byte_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the byte_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1024;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the byte_block tag block.
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
