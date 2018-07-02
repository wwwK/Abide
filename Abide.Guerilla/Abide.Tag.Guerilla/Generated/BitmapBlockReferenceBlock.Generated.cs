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
    /// Represents the generated bitmap_block_reference_block tag block.
    /// </summary>
    public sealed class BitmapBlockReferenceBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BitmapBlockReferenceBlock"/> class.
        /// </summary>
        public BitmapBlockReferenceBlock()
        {
            this.Fields.Add(new LongFlagsField("flags", "ignore for list skin size calculation", "swap on relative list position", "render as progress bar"));
            this.Fields.Add(new EnumField("animation index", "NONE", "00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63"));
            this.Fields.Add(new ShortIntegerField("intro animation delay milliseconds"));
            this.Fields.Add(new EnumField("bitmap blend method", "standard", "multiply", "UNUSED"));
            this.Fields.Add(new ShortIntegerField("initial sprite frame"));
            this.Fields.Add(new Point2dField("top-left"));
            this.Fields.Add(new RealField("horiz texture wraps/second"));
            this.Fields.Add(new RealField("vert texture wraps/second"));
            this.Fields.Add(new TagReferenceField("bitmap tag", "bitm"));
            this.Fields.Add(new ShortIntegerField("render depth bias"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new RealField("sprite animation speed fps"));
            this.Fields.Add(new Point2dField("progress bottom-left"));
            this.Fields.Add(new StringIdField("string identifier"));
            this.Fields.Add(new RealVector2dField("progress scale"));
        }
        /// <summary>
        /// Gets and returns the name of the bitmap_block_reference_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "bitmap_block_reference_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the bitmap_block_reference_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "bitmap_block_reference_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the bitmap_block_reference_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 64;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the bitmap_block_reference_block tag block.
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
