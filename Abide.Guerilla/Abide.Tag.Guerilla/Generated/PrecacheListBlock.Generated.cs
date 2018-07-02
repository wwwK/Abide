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
    /// Represents the generated precache_list_block tag block.
    /// </summary>
    public sealed class PrecacheListBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrecacheListBlock"/> class.
        /// </summary>
        public PrecacheListBlock()
        {
            this.Fields.Add(new LongIntegerField("cache block index"));
        }
        /// <summary>
        /// Gets and returns the name of the precache_list_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "precache_list_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the precache_list_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "precache_list_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the precache_list_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1024;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the precache_list_block tag block.
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
