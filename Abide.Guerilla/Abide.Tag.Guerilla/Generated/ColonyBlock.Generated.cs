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
    /// Represents the generated colony_block tag block.
    /// </summary>
    public sealed class ColonyBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ColonyBlock"/> class.
        /// </summary>
        public ColonyBlock()
        {
            this.Fields.Add(new WordFlagsField("flags", "unused"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new PadField("", 4));
            this.Fields.Add(new RealBoundsField("radius"));
            this.Fields.Add(new PadField("", 12));
            this.Fields.Add(new RealArgbColorField("debug color"));
            this.Fields.Add(new TagReferenceField("base map", 1651078253));
            this.Fields.Add(new TagReferenceField("detail map", 1651078253));
        }
        /// <summary>
        /// Gets and returns the name of the colony_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "colony_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the colony_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "colony";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the colony_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the colony_block tag block.
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
