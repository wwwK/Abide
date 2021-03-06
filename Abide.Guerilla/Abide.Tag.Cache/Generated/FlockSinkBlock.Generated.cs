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
    using System;
    using Abide.HaloLibrary;
    using Abide.Tag;
    
    /// <summary>
    /// Represents the generated flock_sink_block tag block.
    /// </summary>
    public sealed class FlockSinkBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FlockSinkBlock"/> class.
        /// </summary>
        public FlockSinkBlock()
        {
            this.Fields.Add(new RealVector3dField("position"));
            this.Fields.Add(new RealField("radius"));
        }
        /// <summary>
        /// Gets and returns the name of the flock_sink_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "flock_sink_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the flock_sink_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "flock_sink_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the flock_sink_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 10;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the flock_sink_block tag block.
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
