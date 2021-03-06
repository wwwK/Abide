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
    using System;
    using Abide.HaloLibrary;
    using Abide.Tag;
    
    /// <summary>
    /// Represents the generated local_string_id_list_section_reference_block tag block.
    /// </summary>
    public sealed class LocalStringIdListSectionReferenceBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocalStringIdListSectionReferenceBlock"/> class.
        /// </summary>
        public LocalStringIdListSectionReferenceBlock()
        {
            this.Fields.Add(new StringIdField("section name^"));
            this.Fields.Add(new BlockField<LocalStringIdListStringReferenceBlock>("local string section references", 64));
        }
        /// <summary>
        /// Gets and returns the name of the local_string_id_list_section_reference_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "local_string_id_list_section_reference_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the local_string_id_list_section_reference_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "local_string_id_list_section_reference_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the local_string_id_list_section_reference_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 16;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the local_string_id_list_section_reference_block tag block.
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
