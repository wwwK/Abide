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
    
    /// <summary>
    /// Represents the generated polyhedron_plane_equations_block tag block.
    /// </summary>
    public sealed class PolyhedronPlaneEquationsBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PolyhedronPlaneEquationsBlock"/> class.
        /// </summary>
        public PolyhedronPlaneEquationsBlock()
        {
            this.Fields.Add(new SkipField("", 16));
        }
        /// <summary>
        /// Gets and returns the name of the polyhedron_plane_equations_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "polyhedron_plane_equations_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the polyhedron_plane_equations_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "polyhedron_plane_equations_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the polyhedron_plane_equations_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1024;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the polyhedron_plane_equations_block tag block.
        /// </summary>
        public override int Alignment
        {
            get
            {
                return 16;
            }
        }
    }
}
