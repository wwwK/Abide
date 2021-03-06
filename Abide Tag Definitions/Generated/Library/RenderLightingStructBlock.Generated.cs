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
    /// Represents the generated render_lighting_struct_block tag block.
    /// </summary>
    public sealed class RenderLightingStructBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RenderLightingStructBlock"/> class.
        /// </summary>
        public RenderLightingStructBlock()
        {
            this.Fields.Add(new RealRgbColorField("Ambient"));
            this.Fields.Add(new RealVector3dField("Shadow Direction"));
            this.Fields.Add(new RealField("lighting_accuracy"));
            this.Fields.Add(new RealField("Shadow Opacity"));
            this.Fields.Add(new RealRgbColorField("Primary Direction Color"));
            this.Fields.Add(new RealVector3dField("Primary Direction"));
            this.Fields.Add(new RealRgbColorField("Secondary Direction Color"));
            this.Fields.Add(new RealVector3dField("Secondary Direction"));
            this.Fields.Add(new ShortIntegerField("sh Index"));
            this.Fields.Add(new PadField("", 2));
        }
        /// <summary>
        /// Gets and returns the name of the render_lighting_struct_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "render_lighting_struct_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the render_lighting_struct_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "render_lighting_struct";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the render_lighting_struct_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the render_lighting_struct_block tag block.
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
