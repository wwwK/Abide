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
    /// Represents the generated ai_conversation_line_block tag block.
    /// </summary>
    public sealed class AiConversationLineBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AiConversationLineBlock"/> class.
        /// </summary>
        public AiConversationLineBlock()
        {
            this.Fields.Add(new WordFlagsField("flags", "addressee look at speaker", "everyone look at speaker", "everyone look at addressee", "wait after until told to advance", "wait until speaker nearby", "wait until everyone nearby"));
            this.Fields.Add(new ShortBlockIndexField("participant"));
            this.Fields.Add(new EnumField("addressee", "none", "player", "participant"));
            this.Fields.Add(new ShortBlockIndexField("addressee participant#this field is only used if the addressee type is \'participa" +
                        "nt\'"));
            this.Fields.Add(new PadField("", 4));
            this.Fields.Add(new RealField("line delay time"));
            this.Fields.Add(new PadField("", 12));
            this.Fields.Add(new TagReferenceField("variant 1", "snd!"));
            this.Fields.Add(new TagReferenceField("variant 2", "snd!"));
            this.Fields.Add(new TagReferenceField("variant 3", "snd!"));
            this.Fields.Add(new TagReferenceField("variant 4", "snd!"));
            this.Fields.Add(new TagReferenceField("variant 5", "snd!"));
            this.Fields.Add(new TagReferenceField("variant 6", "snd!"));
        }
        /// <summary>
        /// Gets and returns the name of the ai_conversation_line_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "ai_conversation_line_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the ai_conversation_line_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "ai_conversation_line_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the ai_conversation_line_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 32;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the ai_conversation_line_block tag block.
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
