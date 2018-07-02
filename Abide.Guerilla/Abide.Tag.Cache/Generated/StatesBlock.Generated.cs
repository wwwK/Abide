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
    /// Represents the generated states_block tag block.
    /// </summary>
    public sealed class StatesBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StatesBlock"/> class.
        /// </summary>
        public StatesBlock()
        {
            this.Fields.Add(new StringField("name^"));
            this.Fields.Add(new RealRgbColorField("color"));
            this.Fields.Add(new ShortIntegerField("counts as:neighbors"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new RealField("initial placement weight"));
            this.Fields.Add(new PadField("", 24));
            this.Fields.Add(new ShortBlockIndexField("zero"));
            this.Fields.Add(new ShortBlockIndexField("one"));
            this.Fields.Add(new ShortBlockIndexField("two"));
            this.Fields.Add(new ShortBlockIndexField("three"));
            this.Fields.Add(new ShortBlockIndexField("four"));
            this.Fields.Add(new ShortBlockIndexField("five"));
            this.Fields.Add(new ShortBlockIndexField("six"));
            this.Fields.Add(new ShortBlockIndexField("seven"));
            this.Fields.Add(new ShortBlockIndexField("eight"));
            this.Fields.Add(new PadField("", 2));
        }
        /// <summary>
        /// Gets and returns the name of the states_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "states_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the states_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "states_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the states_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 16;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the states_block tag block.
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
