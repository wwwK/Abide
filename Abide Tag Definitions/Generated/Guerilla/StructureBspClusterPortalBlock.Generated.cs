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
    using System;
    using Abide.HaloLibrary;
    using Abide.Tag;
    
    /// <summary>
    /// Represents the generated structure_bsp_cluster_portal_block tag block.
    /// </summary>
    public sealed class StructureBspClusterPortalBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StructureBspClusterPortalBlock"/> class.
        /// </summary>
        public StructureBspClusterPortalBlock()
        {
            this.Fields.Add(new ShortIntegerField("Back Cluster*"));
            this.Fields.Add(new ShortIntegerField("Front Cluster*"));
            this.Fields.Add(new LongIntegerField("Plane Index*"));
            this.Fields.Add(new RealPoint3dField("Centroid*"));
            this.Fields.Add(new RealField("Bounding Radius*"));
            this.Fields.Add(new LongFlagsField("Flags*", "AI Cannot Hear through This", "One-Way", "Door", "No-Way", "One-Way Reversed", "No One Can Hear through This"));
            this.Fields.Add(new BlockField<StructureBspClusterPortalVertexBlock>("Vertices*", 128));
        }
        /// <summary>
        /// Gets and returns the name of the structure_bsp_cluster_portal_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "structure_bsp_cluster_portal_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the structure_bsp_cluster_portal_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "structure_bsp_cluster_portal_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the structure_bsp_cluster_portal_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 512;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the structure_bsp_cluster_portal_block tag block.
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
