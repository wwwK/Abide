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
    /// Represents the generated shader_gpu_state_struct_block tag block.
    /// </summary>
    internal sealed class ShaderGpuStateStructBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShaderGpuStateStructBlock"/> class.
        /// </summary>
        public ShaderGpuStateStructBlock()
        {
            this.Fields.Add(new BlockField<RenderStateBlock>("render states", 1024));
            this.Fields.Add(new BlockField<TextureStageStateBlock>("texture stage states", 1024));
            this.Fields.Add(new BlockField<RenderStateParameterBlock>("render state parameters", 1024));
            this.Fields.Add(new BlockField<TextureStageStateParameterBlock>("texture stage parameters", 1024));
            this.Fields.Add(new BlockField<TextureBlock>("textures", 1024));
            this.Fields.Add(new BlockField<VertexShaderConstantBlock>("Vn Constants", 1024));
            this.Fields.Add(new BlockField<VertexShaderConstantBlock>("Cn Constants", 1024));
        }
        /// <summary>
        /// Gets and returns the name of the shader_gpu_state_struct_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "shader_gpu_state_struct_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the shader_gpu_state_struct_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "shader_gpu_state_struct";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the shader_gpu_state_struct_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the shader_gpu_state_struct_block tag block.
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
