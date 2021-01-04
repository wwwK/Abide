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
    /// Represents the generated mass_point_block tag block.
    /// </summary>
    public sealed class MassPointBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MassPointBlock"/> class.
        /// </summary>
        public MassPointBlock()
        {
            this.Fields.Add(new StringField("name*^"));
            this.Fields.Add(new ShortBlockIndexField("powered mass point"));
            this.Fields.Add(new ShortIntegerField("model node*"));
            this.Fields.Add(new LongFlagsField("flags", "metallic"));
            this.Fields.Add(new RealField("relative mass"));
            this.Fields.Add(new RealField("mass*"));
            this.Fields.Add(new RealField("relative density"));
            this.Fields.Add(new RealField("density*"));
            this.Fields.Add(new RealPoint3dField("position"));
            this.Fields.Add(new RealVector3dField("forward"));
            this.Fields.Add(new RealVector3dField("up"));
            this.Fields.Add(new EnumField("friction type", "point", "forward", "left", "up"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new RealField("friction parallel scale"));
            this.Fields.Add(new RealField("friction perpendicular scale"));
            this.Fields.Add(new RealField("radius"));
            this.Fields.Add(new PadField("", 20));
        }
        /// <summary>
        /// Gets and returns the name of the mass_point_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "mass_point_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the mass_point_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "mass_point_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the mass_point_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 32;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the mass_point_block tag block.
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
