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
    
    [Abide.Guerilla.Tags.FieldSetAttribute(112, 4)]
    public class ShaderPropertiesBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("Diffuse Map*", typeof(TagReference))]
        public TagReference DiffuseMap;
        [Abide.Guerilla.Tags.FieldAttribute("Lightmap Emissive Map*", typeof(TagReference))]
        public TagReference LightmapEmissiveMap;
        [Abide.Guerilla.Tags.FieldAttribute("Lightmap Emissive Color*", typeof(ColorRgbF))]
        public ColorRgbF LightmapEmissiveColor;
        [Abide.Guerilla.Tags.FieldAttribute("Lightmap Emissive Power*", typeof(Single))]
        public Single LightmapEmissivePower;
        [Abide.Guerilla.Tags.FieldAttribute("Lightmap Resolution Scale*", typeof(Single))]
        public Single LightmapResolutionScale;
        [Abide.Guerilla.Tags.FieldAttribute("Lightmap Half Life*", typeof(Single))]
        public Single LightmapHalfLife;
        [Abide.Guerilla.Tags.FieldAttribute("Lightmap Diffuse Scale*", typeof(Single))]
        public Single LightmapDiffuseScale;
        [Abide.Guerilla.Tags.FieldAttribute("Alpha Test Map*", typeof(TagReference))]
        public TagReference AlphaTestMap;
        [Abide.Guerilla.Tags.FieldAttribute("Translucent Map*", typeof(TagReference))]
        public TagReference TranslucentMap;
        [Abide.Guerilla.Tags.FieldAttribute("Lightmap Transparent Color*", typeof(ColorRgbF))]
        public ColorRgbF LightmapTransparentColor;
        [Abide.Guerilla.Tags.FieldAttribute("Lightmap Transparent Alpha*", typeof(Single))]
        public Single LightmapTransparentAlpha;
        [Abide.Guerilla.Tags.FieldAttribute("Lightmap Foliage Scale*", typeof(Single))]
        public Single LightmapFoliageScale;
    }
}
#pragma warning restore CS1591