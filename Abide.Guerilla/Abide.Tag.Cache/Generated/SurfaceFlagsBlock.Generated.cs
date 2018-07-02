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
    /// Represents the generated surface_flags_block tag block.
    /// </summary>
    public sealed class SurfaceFlagsBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SurfaceFlagsBlock"/> class.
        /// </summary>
        public SurfaceFlagsBlock()
        {
            this.Fields.Add(new LongIntegerField("flags*"));
        }
        /// <summary>
        /// Gets and returns the name of the surface_flags_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "surface_flags_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the surface_flags_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "surface_flags_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the surface_flags_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 4096;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the surface_flags_block tag block.
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
