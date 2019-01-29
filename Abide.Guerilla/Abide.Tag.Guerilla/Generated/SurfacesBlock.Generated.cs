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
    /// Represents the generated surfaces_block tag block.
    /// </summary>
    public sealed class SurfacesBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SurfacesBlock"/> class.
        /// </summary>
        public SurfacesBlock()
        {
            this.Fields.Add(new ShortIntegerField("Plane*"));
            this.Fields.Add(new ShortIntegerField("First Edge*"));
            this.Fields.Add(new ByteFlagsField("Flags*", "Two-Sided", "Invisible", "Climbable", "Breakable", "Invalid", "Conveyor"));
            this.Fields.Add(new CharIntegerField("Breakable Surface*"));
            this.Fields.Add(new ShortIntegerField("Material*"));
        }
        /// <summary>
        /// Gets and returns the name of the surfaces_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "surfaces_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the surfaces_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "surfaces_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the surfaces_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 131072;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the surfaces_block tag block.
        /// </summary>
        public override int Alignment
        {
            get
            {
                return 8;
            }
        }
    }
}