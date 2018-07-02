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
    /// Represents the generated global_collision_bsp_block tag block.
    /// </summary>
    public sealed class GlobalCollisionBspBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalCollisionBspBlock"/> class.
        /// </summary>
        public GlobalCollisionBspBlock()
        {
            this.Fields.Add(new BlockField<Bsp3dNodesBlock>("BSP 3D Nodes*", 131072));
            this.Fields.Add(new BlockField<PlanesBlock>("Planes*", 65536));
            this.Fields.Add(new BlockField<LeavesBlock>("Leaves*", 65536));
            this.Fields.Add(new BlockField<Bsp2dReferencesBlock>("BSP 2D References*", 131072));
            this.Fields.Add(new BlockField<Bsp2dNodesBlock>("BSP 2D Nodes*", 131072));
            this.Fields.Add(new BlockField<SurfacesBlock>("Surfaces*", 131072));
            this.Fields.Add(new BlockField<EdgesBlock>("Edges*", 262144));
            this.Fields.Add(new BlockField<VerticesBlock>("Vertices*", 131072));
        }
        /// <summary>
        /// Gets and returns the name of the global_collision_bsp_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "global_collision_bsp_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the global_collision_bsp_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "global_collision_bsp_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the global_collision_bsp_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the global_collision_bsp_block tag block.
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
