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
    /// Represents the generated style_palette_block tag block.
    /// </summary>
    public sealed class StylePaletteBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StylePaletteBlock"/> class.
        /// </summary>
        public StylePaletteBlock()
        {
            this.Fields.Add(new TagReferenceField("reference^", "styl"));
        }
        /// <summary>
        /// Gets and returns the name of the style_palette_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "style_palette_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the style_palette_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "style_palette_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the style_palette_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 50;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the style_palette_block tag block.
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
