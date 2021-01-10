//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Abide.HaloLibrary.Halo2.Retail.Tag.Generated
{
    using System;
    using Abide.HaloLibrary;
    using Abide.HaloLibrary.Halo2.Retail.Tag;
    
    /// <summary>
    /// Represents the generated object_attachment_block tag block.
    /// </summary>
    internal sealed class ObjectAttachmentBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectAttachmentBlock"/> class.
        /// </summary>
        public ObjectAttachmentBlock()
        {
            this.Fields.Add(new TagReferenceField("type^", -3));
            this.Fields.Add(new OldStringIdField("marker"));
            this.Fields.Add(new EnumField("change color", "none", "primary", "secondary", "tertiary", "quaternary"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new StringIdField("primary scale"));
            this.Fields.Add(new StringIdField("secondary scale"));
        }
        /// <summary>
        /// Gets and returns the name of the object_attachment_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "object_attachment_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the object_attachment_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "object_attachment_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the object_attachment_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 16;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the object_attachment_block tag block.
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
