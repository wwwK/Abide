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
    /// Represents the generated weapon_hud_crosshair_block tag block.
    /// </summary>
    public sealed class WeaponHudCrosshairBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WeaponHudCrosshairBlock"/> class.
        /// </summary>
        public WeaponHudCrosshairBlock()
        {
            this.Fields.Add(new EnumField("crosshair type", "aim", "zoom", "charge", "should reload", "flash heat", "flash inventory ammo", "flash battery", "reload/overheat", "flash when firing and no ammo", "flash when throwing and no grenade", "low ammo and none left to reload", "should reload secondary trigger", "flash secondary inventory ammo", "flash secondary reload", "flash when firing secondary trigger with no ammo", "low secondary ammo and none left to reload", "primary trigger ready", "secondary trigger ready", "flash when firing with depleted battery"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new EnumField("can use on map type", "any", "solo", "multiplayer"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new PadField("", 28));
            this.Fields.Add(new TagReferenceField("Crosshair bitmap", "bitm"));
            this.Fields.Add(new BlockField<WeaponHudCrosshairItemBlock>("Crosshair overlays", 16));
            this.Fields.Add(new PadField("", 40));
        }
        /// <summary>
        /// Gets and returns the name of the weapon_hud_crosshair_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "weapon_hud_crosshair_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the weapon_hud_crosshair_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "weapon_hud_crosshair_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the weapon_hud_crosshair_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 19;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the weapon_hud_crosshair_block tag block.
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
