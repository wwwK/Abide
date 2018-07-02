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
    /// Represents the generated cs_point_block tag block.
    /// </summary>
    public sealed class CsPointBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CsPointBlock"/> class.
        /// </summary>
        public CsPointBlock()
        {
            this.Fields.Add(new StringField("name^"));
            this.Fields.Add(new RealPoint3dField("position"));
            this.Fields.Add(new ShortIntegerField("reference frame*"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new LongIntegerField("surface index"));
            this.Fields.Add(new EulerAngles2dField("facing direction"));
        }
        /// <summary>
        /// Gets and returns the name of the cs_point_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "cs_point_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the cs_point_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "cs_point_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the cs_point_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 20;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the cs_point_block tag block.
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
