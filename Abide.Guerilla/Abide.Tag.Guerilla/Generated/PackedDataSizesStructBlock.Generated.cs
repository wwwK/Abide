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
    using Abide.Tag;
    
    /// <summary>
    /// Represents the generated packed_data_sizes_struct_block tag block.
    /// </summary>
    public sealed class PackedDataSizesStructBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PackedDataSizesStructBlock"/> class.
        /// </summary>
        public PackedDataSizesStructBlock()
        {
            this.Fields.Add(new CharIntegerField(""));
            this.Fields.Add(new CharIntegerField(""));
            this.Fields.Add(new ShortIntegerField(""));
            this.Fields.Add(new ShortIntegerField(""));
            this.Fields.Add(new ShortIntegerField(""));
            this.Fields.Add(new LongIntegerField(""));
            this.Fields.Add(new LongIntegerField(""));
        }
        /// <summary>
        /// Gets and returns the name of the packed_data_sizes_struct_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "packed_data_sizes_struct_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the packed_data_sizes_struct_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "packed_data_sizes_struct";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the packed_data_sizes_struct_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the packed_data_sizes_struct_block tag block.
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
