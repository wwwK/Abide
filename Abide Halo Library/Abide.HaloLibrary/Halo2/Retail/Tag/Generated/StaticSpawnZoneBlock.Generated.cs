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
    /// Represents the generated static_spawn_zone_block tag block.
    /// </summary>
    internal sealed class StaticSpawnZoneBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StaticSpawnZoneBlock"/> class.
        /// </summary>
        public StaticSpawnZoneBlock()
        {
            this.Fields.Add(new ExplanationField("Static Spawn Zones", "Lower and upper heights can be left at 0, in which case they use defaults.  Leavi" +
                        "ng relevant teams empty means all teams; leaving all games empty means all games" +
                        "."));
            this.Fields.Add(new StructField<StaticSpawnZoneDataStructBlock>("Data"));
            this.Fields.Add(new RealPoint3dField("Position"));
            this.Fields.Add(new RealField("Lower Height"));
            this.Fields.Add(new RealField("Upper Height"));
            this.Fields.Add(new RealField("Inner Radius"));
            this.Fields.Add(new RealField("Outer Radius"));
            this.Fields.Add(new RealField("Weight"));
        }
        /// <summary>
        /// Gets and returns the name of the static_spawn_zone_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "static_spawn_zone_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the static_spawn_zone_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "static_spawn_zone_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the static_spawn_zone_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 128;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the static_spawn_zone_block tag block.
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
