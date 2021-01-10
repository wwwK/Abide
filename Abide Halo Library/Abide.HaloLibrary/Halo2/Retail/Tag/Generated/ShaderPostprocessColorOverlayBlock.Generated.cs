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
    /// Represents the generated shader_postprocess_color_overlay_block tag block.
    /// </summary>
    internal sealed class ShaderPostprocessColorOverlayBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShaderPostprocessColorOverlayBlock"/> class.
        /// </summary>
        public ShaderPostprocessColorOverlayBlock()
        {
            this.Fields.Add(new CharIntegerField("parameter index"));
            this.Fields.Add(new StringIdField("input name"));
            this.Fields.Add(new StringIdField("range name"));
            this.Fields.Add(new RealField("time period in seconds"));
            this.Fields.Add(new StructField<ColorFunctionStructBlock>("function"));
        }
        /// <summary>
        /// Gets and returns the name of the shader_postprocess_color_overlay_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "shader_postprocess_color_overlay_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the shader_postprocess_color_overlay_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "shader_postprocess_color_overlay_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the shader_postprocess_color_overlay_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1024;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the shader_postprocess_color_overlay_block tag block.
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
