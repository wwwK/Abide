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
    /// Represents the generated antenna_vertex_block tag block.
    /// </summary>
    public sealed class AntennaVertexBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AntennaVertexBlock"/> class.
        /// </summary>
        public AntennaVertexBlock()
        {
            this.Fields.Add(new RealFractionField("spring strength coefficient#strength of the spring (larger values make the spring" +
                        " stronger)"));
            this.Fields.Add(new PadField("", 24));
            this.Fields.Add(new EulerAngles2dField("angles#direction toward next vertex"));
            this.Fields.Add(new RealField("length:world units#distance between this vertex and the next"));
            this.Fields.Add(new ShortIntegerField("sequence index#bitmap group sequence index for this vertex\'s texture"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new RealArgbColorField("color#color at this vertex"));
            this.Fields.Add(new RealArgbColorField("LOD color#color at this vertex for the low-LOD line primitives"));
            this.Fields.Add(new PadField("", 40));
            this.Fields.Add(new PadField("", 12));
        }
        /// <summary>
        /// Gets and returns the name of the antenna_vertex_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "antenna_vertex_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the antenna_vertex_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "antenna_vertex_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the antenna_vertex_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 20;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the antenna_vertex_block tag block.
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
