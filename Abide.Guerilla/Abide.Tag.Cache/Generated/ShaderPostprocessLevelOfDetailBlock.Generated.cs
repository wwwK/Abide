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
    /// Represents the generated shader_postprocess_level_of_detail_block tag block.
    /// </summary>
    public sealed class ShaderPostprocessLevelOfDetailBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShaderPostprocessLevelOfDetailBlock"/> class.
        /// </summary>
        public ShaderPostprocessLevelOfDetailBlock()
        {
            this.Fields.Add(new RealField("projected height percentage"));
            this.Fields.Add(new LongIntegerField("available layers"));
            this.Fields.Add(new BlockField<ShaderPostprocessLayerBlock>("layers", 25));
            this.Fields.Add(new BlockField<ShaderPostprocessPassBlock>("passes", 1024));
            this.Fields.Add(new BlockField<ShaderPostprocessImplementationBlock>("implementations", 1024));
            this.Fields.Add(new BlockField<ShaderPostprocessBitmapBlock>("bitmaps", 1024));
            this.Fields.Add(new BlockField<ShaderPostprocessBitmapTransformBlock>("bitmap transforms", 1024));
            this.Fields.Add(new BlockField<ShaderPostprocessValueBlock>("values", 1024));
            this.Fields.Add(new BlockField<ShaderPostprocessColorBlock>("colors", 1024));
            this.Fields.Add(new BlockField<ShaderPostprocessBitmapTransformOverlayBlock>("bitmap transform overlays", 1024));
            this.Fields.Add(new BlockField<ShaderPostprocessValueOverlayBlock>("value overlays", 1024));
            this.Fields.Add(new BlockField<ShaderPostprocessColorOverlayBlock>("color overlays", 1024));
            this.Fields.Add(new BlockField<ShaderPostprocessVertexShaderConstantBlock>("vertex shader constants", 1024));
            this.Fields.Add(new StructField<ShaderGpuStateStructBlock>("GPU State"));
        }
        /// <summary>
        /// Gets and returns the name of the shader_postprocess_level_of_detail_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "shader_postprocess_level_of_detail_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the shader_postprocess_level_of_detail_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "shader_postprocess_level_of_detail_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the shader_postprocess_level_of_detail_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1024;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the shader_postprocess_level_of_detail_block tag block.
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
