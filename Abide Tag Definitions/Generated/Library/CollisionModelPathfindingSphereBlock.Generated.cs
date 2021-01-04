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
    /// Represents the generated collision_model_pathfinding_sphere_block tag block.
    /// </summary>
    public sealed class CollisionModelPathfindingSphereBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CollisionModelPathfindingSphereBlock"/> class.
        /// </summary>
        public CollisionModelPathfindingSphereBlock()
        {
            this.Fields.Add(new ShortBlockIndexField("node*"));
            this.Fields.Add(new WordFlagsField("flags", "remains when open", "vehicle only", "with sectors"));
            this.Fields.Add(new RealPoint3dField("center*"));
            this.Fields.Add(new RealField("radius*"));
        }
        /// <summary>
        /// Gets and returns the name of the collision_model_pathfinding_sphere_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "collision_model_pathfinding_sphere_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the collision_model_pathfinding_sphere_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "sphere";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the collision_model_pathfinding_sphere_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 32;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the collision_model_pathfinding_sphere_block tag block.
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