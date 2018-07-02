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
    /// Represents the generated global_subparts_block tag block.
    /// </summary>
    public sealed class GlobalSubpartsBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalSubpartsBlock"/> class.
        /// </summary>
        public GlobalSubpartsBlock()
        {
            this.Fields.Add(new ShortIntegerField("indices_start_index*"));
            this.Fields.Add(new ShortIntegerField("indices_length*"));
            this.Fields.Add(new ShortIntegerField("visibility_bounds_index*"));
            this.Fields.Add(new ShortIntegerField("Part Index*"));
        }
        /// <summary>
        /// Gets and returns the name of the global_subparts_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "global_subparts_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the global_subparts_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "subparts";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the global_subparts_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 32768;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the global_subparts_block tag block.
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
