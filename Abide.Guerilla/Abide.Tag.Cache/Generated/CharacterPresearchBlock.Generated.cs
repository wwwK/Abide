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
    /// Represents the generated character_presearch_block tag block.
    /// </summary>
    public sealed class CharacterPresearchBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterPresearchBlock"/> class.
        /// </summary>
        public CharacterPresearchBlock()
        {
            this.Fields.Add(new LongFlagsField("Pre-search flags", "Flag1"));
            this.Fields.Add(new RealBoundsField("min presearch time:seconds#If the min presearch time expires and the target is (a" +
                        "ctually) outside the min-certainty radius, presearch turns off"));
            this.Fields.Add(new RealBoundsField("max presearch time:seconds#Presearch turns off after the given time"));
            this.Fields.Add(new RealField("Min certainty radius"));
            this.Fields.Add(new RealField("DEPRECATED"));
            this.Fields.Add(new RealBoundsField("min suppressing time#if the min suppressing time expires and the target is outsid" +
                        "e the min-certainty radius, suppressing fire turns off"));
        }
        /// <summary>
        /// Gets and returns the name of the character_presearch_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "character_presearch_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the character_presearch_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "character_presearch_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the character_presearch_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 3;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the character_presearch_block tag block.
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
