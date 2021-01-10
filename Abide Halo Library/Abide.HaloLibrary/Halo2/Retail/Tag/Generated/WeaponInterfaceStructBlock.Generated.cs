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
    /// Represents the generated weapon_interface_struct_block tag block.
    /// </summary>
    internal sealed class WeaponInterfaceStructBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WeaponInterfaceStructBlock"/> class.
        /// </summary>
        public WeaponInterfaceStructBlock()
        {
            this.Fields.Add(new ExplanationField("interface", ""));
            this.Fields.Add(new StructField<WeaponSharedInterfaceStructBlock>("shared interface"));
            this.Fields.Add(new BlockField<WeaponFirstPersonInterfaceBlock>("first person", 4));
            this.Fields.Add(new TagReferenceField("new hud interface", 1852335220));
        }
        /// <summary>
        /// Gets and returns the name of the weapon_interface_struct_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "weapon_interface_struct_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the weapon_interface_struct_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "weapon_interface_struct";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the weapon_interface_struct_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the weapon_interface_struct_block tag block.
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
