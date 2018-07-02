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
    /// Represents the generated object_change_colors tag block.
    /// </summary>
    public sealed class ObjectChangeColors : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectChangeColors"/> class.
        /// </summary>
        public ObjectChangeColors()
        {
            this.Fields.Add(new BlockField<ObjectChangeColorInitialPermutation>("initial permutations", 32));
            this.Fields.Add(new BlockField<ObjectChangeColorFunction>("functions", 4));
        }
        /// <summary>
        /// Gets and returns the name of the object_change_colors tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "object_change_colors";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the object_change_colors tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "object_change_colors";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the object_change_colors tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 4;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the object_change_colors tag block.
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
