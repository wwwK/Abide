//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Abide.Tag.Cache.Generated
{
    using Abide.Tag;
    
    /// <summary>
    /// Represents the generated weapon_type_block tag block.
    /// </summary>
    public sealed class WeaponTypeBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WeaponTypeBlock"/> class.
        /// </summary>
        public WeaponTypeBlock()
        {
            this.Fields.Add(new StringIdField("label^"));
            this.Fields.Add(new BlockField<AnimationEntryBlock>("actions|AABBCC", 256));
            this.Fields.Add(new BlockField<AnimationEntryBlock>("overlays|AABBCC", 256));
            this.Fields.Add(new BlockField<DamageAnimationBlock>("death and damage|AABBCC", 8));
            this.Fields.Add(new BlockField<AnimationTransitionBlock>("transitions|AABBCC", 256));
            this.Fields.Add(new BlockField<PrecacheListBlock>("high precache|CCCCC", 1024));
            this.Fields.Add(new BlockField<PrecacheListBlock>("low precache|CCCCC", 1024));
        }
        /// <summary>
        /// Gets and returns the name of the weapon_type_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "weapon_type_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the weapon_type_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "weapon_type_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the weapon_type_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 64;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the weapon_type_block tag block.
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
