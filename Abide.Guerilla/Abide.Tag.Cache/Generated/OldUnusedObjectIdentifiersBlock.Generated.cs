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
    /// Represents the generated old_unused_object_identifiers_block tag block.
    /// </summary>
    public sealed class OldUnusedObjectIdentifiersBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OldUnusedObjectIdentifiersBlock"/> class.
        /// </summary>
        public OldUnusedObjectIdentifiersBlock()
        {
            this.Fields.Add(new StructField<ScenarioObjectIdStructBlock>("Object ID"));
        }
        /// <summary>
        /// Gets and returns the name of the old_unused_object_identifiers_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "old_unused_object_identifiers_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the old_unused_object_identifiers_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "old_unused_object_identifiers_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the old_unused_object_identifiers_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 2048;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the old_unused_object_identifiers_block tag block.
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
