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
    /// Represents the generated old_material_effect_material_block tag block.
    /// </summary>
    internal sealed class OldMaterialEffectMaterialBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OldMaterialEffectMaterialBlock"/> class.
        /// </summary>
        public OldMaterialEffectMaterialBlock()
        {
            this.Fields.Add(new TagReferenceField("effect", 1701209701));
            this.Fields.Add(new TagReferenceField("sound", -3));
            this.Fields.Add(new StringIdField("material name^"));
            this.Fields.Add(new SkipField("", 4));
            this.Fields.Add(new CharEnumField("sweetener mode", "sweetener default", "sweetener enabled", "sweetener disabled"));
            this.Fields.Add(new PadField("", 3));
        }
        /// <summary>
        /// Gets and returns the name of the old_material_effect_material_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "old_material_effect_material_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the old_material_effect_material_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "old_material_effect_material_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the old_material_effect_material_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 33;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the old_material_effect_material_block tag block.
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
