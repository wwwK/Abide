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
    /// Represents the generated item (item) tag group.
    /// </summary>
    internal class Item : Group
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Item"/> class.
        /// </summary>
        public Item()
        {
            // Add parent object tag block to list.
            this.TagBlocks.Add(new ObjectBlock());
            // Add tag block to list.
            this.TagBlocks.Add(new ItemBlock());
        }
        /// <summary>
        /// Gets and returns the name of the item tag group.
        /// </summary>
        public override string GroupName
        {
            get
            {
                return "item";
            }
        }
        /// <summary>
        /// Gets and returns the group tag of the item tag group.
        /// </summary>
        public override TagFourCc GroupTag
        {
            get
            {
                return "item";
            }
        }
    }
}
