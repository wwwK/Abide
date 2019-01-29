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
    /// Represents the generated rules_block tag block.
    /// </summary>
    public sealed class RulesBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RulesBlock"/> class.
        /// </summary>
        public RulesBlock()
        {
            this.Fields.Add(new StringField("name^"));
            this.Fields.Add(new RealRgbColorField("tint color"));
            this.Fields.Add(new PadField("", 32));
            this.Fields.Add(new BlockField<StatesBlock>("states", 16));
        }
        /// <summary>
        /// Gets and returns the name of the rules_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "rules_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the rules_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "rules_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the rules_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 16;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the rules_block tag block.
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