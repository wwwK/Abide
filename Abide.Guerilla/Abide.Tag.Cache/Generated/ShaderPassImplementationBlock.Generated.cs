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
    /// Represents the generated shader_pass_implementation_block tag block.
    /// </summary>
    public sealed class ShaderPassImplementationBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShaderPassImplementationBlock"/> class.
        /// </summary>
        public ShaderPassImplementationBlock()
        {
            this.Fields.Add(new WordFlagsField("Flags", "Delete from Cache File", "Critical"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new BlockField<ShaderPassTextureBlock>("Textures", 8));
            this.Fields.Add(new ExplanationField("VERTEX SHADER", ""));
            this.Fields.Add(new TagReferenceField("Vertex Shader", "vrtx"));
            this.Fields.Add(new BlockField<ShaderPassVertexShaderConstantBlock>("vs Constants", 32));
            this.Fields.Add(new DataField("Pixel Shader Code [NO LONGER USED]", 1, 4));
            this.Fields.Add(new ExplanationField("STATE", ""));
            this.Fields.Add(new EnumField("channels", "all", "color only", "alpha only", "custom"));
            this.Fields.Add(new EnumField("alpha-blend", "disabled", "add", "multiply", "add src times dstalpha", "add src times srcalpha", "add dst times srcalpha inverse", "alpha blend", "custom"));
            this.Fields.Add(new EnumField("depth", "disabled", "default opaque", "default opaque write", "default transparent", "custom"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new BlockField<ShaderStateChannelsStateBlock>("channel state", 1));
            this.Fields.Add(new BlockField<ShaderStateAlphaBlendStateBlock>("alpha-blend state", 1));
            this.Fields.Add(new BlockField<ShaderStateAlphaTestStateBlock>("alpha-test state", 1));
            this.Fields.Add(new BlockField<ShaderStateDepthStateBlock>("depth state", 1));
            this.Fields.Add(new BlockField<ShaderStateCullStateBlock>("cull state", 1));
            this.Fields.Add(new BlockField<ShaderStateFillStateBlock>("fill state", 1));
            this.Fields.Add(new BlockField<ShaderStateMiscStateBlock>("misc state", 1));
            this.Fields.Add(new BlockField<ShaderStateConstantBlock>("constants", 7));
            this.Fields.Add(new TagReferenceField("Pixel Shader", "pixl"));
        }
        /// <summary>
        /// Gets and returns the name of the shader_pass_implementation_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "shader_pass_implementation_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the shader_pass_implementation_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "implementation";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the shader_pass_implementation_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 32;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the shader_pass_implementation_block tag block.
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
