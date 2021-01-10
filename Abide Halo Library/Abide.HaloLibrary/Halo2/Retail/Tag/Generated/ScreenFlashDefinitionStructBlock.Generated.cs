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
    /// Represents the generated screen_flash_definition_struct_block tag block.
    /// </summary>
    internal sealed class ScreenFlashDefinitionStructBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScreenFlashDefinitionStructBlock"/> class.
        /// </summary>
        public ScreenFlashDefinitionStructBlock()
        {
            this.Fields.Add(new EnumField("type", "none", "lighten", "darken", "max", "min", "invert", "tint"));
            this.Fields.Add(new EnumField("priority", "low", "medium", "high"));
            this.Fields.Add(new RealField("duration:seconds"));
            this.Fields.Add(new EnumField("fade function", "linear", "late", "very late", "early", "very early", "cosine", "zero", "one"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new RealFractionField("maximum intensity:[0,1]"));
            this.Fields.Add(new RealArgbColorField("color"));
        }
        /// <summary>
        /// Gets and returns the name of the screen_flash_definition_struct_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "screen_flash_definition_struct_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the screen_flash_definition_struct_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "screen_flash_definition_struct";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the screen_flash_definition_struct_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the screen_flash_definition_struct_block tag block.
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
