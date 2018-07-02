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
    /// Represents the generated hud_number_block tag block.
    /// </summary>
    public sealed class HudNumberBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HudNumberBlock"/> class.
        /// </summary>
        public HudNumberBlock()
        {
            this.Fields.Add(new TagReferenceField("digits bitmap", "bitm"));
            this.Fields.Add(new CharIntegerField("bitmap digit width"));
            this.Fields.Add(new CharIntegerField("screen digit width"));
            this.Fields.Add(new CharIntegerField("x offset"));
            this.Fields.Add(new CharIntegerField("y offset"));
            this.Fields.Add(new CharIntegerField("decimal point width"));
            this.Fields.Add(new CharIntegerField("colon width"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new PadField("", 76));
        }
        /// <summary>
        /// Gets and returns the name of the hud_number_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "hud_number_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the hud_number_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "hud_number";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the hud_number_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the hud_number_block tag block.
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
