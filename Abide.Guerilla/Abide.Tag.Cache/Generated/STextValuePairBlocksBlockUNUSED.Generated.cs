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
    /// Represents the generated s_text_value_pair_blocks_block_UNUSED tag block.
    /// </summary>
    public sealed class STextValuePairBlocksBlockUNUSED : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="STextValuePairBlocksBlockUNUSED"/> class.
        /// </summary>
        public STextValuePairBlocksBlockUNUSED()
        {
            this.Fields.Add(new ExplanationField("OBSOLETE", "this is all obsolete"));
            this.Fields.Add(new StringField("name"));
            this.Fields.Add(new BlockField<STextValuePairReferenceBlockUNUSED>("text value pairs", 100));
        }
        /// <summary>
        /// Gets and returns the name of the s_text_value_pair_blocks_block_UNUSED tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "s_text_value_pair_blocks_block_UNUSED";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the s_text_value_pair_blocks_block_UNUSED tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "s_text_value_pair_blocks_block_UNUSED";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the s_text_value_pair_blocks_block_UNUSED tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 100;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the s_text_value_pair_blocks_block_UNUSED tag block.
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
