#pragma warning disable CS1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Abide.Guerilla.Tags2
{
    using Abide.Guerilla.Types;
    using Abide.HaloLibrary;
    using System;
    
    [Abide.Guerilla.Tags.FieldSetAttribute(350, 4)]
    public class ShaderPassPostprocessImplementationNewBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("textures", typeof(TagBlockIndexStructBlock))]
        public TagBlockIndexStructBlock Textures;
        [Abide.Guerilla.Tags.FieldAttribute("render states", typeof(TagBlockIndexStructBlock))]
        public TagBlockIndexStructBlock RenderStates;
        [Abide.Guerilla.Tags.FieldAttribute("texture states", typeof(TagBlockIndexStructBlock))]
        public TagBlockIndexStructBlock TextureStates;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(240)]
        public Byte[] EmptyString;
        [Abide.Guerilla.Tags.FieldAttribute("ps fragments", typeof(TagBlockIndexStructBlock))]
        public TagBlockIndexStructBlock PsFragments;
        [Abide.Guerilla.Tags.FieldAttribute("ps permutations", typeof(TagBlockIndexStructBlock))]
        public TagBlockIndexStructBlock PsPermutations;
        [Abide.Guerilla.Tags.FieldAttribute("ps combiners", typeof(TagBlockIndexStructBlock))]
        public TagBlockIndexStructBlock PsCombiners;
        [Abide.Guerilla.Tags.FieldAttribute("vertex shader", typeof(TagReference))]
        public TagReference VertexShader;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(8)]
        public Byte[] EmptyString1;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(8)]
        public Byte[] EmptyString2;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(4)]
        public Byte[] EmptyString3;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(4)]
        public Byte[] EmptyString4;
        [Abide.Guerilla.Tags.FieldAttribute("default render states", typeof(TagBlockIndexStructBlock))]
        public TagBlockIndexStructBlock DefaultRenderStates;
        [Abide.Guerilla.Tags.FieldAttribute("render state externs", typeof(TagBlockIndexStructBlock))]
        public TagBlockIndexStructBlock RenderStateExterns;
        [Abide.Guerilla.Tags.FieldAttribute("texture state externs", typeof(TagBlockIndexStructBlock))]
        public TagBlockIndexStructBlock TextureStateExterns;
        [Abide.Guerilla.Tags.FieldAttribute("pixel constant externs", typeof(TagBlockIndexStructBlock))]
        public TagBlockIndexStructBlock PixelConstantExterns;
        [Abide.Guerilla.Tags.FieldAttribute("vertex constant externs", typeof(TagBlockIndexStructBlock))]
        public TagBlockIndexStructBlock VertexConstantExterns;
        [Abide.Guerilla.Tags.FieldAttribute("ps constants", typeof(TagBlockIndexStructBlock))]
        public TagBlockIndexStructBlock PsConstants;
        [Abide.Guerilla.Tags.FieldAttribute("vs constants", typeof(TagBlockIndexStructBlock))]
        public TagBlockIndexStructBlock VsConstants;
        [Abide.Guerilla.Tags.FieldAttribute("pixel constant info", typeof(TagBlockIndexStructBlock))]
        public TagBlockIndexStructBlock PixelConstantInfo;
        [Abide.Guerilla.Tags.FieldAttribute("vertex constant info", typeof(TagBlockIndexStructBlock))]
        public TagBlockIndexStructBlock VertexConstantInfo;
        [Abide.Guerilla.Tags.FieldAttribute("render state info", typeof(TagBlockIndexStructBlock))]
        public TagBlockIndexStructBlock RenderStateInfo;
        [Abide.Guerilla.Tags.FieldAttribute("texture state info", typeof(TagBlockIndexStructBlock))]
        public TagBlockIndexStructBlock TextureStateInfo;
        [Abide.Guerilla.Tags.FieldAttribute("pixel shader", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("Shader Postprocess Pixel Shader", 100, typeof(ShaderPostprocessPixelShader))]
        public TagBlock PixelShader;
        [Abide.Guerilla.Tags.FieldAttribute("pixel shader switch extern map", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("Pixel Shader Extern Map Block", 6, typeof(PixelShaderExternMapBlock))]
        public TagBlock PixelShaderSwitchExternMap;
        [Abide.Guerilla.Tags.FieldAttribute("pixel shader index block", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("Pixel Shader Index Block", 100, typeof(PixelShaderIndexBlock))]
        public TagBlock PixelShaderIndexBlock;
    }
}
#pragma warning restore CS1591