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
    /// Represents the generated structure_bsp_cluster_block tag block.
    /// </summary>
    internal sealed class StructureBspClusterBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StructureBspClusterBlock"/> class.
        /// </summary>
        public StructureBspClusterBlock()
        {
            this.Fields.Add(new StructField<GlobalGeometrySectionInfoStructBlock>("Section Info*"));
            this.Fields.Add(new StructField<GlobalGeometryBlockInfoStructBlock>("Geometry Block Info*"));
            this.Fields.Add(new BlockField<StructureBspClusterDataBlockNew>("Cluster Data*", 1));
            this.Fields.Add(new ExplanationField("CLUSTER INFO", ""));
            this.Fields.Add(new RealBoundsField("Bounds x*"));
            this.Fields.Add(new RealBoundsField("Bounds y*"));
            this.Fields.Add(new RealBoundsField("Bounds z*"));
            this.Fields.Add(new CharIntegerField("Scenario Sky Index*"));
            this.Fields.Add(new CharIntegerField("Media Index*"));
            this.Fields.Add(new CharIntegerField("Scenario Visible Sky Index*"));
            this.Fields.Add(new CharIntegerField("Scenario Atmospheric Fog Index*"));
            this.Fields.Add(new CharIntegerField("Planar Fog Designator*"));
            this.Fields.Add(new CharIntegerField("Visible Fog Plane Index*"));
            this.Fields.Add(new ShortBlockIndexField("Background Sound*"));
            this.Fields.Add(new ShortBlockIndexField("Sound Environment*"));
            this.Fields.Add(new ShortBlockIndexField("Weather*"));
            this.Fields.Add(new ShortIntegerField("Transition Structure BSP"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new PadField("", 4));
            this.Fields.Add(new WordFlagsField("Flags", "One-Way Portal", "Door Portal", "Postprocessed Geometry", "is the sky"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new BlockField<PredictedResourceBlock>("Predicted Resources*", 2048));
            this.Fields.Add(new BlockField<StructureBspClusterPortalIndexBlock>("Portals*", 512));
            this.Fields.Add(new LongIntegerField("Checksum from Structure*"));
            this.Fields.Add(new BlockField<StructureBspClusterInstancedGeometryIndexBlock>("Instanced Geometry Indices*", 1024));
            this.Fields.Add(new BlockField<GlobalGeometrySectionStripIndexBlock>("Index Reorder Table*", 65535));
            this.Fields.Add(new DataField("Collision mopp Code*", 1, 16));
        }
        /// <summary>
        /// Gets and returns the name of the structure_bsp_cluster_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "structure_bsp_cluster_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the structure_bsp_cluster_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "structure_bsp_cluster_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the structure_bsp_cluster_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 512;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the structure_bsp_cluster_block tag block.
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
