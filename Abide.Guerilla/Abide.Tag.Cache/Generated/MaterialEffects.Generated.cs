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
    using HaloTag = Abide.HaloLibrary.TagFourCc;
    
    /// <summary>
    /// Represents the generated material_effects (foot) tag group.
    /// </summary>
    public class MaterialEffects : Group
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MaterialEffects"/> class.
        /// </summary>
        public MaterialEffects()
        {
            // Add tag block to list.
            this.TagBlocks.Add(new MaterialEffectsBlock());
        }
        /// <summary>
        /// Gets and returns the name of the material_effects tag group.
        /// </summary>
        public override string Name
        {
            get
            {
                return "material_effects";
            }
        }
        /// <summary>
        /// Gets and returns the group tag of the material_effects tag group.
        /// </summary>
        public override HaloTag GroupTag
        {
            get
            {
                return "foot";
            }
        }
    }
}
