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
    /// Represents the generated pixel_shader_block tag block.
    /// </summary>
    public sealed class PixelShaderBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PixelShaderBlock"/> class.
        /// </summary>
        public PixelShaderBlock()
        {
            this.Fields.Add(new PadField("", 4));
            this.Fields.Add(new DataField("compiled_shader", 1, 4));
        }
        /// <summary>
        /// Gets and returns the name of the pixel_shader_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "pixel_shader_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the pixel_shader_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "pixel_shader";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the pixel_shader_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the pixel_shader_block tag block.
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
