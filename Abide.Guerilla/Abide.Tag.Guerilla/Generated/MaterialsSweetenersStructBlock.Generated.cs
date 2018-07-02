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
    /// Represents the generated materials_sweeteners_struct_block tag block.
    /// </summary>
    public sealed class MaterialsSweetenersStructBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MaterialsSweetenersStructBlock"/> class.
        /// </summary>
        public MaterialsSweetenersStructBlock()
        {
            this.Fields.Add(new TagReferenceField("sound sweetener (small)", "snd!"));
            this.Fields.Add(new TagReferenceField("sound sweetener (medium)", "snd!"));
            this.Fields.Add(new TagReferenceField("sound sweetener (large)", "snd!"));
            this.Fields.Add(new TagReferenceField("sound sweetener rolling", "lsnd"));
            this.Fields.Add(new TagReferenceField("sound sweetener grinding", "lsnd"));
            this.Fields.Add(new TagReferenceField("sound sweetener (melee)", "snd!"));
            this.Fields.Add(new TagReferenceField("", "����"));
            this.Fields.Add(new TagReferenceField("effect sweetener (small)", "effe"));
            this.Fields.Add(new TagReferenceField("effect sweetener (medium)", "effe"));
            this.Fields.Add(new TagReferenceField("effect sweetener (large)", "effe"));
            this.Fields.Add(new TagReferenceField("effect sweetener rolling", "effe"));
            this.Fields.Add(new TagReferenceField("effect sweetener grinding", "effe"));
            this.Fields.Add(new TagReferenceField("effect sweetener (melee)", "effe"));
            this.Fields.Add(new TagReferenceField("", "����"));
            this.Fields.Add(new ExplanationField("sweetener inheritance flags", "when a sweetener inheritance flag is set the sound\\effect is not inherited from t" +
                        "he parent material.  If you leave the sweetener blank and set the flag than no e" +
                        "ffect\\sound will play"));
            this.Fields.Add(new LongFlagsField("sweetener inheritance flags", "sound_small", "sound_medium", "sound_large", "sound_rolling", "sound_grinding", "sound_melee", "", "effect_small", "effect_medium", "effect_large", "effect_rolling", "effect_grinding", "effect_melee", ""));
        }
        /// <summary>
        /// Gets and returns the name of the materials_sweeteners_struct_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "materials_sweeteners_struct_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the materials_sweeteners_struct_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "materials_sweeteners_struct";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the materials_sweeteners_struct_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the materials_sweeteners_struct_block tag block.
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
