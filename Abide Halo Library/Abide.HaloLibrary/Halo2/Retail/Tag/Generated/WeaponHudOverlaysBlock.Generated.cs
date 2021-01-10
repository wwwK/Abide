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
    /// Represents the generated weapon_hud_overlays_block tag block.
    /// </summary>
    internal sealed class WeaponHudOverlaysBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WeaponHudOverlaysBlock"/> class.
        /// </summary>
        public WeaponHudOverlaysBlock()
        {
            this.Fields.Add(new EnumField("state attached to", "inventory ammo", "loaded ammo", "heat", "age", "secondary weapon inventory ammo", "secondary weapon loaded ammo", "distance to target", "elevation to target"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new EnumField("can use on map type", "any", "solo", "multiplayer"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new PadField("", 28));
            this.Fields.Add(new TagReferenceField("Overlay bitmap", 1651078253));
            this.Fields.Add(new BlockField<WeaponHudOverlayBlock>("Overlays", 16));
            this.Fields.Add(new PadField("", 40));
        }
        /// <summary>
        /// Gets and returns the name of the weapon_hud_overlays_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "weapon_hud_overlays_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the weapon_hud_overlays_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "weapon_hud_overlays_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the weapon_hud_overlays_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 16;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the weapon_hud_overlays_block tag block.
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
