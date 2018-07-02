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
    /// Represents the generated camera_block tag block.
    /// </summary>
    public sealed class CameraBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CameraBlock"/> class.
        /// </summary>
        public CameraBlock()
        {
            this.Fields.Add(new TagReferenceField("default unit camera track", "trak"));
            this.Fields.Add(new RealField("default change pause"));
            this.Fields.Add(new RealField("first person change pause"));
            this.Fields.Add(new RealField("following camera change pause"));
        }
        /// <summary>
        /// Gets and returns the name of the camera_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "camera_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the camera_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "camera_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the camera_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the camera_block tag block.
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
