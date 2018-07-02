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
    /// Represents the generated structure_bsp_cluster_debug_info_block tag block.
    /// </summary>
    public sealed class StructureBspClusterDebugInfoBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StructureBspClusterDebugInfoBlock"/> class.
        /// </summary>
        public StructureBspClusterDebugInfoBlock()
        {
            this.Fields.Add(new WordFlagsField("Errors*", "Multiple Fog Planes", "Fog Zone Collision", "Fog Zone Immersion"));
            this.Fields.Add(new WordFlagsField("Warnings*", "Multiple Visible Fog Planes", "Visible Fog Cluster Omission", "Fog Plane Missed Render-BSP"));
            this.Fields.Add(new PadField("", 28));
            this.Fields.Add(new BlockField<StructureBspDebugInfoRenderLineBlock>("Lines*", 32767));
            this.Fields.Add(new BlockField<StructureBspDebugInfoIndicesBlock>("Fog Plane Indices*", 32767));
            this.Fields.Add(new BlockField<StructureBspDebugInfoIndicesBlock>("Visible Fog Plane Indices*", 32767));
            this.Fields.Add(new BlockField<StructureBspDebugInfoIndicesBlock>("Vis. Fog Omission Cluster Indices*", 32767));
            this.Fields.Add(new BlockField<StructureBspDebugInfoIndicesBlock>("Containing Fog Zone Indices*", 32767));
        }
        /// <summary>
        /// Gets and returns the name of the structure_bsp_cluster_debug_info_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "structure_bsp_cluster_debug_info_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the structure_bsp_cluster_debug_info_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "structure_bsp_cluster_debug_info_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the structure_bsp_cluster_debug_info_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 512;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the structure_bsp_cluster_debug_info_block tag block.
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
