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
    /// Represents the generated structure_bsp_instanced_geometry_instances_block tag block.
    /// </summary>
    public sealed class StructureBspInstancedGeometryInstancesBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StructureBspInstancedGeometryInstancesBlock"/> class.
        /// </summary>
        public StructureBspInstancedGeometryInstancesBlock()
        {
            this.Fields.Add(new RealField("Scale"));
            this.Fields.Add(new RealVector3dField("Forward"));
            this.Fields.Add(new RealVector3dField("Left"));
            this.Fields.Add(new RealVector3dField("Up"));
            this.Fields.Add(new RealPoint3dField("Position"));
            this.Fields.Add(new ShortBlockIndexField("Instance Definition*"));
            this.Fields.Add(new WordFlagsField("Flags", "Not in Lightprobes"));
            this.Fields.Add(new PadField("", 4));
            this.Fields.Add(new SkipField("", 12));
            this.Fields.Add(new SkipField("", 4));
            this.Fields.Add(new LongIntegerField("Checksum*"));
            this.Fields.Add(new StringIdField("Name*^"));
            this.Fields.Add(new EnumField("Pathfinding Policy*", "Cutout", "Static", "None"));
            this.Fields.Add(new EnumField("Lightmapping Policy*", "Per Pixel", "Per Vertex"));
        }
        /// <summary>
        /// Gets and returns the name of the structure_bsp_instanced_geometry_instances_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "structure_bsp_instanced_geometry_instances_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the structure_bsp_instanced_geometry_instances_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "structure_bsp_instanced_geometry_instances_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the structure_bsp_instanced_geometry_instances_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1024;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the structure_bsp_instanced_geometry_instances_block tag block.
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
