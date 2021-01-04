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
    /// Represents the generated damage_effect (jpt!) tag group.
    /// </summary>
    public class DamageEffect : Group
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DamageEffect"/> class.
        /// </summary>
        public DamageEffect()
        {
            // Add tag block to list.
            this.TagBlocks.Add(new DamageEffectBlock());
        }
        /// <summary>
        /// Gets and returns the name of the damage_effect tag group.
        /// </summary>
        public override string GroupName
        {
            get
            {
                return "damage_effect";
            }
        }
        /// <summary>
        /// Gets and returns the group tag of the damage_effect tag group.
        /// </summary>
        public override TagFourCc GroupTag
        {
            get
            {
                return "jpt!";
            }
        }
    }
}
