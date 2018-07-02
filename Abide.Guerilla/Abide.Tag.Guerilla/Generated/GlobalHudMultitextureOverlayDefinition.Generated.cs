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
    /// Represents the generated global_hud_multitexture_overlay_definition tag block.
    /// </summary>
    public sealed class GlobalHudMultitextureOverlayDefinition : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalHudMultitextureOverlayDefinition"/> class.
        /// </summary>
        public GlobalHudMultitextureOverlayDefinition()
        {
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new ShortIntegerField("type"));
            this.Fields.Add(new EnumField("framebuffer blend func", "alpha blend", "multiply", "double multiply", "add", "subtract", "component min", "component max", "alpha-multiply add", "constant color blend", "inverse constant color blend", "none"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new PadField("", 32));
            this.Fields.Add(new ExplanationField("anchors", "where you want the origin of the texture.\n*\"texture\" uses the texture coordinates" +
                        " supplied\n*\"screen\" uses the origin of the screen as the origin of the texture"));
            this.Fields.Add(new EnumField("primary anchor", "texture", "screen"));
            this.Fields.Add(new EnumField("secondary anchor", "texture", "screen"));
            this.Fields.Add(new EnumField("tertiary anchor", "texture", "screen"));
            this.Fields.Add(new ExplanationField("blending function", "how to blend the textures together"));
            this.Fields.Add(new EnumField("0 to 1 blend func", "add", "subtract", "multiply", "multiply2x", "dot"));
            this.Fields.Add(new EnumField("1 to 2 blend func", "add", "subtract", "multiply", "multiply2x", "dot"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new ExplanationField("map scales", "how much to scale the textures"));
            this.Fields.Add(new RealPoint2dField("primary scale"));
            this.Fields.Add(new RealPoint2dField("secondary scale"));
            this.Fields.Add(new RealPoint2dField("tertiary scale"));
            this.Fields.Add(new ExplanationField("map offsets", "how much to offset the origin of the texture"));
            this.Fields.Add(new RealPoint2dField("primary offset"));
            this.Fields.Add(new RealPoint2dField("secondary offset"));
            this.Fields.Add(new RealPoint2dField("tertiary offset"));
            this.Fields.Add(new ExplanationField("map", "which maps to use"));
            this.Fields.Add(new TagReferenceField("primary", "bitm"));
            this.Fields.Add(new TagReferenceField("secondary", "bitm"));
            this.Fields.Add(new TagReferenceField("tertiary", "bitm"));
            this.Fields.Add(new EnumField("primary wrap mode", "clamp", "wrap"));
            this.Fields.Add(new EnumField("secondary wrap mode", "clamp", "wrap"));
            this.Fields.Add(new EnumField("tertiary wrap mode", "clamp", "wrap"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new PadField("", 184));
            this.Fields.Add(new BlockField<GlobalHudMultitextureOverlayEffectorDefinition>("effectors", 30));
            this.Fields.Add(new PadField("", 128));
        }
        /// <summary>
        /// Gets and returns the name of the global_hud_multitexture_overlay_definition tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "global_hud_multitexture_overlay_definition";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the global_hud_multitexture_overlay_definition tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "global_hud_multitexture_overlay_definition";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the global_hud_multitexture_overlay_definition tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 30;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the global_hud_multitexture_overlay_definition tag block.
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
