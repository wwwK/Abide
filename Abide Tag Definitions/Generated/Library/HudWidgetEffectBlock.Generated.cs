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
    /// Represents the generated hud_widget_effect_block tag block.
    /// </summary>
    public sealed class HudWidgetEffectBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HudWidgetEffectBlock"/> class.
        /// </summary>
        public HudWidgetEffectBlock()
        {
            this.Fields.Add(new ExplanationField("WIDGET EFFECTS", "allow the scaling, rotation, and offsetting of widgets"));
            this.Fields.Add(new WordFlagsField("flags", "apply scale", "apply theta", "apply offset"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new ExplanationField("horizontal and vertical scale", ""));
            this.Fields.Add(new StructField<HudWidgetEffectFunctionStructBlock>("your mom"));
            this.Fields.Add(new StructField<HudWidgetEffectFunctionStructBlock>("your mom"));
            this.Fields.Add(new ExplanationField("theta", ""));
            this.Fields.Add(new StructField<HudWidgetEffectFunctionStructBlock>("your mom"));
            this.Fields.Add(new ExplanationField("horizontal and vertical offset", ""));
            this.Fields.Add(new StructField<HudWidgetEffectFunctionStructBlock>("your mom"));
            this.Fields.Add(new StructField<HudWidgetEffectFunctionStructBlock>("your mom"));
        }
        /// <summary>
        /// Gets and returns the name of the hud_widget_effect_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "hud_widget_effect_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the hud_widget_effect_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "hud_widget_effect_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the hud_widget_effect_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the hud_widget_effect_block tag block.
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
