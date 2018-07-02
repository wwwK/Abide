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
    /// Represents the generated global_geometry_point_data_struct_block tag block.
    /// </summary>
    public sealed class GlobalGeometryPointDataStructBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalGeometryPointDataStructBlock"/> class.
        /// </summary>
        public GlobalGeometryPointDataStructBlock()
        {
            this.Fields.Add(new BlockField<GlobalGeometryRawPointBlock>("Raw Points*", 32767));
            this.Fields.Add(new DataField("Runtime Point Data*", 1, 4));
            this.Fields.Add(new BlockField<GlobalGeometryRigidPointGroupBlock>("Rigid Point Groups*", 32767));
            this.Fields.Add(new BlockField<GlobalGeometryPointDataIndexBlock>("Vertex-Point Indices*", 32767));
        }
        /// <summary>
        /// Gets and returns the name of the global_geometry_point_data_struct_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "global_geometry_point_data_struct_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the global_geometry_point_data_struct_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "global_geometry_point_data_struct";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the global_geometry_point_data_struct_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the global_geometry_point_data_struct_block tag block.
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
