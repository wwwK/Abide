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
    /// Represents the generated multiplayer_constants_block tag block.
    /// </summary>
    public sealed class MultiplayerConstantsBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MultiplayerConstantsBlock"/> class.
        /// </summary>
        public MultiplayerConstantsBlock()
        {
            this.Fields.Add(new RealField("maximum random spawn bias"));
            this.Fields.Add(new RealField("teleporter recharge time:seconds"));
            this.Fields.Add(new RealField("grenade danger weight"));
            this.Fields.Add(new RealField("grenade danger inner radius"));
            this.Fields.Add(new RealField("grenade danger outer radius"));
            this.Fields.Add(new RealField("grenade danger lead time:seconds"));
            this.Fields.Add(new RealField("vehicle danger min speed:wu/sec"));
            this.Fields.Add(new RealField("vehicle danger weight"));
            this.Fields.Add(new RealField("vehicle danger radius"));
            this.Fields.Add(new RealField("vehicle danger lead time:seconds"));
            this.Fields.Add(new RealField("vehicle nearby player dist#how nearby a player is to count a vehicle as \'occupied" +
                        "\'"));
            this.Fields.Add(new PadField("", 84));
            this.Fields.Add(new PadField("", 32));
            this.Fields.Add(new PadField("", 32));
            this.Fields.Add(new TagReferenceField("hill shader", "shad"));
            this.Fields.Add(new PadField("", 16));
            this.Fields.Add(new RealField("flag reset stop distance"));
            this.Fields.Add(new TagReferenceField("bomb explode effect", "effe"));
            this.Fields.Add(new TagReferenceField("bomb explode dmg effect", "jpt!"));
            this.Fields.Add(new TagReferenceField("bomb defuse effect", "effe"));
            this.Fields.Add(new StringIdField("bomb defusal string"));
            this.Fields.Add(new StringIdField("blocked teleporter string"));
            this.Fields.Add(new PadField("", 4));
            this.Fields.Add(new PadField("", 32));
            this.Fields.Add(new PadField("", 32));
            this.Fields.Add(new PadField("", 32));
        }
        /// <summary>
        /// Gets and returns the name of the multiplayer_constants_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "multiplayer_constants_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the multiplayer_constants_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "multiplayer_constants_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the multiplayer_constants_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the multiplayer_constants_block tag block.
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
