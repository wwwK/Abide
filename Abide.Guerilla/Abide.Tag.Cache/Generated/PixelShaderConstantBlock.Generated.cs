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
    /// Represents the generated pixel_shader_constant_block tag block.
    /// </summary>
    public sealed class PixelShaderConstantBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PixelShaderConstantBlock"/> class.
        /// </summary>
        public PixelShaderConstantBlock()
        {
            this.Fields.Add(new CharEnumField("parameter type", "Bitmap", "Value", "Color", "Switch"));
            this.Fields.Add(new CharIntegerField("combiner index"));
            this.Fields.Add(new CharIntegerField("register index"));
            this.Fields.Add(new CharEnumField("component mask", "x (value)", "y (value)", "z (value)", "w (value)", "xyz/rgb (color)"));
            this.Fields.Add(new PadField("", 1));
            this.Fields.Add(new PadField("", 1));
        }
        /// <summary>
        /// Gets and returns the name of the pixel_shader_constant_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "pixel_shader_constant_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the pixel_shader_constant_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "pixel_shader_constant_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the pixel_shader_constant_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1024;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the pixel_shader_constant_block tag block.
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