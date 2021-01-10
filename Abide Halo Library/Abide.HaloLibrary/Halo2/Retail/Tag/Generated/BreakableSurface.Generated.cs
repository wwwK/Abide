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
    /// Represents the generated breakable_surface (bsdt) tag group.
    /// </summary>
    internal class BreakableSurface : Group
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BreakableSurface"/> class.
        /// </summary>
        public BreakableSurface()
        {
            // Add tag block to list.
            this.TagBlocks.Add(new BreakableSurfaceBlock());
        }
        /// <summary>
        /// Gets and returns the name of the breakable_surface tag group.
        /// </summary>
        public override string GroupName
        {
            get
            {
                return "breakable_surface";
            }
        }
        /// <summary>
        /// Gets and returns the group tag of the breakable_surface tag group.
        /// </summary>
        public override TagFourCc GroupTag
        {
            get
            {
                return "bsdt";
            }
        }
    }
}
