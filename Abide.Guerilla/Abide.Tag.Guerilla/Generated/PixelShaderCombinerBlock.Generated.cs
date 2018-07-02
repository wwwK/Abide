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
    /// Represents the generated pixel_shader_combiner_block tag block.
    /// </summary>
    public sealed class PixelShaderCombinerBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PixelShaderCombinerBlock"/> class.
        /// </summary>
        public PixelShaderCombinerBlock()
        {
            this.Fields.Add(new PadField("", 16));
            this.Fields.Add(new ArgbColorField("constant color0"));
            this.Fields.Add(new ArgbColorField("constant color1"));
            this.Fields.Add(new CharIntegerField("color A register ptr index"));
            this.Fields.Add(new CharIntegerField("color B register ptr index"));
            this.Fields.Add(new CharIntegerField("color C register ptr index"));
            this.Fields.Add(new CharIntegerField("color D register ptr index"));
            this.Fields.Add(new CharIntegerField("alpha A register ptr index"));
            this.Fields.Add(new CharIntegerField("alpha B register ptr index"));
            this.Fields.Add(new CharIntegerField("alpha C register ptr index"));
            this.Fields.Add(new CharIntegerField("alpha D register ptr index"));
        }
        /// <summary>
        /// Gets and returns the name of the pixel_shader_combiner_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "pixel_shader_combiner_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the pixel_shader_combiner_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "pixel_shader_combiner_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the pixel_shader_combiner_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1024;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the pixel_shader_combiner_block tag block.
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
