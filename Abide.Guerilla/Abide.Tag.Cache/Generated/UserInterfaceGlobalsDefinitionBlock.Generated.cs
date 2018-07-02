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
    /// Represents the generated user_interface_globals_definition_block tag block.
    /// </summary>
    public sealed class UserInterfaceGlobalsDefinitionBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserInterfaceGlobalsDefinitionBlock"/> class.
        /// </summary>
        public UserInterfaceGlobalsDefinitionBlock()
        {
            this.Fields.Add(new ExplanationField("Shared Globals", "This is a reference to the ui shared globals tag"));
            this.Fields.Add(new TagReferenceField("shared globals", "wigl"));
            this.Fields.Add(new ExplanationField("Screen Widgets", "These are the screen widgets"));
            this.Fields.Add(new BlockField<UserInterfaceWidgetReferenceBlock>("screen widgets", 256));
            this.Fields.Add(new ExplanationField("Multiplayer Variant Settings Interface", "This blob defines the ui for setting multiplayer game variant parameters"));
            this.Fields.Add(new TagReferenceField("mp variant settings ui", "goof"));
            this.Fields.Add(new ExplanationField("Game Hopper Localization Strings", "This is for the loc game hopper strings"));
            this.Fields.Add(new TagReferenceField("game hopper descriptions", "unic"));
        }
        /// <summary>
        /// Gets and returns the name of the user_interface_globals_definition_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "user_interface_globals_definition_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the user_interface_globals_definition_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "user_interface_globals_definition";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the user_interface_globals_definition_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the user_interface_globals_definition_block tag block.
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
