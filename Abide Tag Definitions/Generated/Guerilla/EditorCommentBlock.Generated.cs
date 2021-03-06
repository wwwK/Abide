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
    using System;
    using Abide.HaloLibrary;
    using Abide.Tag;
    
    /// <summary>
    /// Represents the generated editor_comment_block tag block.
    /// </summary>
    public sealed class EditorCommentBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EditorCommentBlock"/> class.
        /// </summary>
        public EditorCommentBlock()
        {
            this.Fields.Add(new RealPoint3dField("Position"));
            this.Fields.Add(new LongEnumField(")Type", "Generic"));
            this.Fields.Add(new StringField("Name^"));
            this.Fields.Add(new LongStringField("Comment"));
        }
        /// <summary>
        /// Gets and returns the name of the editor_comment_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "editor_comment_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the editor_comment_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "editor_comment_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the editor_comment_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 65536;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the editor_comment_block tag block.
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
