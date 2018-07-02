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
    using HaloTag = Abide.HaloLibrary.TagFourCc;
    
    /// <summary>
    /// Represents the generated vehicle (vehi) tag group.
    /// </summary>
    public class Vehicle : Group
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Vehicle"/> class.
        /// </summary>
        public Vehicle()
        {
            // Add parent object tag block to list.
            this.TagBlocks.Add(new ObjectBlock());
            // Add parent unit tag block to list.
            this.TagBlocks.Add(new UnitBlock());
            // Add tag block to list.
            this.TagBlocks.Add(new VehicleBlock());
        }
        /// <summary>
        /// Gets and returns the name of the vehicle tag group.
        /// </summary>
        public override string Name
        {
            get
            {
                return "vehicle";
            }
        }
        /// <summary>
        /// Gets and returns the group tag of the vehicle tag group.
        /// </summary>
        public override HaloTag GroupTag
        {
            get
            {
                return "vehi";
            }
        }
    }
}
