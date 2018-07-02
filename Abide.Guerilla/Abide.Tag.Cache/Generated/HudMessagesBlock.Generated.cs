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
    /// Represents the generated hud_messages_block tag block.
    /// </summary>
    public sealed class HudMessagesBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HudMessagesBlock"/> class.
        /// </summary>
        public HudMessagesBlock()
        {
            this.Fields.Add(new StringField("name*"));
            this.Fields.Add(new ShortIntegerField("start index into text blob*"));
            this.Fields.Add(new ShortIntegerField("start index of message block*"));
            this.Fields.Add(new CharIntegerField("panel count*"));
            this.Fields.Add(new PadField("", 3));
            this.Fields.Add(new PadField("", 24));
        }
        /// <summary>
        /// Gets and returns the name of the hud_messages_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "hud_messages_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the hud_messages_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "hud_messages_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the hud_messages_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1024;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the hud_messages_block tag block.
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
