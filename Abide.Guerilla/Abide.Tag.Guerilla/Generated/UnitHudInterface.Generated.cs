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
    /// Represents the generated unit_hud_interface (unhi) tag group.
    /// </summary>
    public class UnitHudInterface : Group
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnitHudInterface"/> class.
        /// </summary>
        public UnitHudInterface()
        {
            // Add tag block to list.
            this.TagBlocks.Add(new UnitHudInterfaceBlock());
        }
        /// <summary>
        /// Gets and returns the name of the unit_hud_interface tag group.
        /// </summary>
        public override string Name
        {
            get
            {
                return "unit_hud_interface";
            }
        }
        /// <summary>
        /// Gets and returns the group tag of the unit_hud_interface tag group.
        /// </summary>
        public override HaloTag GroupTag
        {
            get
            {
                return "unhi";
            }
        }
    }
}
