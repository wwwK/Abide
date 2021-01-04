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
    /// Represents the generated shader_pass_postprocess_implementation_new_block tag block.
    /// </summary>
    public sealed class ShaderPassPostprocessImplementationNewBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShaderPassPostprocessImplementationNewBlock"/> class.
        /// </summary>
        public ShaderPassPostprocessImplementationNewBlock()
        {
            this.Fields.Add(new StructField<TagBlockIndexStructBlock>("textures"));
            this.Fields.Add(new StructField<TagBlockIndexStructBlock>("render states"));
            this.Fields.Add(new StructField<TagBlockIndexStructBlock>("texture states"));
            this.Fields.Add(new SkipField("", 240));
            this.Fields.Add(new StructField<TagBlockIndexStructBlock>("ps fragments"));
            this.Fields.Add(new StructField<TagBlockIndexStructBlock>("ps permutations"));
            this.Fields.Add(new StructField<TagBlockIndexStructBlock>("ps combiners"));
            this.Fields.Add(new TagReferenceField("vertex shader", 1987212408));
            this.Fields.Add(new SkipField("", 8));
            this.Fields.Add(new SkipField("", 8));
            this.Fields.Add(new SkipField("", 4));
            this.Fields.Add(new SkipField("", 4));
            this.Fields.Add(new StructField<TagBlockIndexStructBlock>("default render states"));
            this.Fields.Add(new StructField<TagBlockIndexStructBlock>("render state externs"));
            this.Fields.Add(new StructField<TagBlockIndexStructBlock>("texture state externs"));
            this.Fields.Add(new StructField<TagBlockIndexStructBlock>("pixel constant externs"));
            this.Fields.Add(new StructField<TagBlockIndexStructBlock>("vertex constant externs"));
            this.Fields.Add(new StructField<TagBlockIndexStructBlock>("ps constants"));
            this.Fields.Add(new StructField<TagBlockIndexStructBlock>("vs constants"));
            this.Fields.Add(new StructField<TagBlockIndexStructBlock>("pixel constant info"));
            this.Fields.Add(new StructField<TagBlockIndexStructBlock>("vertex constant info"));
            this.Fields.Add(new StructField<TagBlockIndexStructBlock>("render state info"));
            this.Fields.Add(new StructField<TagBlockIndexStructBlock>("texture state info"));
        }
        /// <summary>
        /// Gets and returns the name of the shader_pass_postprocess_implementation_new_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "shader_pass_postprocess_implementation_new_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the shader_pass_postprocess_implementation_new_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "shader_pass_postprocess_implementation_new_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the shader_pass_postprocess_implementation_new_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1024;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the shader_pass_postprocess_implementation_new_block tag block.
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