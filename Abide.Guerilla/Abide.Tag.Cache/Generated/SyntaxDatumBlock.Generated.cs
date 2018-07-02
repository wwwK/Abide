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
    /// Represents the generated syntax_datum_block tag block.
    /// </summary>
    public sealed class SyntaxDatumBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SyntaxDatumBlock"/> class.
        /// </summary>
        public SyntaxDatumBlock()
        {
            this.Fields.Add(new ShortIntegerField("Datum Header"));
            this.Fields.Add(new ShortIntegerField("Script Index/Function Index/Constant Type Union"));
            this.Fields.Add(new ShortIntegerField("Type"));
            this.Fields.Add(new ShortIntegerField("Flags"));
            this.Fields.Add(new LongIntegerField("Next Node Index"));
            this.Fields.Add(new LongIntegerField("Data"));
            this.Fields.Add(new TagIndexField("source_offset"));
        }
        /// <summary>
        /// Gets and returns the name of the syntax_datum_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "syntax_datum_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the syntax_datum_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "syntax_datum_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the syntax_datum_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 36864;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the syntax_datum_block tag block.
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
