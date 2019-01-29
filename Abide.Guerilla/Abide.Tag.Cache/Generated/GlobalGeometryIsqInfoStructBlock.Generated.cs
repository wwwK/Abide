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
    /// Represents the generated global_geometry_isq_info_struct_block tag block.
    /// </summary>
    public sealed class GlobalGeometryIsqInfoStructBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalGeometryIsqInfoStructBlock"/> class.
        /// </summary>
        public GlobalGeometryIsqInfoStructBlock()
        {
            this.Fields.Add(new WordFlagsField("Flags*", "Compressed Planes", "Swizzled Planes"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new BlockField<GlobalGeometryPlaneBlock>("Raw Planes*", 65535));
            this.Fields.Add(new DataField("Runtime Plane Data*", 1));
            this.Fields.Add(new BlockField<GlobalGeometryRigidPlaneGroupBlock>("Rigid Plane Groups*", 65280));
            this.Fields.Add(new PadField("", 32));
            this.Fields.Add(new BlockField<GlobalGeometryExplicitEdgeBlock>("Explicit Edges*", 65535));
        }
        /// <summary>
        /// Gets and returns the name of the global_geometry_isq_info_struct_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "global_geometry_isq_info_struct_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the global_geometry_isq_info_struct_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "global_geometry_isq_info_struct";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the global_geometry_isq_info_struct_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the global_geometry_isq_info_struct_block tag block.
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