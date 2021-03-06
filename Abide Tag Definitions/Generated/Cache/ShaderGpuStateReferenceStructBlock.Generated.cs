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
    /// Represents the generated shader_gpu_state_reference_struct_block tag block.
    /// </summary>
    public sealed class ShaderGpuStateReferenceStructBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShaderGpuStateReferenceStructBlock"/> class.
        /// </summary>
        public ShaderGpuStateReferenceStructBlock()
        {
            this.Fields.Add(new StructField<TagBlockIndexStructBlock>("render states"));
            this.Fields.Add(new StructField<TagBlockIndexStructBlock>("texture stage states"));
            this.Fields.Add(new StructField<TagBlockIndexStructBlock>("render state parameters"));
            this.Fields.Add(new StructField<TagBlockIndexStructBlock>("texture stage parameters"));
            this.Fields.Add(new StructField<TagBlockIndexStructBlock>("textures"));
            this.Fields.Add(new StructField<TagBlockIndexStructBlock>("Vn Constants"));
            this.Fields.Add(new StructField<TagBlockIndexStructBlock>("Cn Constants"));
        }
        /// <summary>
        /// Gets and returns the name of the shader_gpu_state_reference_struct_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "shader_gpu_state_reference_struct_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the shader_gpu_state_reference_struct_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "shader_gpu_state_reference_struct";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the shader_gpu_state_reference_struct_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the shader_gpu_state_reference_struct_block tag block.
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
