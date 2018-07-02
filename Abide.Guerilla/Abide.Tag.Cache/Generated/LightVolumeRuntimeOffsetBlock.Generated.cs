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
    /// Represents the generated light_volume_runtime_offset_block tag block.
    /// </summary>
    public sealed class LightVolumeRuntimeOffsetBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LightVolumeRuntimeOffsetBlock"/> class.
        /// </summary>
        public LightVolumeRuntimeOffsetBlock()
        {
            this.Fields.Add(new RealVector2dField(""));
        }
        /// <summary>
        /// Gets and returns the name of the light_volume_runtime_offset_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "light_volume_runtime_offset_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the light_volume_runtime_offset_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "light_volume_runtime_offset_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the light_volume_runtime_offset_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 256;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the light_volume_runtime_offset_block tag block.
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
