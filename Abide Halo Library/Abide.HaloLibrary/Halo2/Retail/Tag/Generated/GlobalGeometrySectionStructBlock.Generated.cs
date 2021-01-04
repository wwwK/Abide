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
    /// Represents the generated global_geometry_section_struct_block tag block.
    /// </summary>
    public sealed class GlobalGeometrySectionStructBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalGeometrySectionStructBlock"/> class.
        /// </summary>
        public GlobalGeometrySectionStructBlock()
        {
            this.Fields.Add(new BlockField<GlobalGeometryPartBlockNew>("Parts*", 255));
            this.Fields.Add(new BlockField<GlobalSubpartsBlock>("Subparts*", 32768));
            this.Fields.Add(new BlockField<GlobalVisibilityBoundsBlock>("Visibility Bounds*", 32768));
            this.Fields.Add(new BlockField<GlobalGeometrySectionRawVertexBlock>("Raw Vertices*", 32767));
            this.Fields.Add(new BlockField<GlobalGeometrySectionStripIndexBlock>("Strip Indices*", 65535));
            this.Fields.Add(new DataField("Visibility mopp Code*", 1, 16));
            this.Fields.Add(new BlockField<GlobalGeometrySectionStripIndexBlock>("mopp Reorder Table*", 65535));
            this.Fields.Add(new BlockField<GlobalGeometrySectionVertexBufferBlock>("Vertex Buffers*", 512));
            this.Fields.Add(new PadField("", 4));
        }
        /// <summary>
        /// Gets and returns the name of the global_geometry_section_struct_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "global_geometry_section_struct_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the global_geometry_section_struct_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "global_geometry_section_struct";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the global_geometry_section_struct_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the global_geometry_section_struct_block tag block.
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
