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
    /// Represents the generated collision_model (coll) tag group.
    /// </summary>
    public class CollisionModel : Group
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CollisionModel"/> class.
        /// </summary>
        public CollisionModel()
        {
            // Add tag block to list.
            this.TagBlocks.Add(new CollisionModelBlock());
        }
        /// <summary>
        /// Gets and returns the name of the collision_model tag group.
        /// </summary>
        public override string Name
        {
            get
            {
                return "collision_model";
            }
        }
        /// <summary>
        /// Gets and returns the group tag of the collision_model tag group.
        /// </summary>
        public override TagFourCc Tag
        {
            get
            {
                return "coll";
            }
        }
    }
}
