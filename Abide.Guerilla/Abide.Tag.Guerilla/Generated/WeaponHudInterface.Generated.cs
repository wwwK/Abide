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
    using HaloTag = Abide.HaloLibrary.TagFourCc;
    
    /// <summary>
    /// Represents the generated weapon_hud_interface (wphi) tag group.
    /// </summary>
    public class WeaponHudInterface : Group
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
        public override string Name
        {
            get
            {
                return "weapon_hud_interface";
            }
        }
        /// <summary>
        /// Gets and returns the group tag of the weapon_hud_interface tag group.
        /// </summary>
        public override HaloTag GroupTag
        {
            get
            {
                return "wphi";
            }
        }
    }
}
