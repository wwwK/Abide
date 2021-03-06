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
    /// Represents the generated transparent_planes_block tag block.
    /// </summary>
    public sealed class TransparentPlanesBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransparentPlanesBlock"/> class.
        /// </summary>
        public TransparentPlanesBlock()
        {
            this.Fields.Add(new ShortIntegerField("Section Index"));
            this.Fields.Add(new ShortIntegerField("Part Index"));
            this.Fields.Add(new RealPlane3dField("plane"));
        }
        /// <summary>
        /// Gets and returns the name of the transparent_planes_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "transparent_planes_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the transparent_planes_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "transparent_planes_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the transparent_planes_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 32768;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the transparent_planes_block tag block.
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
