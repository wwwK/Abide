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
    /// Represents the generated item (item) tag group.
    /// </summary>
    public class Item : Group
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
        public override string Name
        {
            get
            {
                return "item";
            }
        }
        /// <summary>
        /// Gets and returns the group tag of the item tag group.
        /// </summary>
        public override HaloTag GroupTag
        {
            get
            {
                return "item";
            }
        }
    }
}