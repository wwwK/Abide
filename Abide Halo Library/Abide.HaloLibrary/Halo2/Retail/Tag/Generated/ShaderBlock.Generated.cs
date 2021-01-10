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
    /// Represents the generated shader_block tag block.
    /// </summary>
    internal sealed class ShaderBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShaderBlock"/> class.
        /// </summary>
        public ShaderBlock()
        {
            this.Fields.Add(new TagReferenceField("Template", 1937007981));
            this.Fields.Add(new StringIdField("Material Name"));
            this.Fields.Add(new BlockField<ShaderPropertiesBlock>("Runtime Properties*", 1));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new WordFlagsField("Flags", "Water", "Sort First", "No Active Camo"));
            this.Fields.Add(new BlockField<GlobalShaderParameterBlock>("Parameters", 64));
            this.Fields.Add(new BlockField<ShaderPostprocessDefinitionNewBlock>("Postprocess Definition*", 1));
            this.Fields.Add(new PadField("", 4));
            this.Fields.Add(new BlockField<PredictedResourceBlock>("Predicted Resources", 2048));
            this.Fields.Add(new TagReferenceField("Light Response", 1936484724));
            this.Fields.Add(new EnumField("Shader LOD Bias", "None", "4x Size", "2x Size", "1/2 Size", "1/4 Size", "Never", "Cinematic"));
            this.Fields.Add(new EnumField("Specular Type", "None", "Default", "Dull", "Shiny"));
            this.Fields.Add(new EnumField("Lightmap Type", "Diffuse", "Default Specular", "Dull Specular", "Shiny Specular"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new RealField("Lightmap Specular Brightness"));
            this.Fields.Add(new RealField("Lightmap Ambient Bias:[-1,1]"));
            this.Fields.Add(new RealField("Added depth bias offset"));
            this.Fields.Add(new RealField("Added depth bias slope scale"));
        }
        /// <summary>
        /// Gets and returns the name of the shader_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "shader_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the shader_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "shader";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the shader_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the shader_block tag block.
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
