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
    /// Represents the generated weapon_hud_interface (wphi) tag group.
    /// </summary>
    internal class WeaponHudInterface : Group
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WeaponHudInterface"/> class.
        /// </summary>
        public WeaponHudInterface()
        {
            // Add tag block to list.
            this.TagBlocks.Add(new WeaponHudInterfaceBlock());
        }
        /// <summary>
        /// Gets and returns the name of the weapon_hud_interface tag group.
        /// </summary>
        public override string GroupName
        {
            get
            {
                return "weapon_hud_interface";
            }
        }
        /// <summary>
        /// Gets and returns the group tag of the weapon_hud_interface tag group.
        /// </summary>
        public override TagFourCc GroupTag
        {
            get
            {
                return "wphi";
            }
        }
    }
}
