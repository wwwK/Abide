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
    /// Represents the generated sound_classes_block tag block.
    /// </summary>
    public sealed class SoundClassesBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SoundClassesBlock"/> class.
        /// </summary>
        public SoundClassesBlock()
        {
            this.Fields.Add(new BlockField<SoundClassBlock>("sound classes", 54));
        }
        /// <summary>
        /// Gets and returns the name of the sound_classes_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "sound_classes_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the sound_classes_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "sound_classes";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the sound_classes_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the sound_classes_block tag block.
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
