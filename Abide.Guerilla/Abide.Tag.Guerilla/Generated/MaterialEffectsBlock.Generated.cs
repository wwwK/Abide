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
    /// Represents the generated material_effects_block tag block.
    /// </summary>
    public sealed class MaterialEffectsBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MaterialEffectsBlock"/> class.
        /// </summary>
        public MaterialEffectsBlock()
        {
            this.Fields.Add(new BlockField<MaterialEffectBlockV2>("effects", 21));
        }
        /// <summary>
        /// Gets and returns the name of the material_effects_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "material_effects_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the material_effects_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "material_effects";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the material_effects_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the material_effects_block tag block.
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