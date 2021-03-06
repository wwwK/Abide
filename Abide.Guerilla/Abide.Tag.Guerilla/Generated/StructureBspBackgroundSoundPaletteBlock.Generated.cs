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
    using System;
    using Abide.HaloLibrary;
    using Abide.Tag;
    
    /// <summary>
    /// Represents the generated structure_bsp_background_sound_palette_block tag block.
    /// </summary>
    public sealed class StructureBspBackgroundSoundPaletteBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StructureBspBackgroundSoundPaletteBlock"/> class.
        /// </summary>
        public StructureBspBackgroundSoundPaletteBlock()
        {
            this.Fields.Add(new StringField("Name^"));
            this.Fields.Add(new TagReferenceField("Background Sound", 1819504228));
            this.Fields.Add(new TagReferenceField("Inside Cluster Sound#Play only when player is inside cluster.", 1819504228));
            this.Fields.Add(new PadField("", 20));
            this.Fields.Add(new RealField("Cutoff Distance"));
            this.Fields.Add(new LongFlagsField("Scale Flags", "Override Default Scale", "Use Adjacent Cluster as Portal Scale", "Use Adjacent Cluster as Exterior Scale", "Scale with Weather Intensity"));
            this.Fields.Add(new RealFractionField("Interior Scale"));
            this.Fields.Add(new RealFractionField("Portal Scale"));
            this.Fields.Add(new RealFractionField("Exterior Scale"));
            this.Fields.Add(new RealField("Interpolation Speed:1/sec"));
            this.Fields.Add(new PadField("", 8));
        }
        /// <summary>
        /// Gets and returns the name of the structure_bsp_background_sound_palette_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "structure_bsp_background_sound_palette_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the structure_bsp_background_sound_palette_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "structure_bsp_background_sound_palette_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the structure_bsp_background_sound_palette_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 64;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the structure_bsp_background_sound_palette_block tag block.
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
