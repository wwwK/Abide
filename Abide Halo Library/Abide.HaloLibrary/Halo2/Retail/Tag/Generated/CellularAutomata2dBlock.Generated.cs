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
    /// Represents the generated cellular_automata2d_block tag block.
    /// </summary>
    public sealed class CellularAutomata2dBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CellularAutomata2dBlock"/> class.
        /// </summary>
        public CellularAutomata2dBlock()
        {
            this.Fields.Add(new ExplanationField("properties", ""));
            this.Fields.Add(new ShortIntegerField("updates per second:Hz"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new RealField("dead cell penalty"));
            this.Fields.Add(new RealField("live cell bonus"));
            this.Fields.Add(new PadField("", 80));
            this.Fields.Add(new ExplanationField("height map", ""));
            this.Fields.Add(new ShortIntegerField("width:cells"));
            this.Fields.Add(new ShortIntegerField("height:cells"));
            this.Fields.Add(new RealField("cell width:world units"));
            this.Fields.Add(new RealField("height:world units"));
            this.Fields.Add(new RealVector2dField("velocity:cells/update"));
            this.Fields.Add(new PadField("", 28));
            this.Fields.Add(new OldStringIdField("marker"));
            this.Fields.Add(new LongFlagsField("interpolation flags", "blend in hsv#blends colors in hsv rather than rgb space", "...more colors#blends colors through more hues (goes the long way around the colo" +
                        "r wheel)"));
            this.Fields.Add(new RealRgbColorField("base color"));
            this.Fields.Add(new RealRgbColorField("peak color"));
            this.Fields.Add(new PadField("", 76));
            this.Fields.Add(new ExplanationField("detail map", ""));
            this.Fields.Add(new ShortIntegerField("width:cells"));
            this.Fields.Add(new ShortIntegerField("height:cells"));
            this.Fields.Add(new RealField("cell width:world units"));
            this.Fields.Add(new RealVector2dField("velocity:cells/update"));
            this.Fields.Add(new PadField("", 48));
            this.Fields.Add(new OldStringIdField("marker"));
            this.Fields.Add(new ShortIntegerField("texture width:cells"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new PadField("", 48));
            this.Fields.Add(new TagReferenceField("texture", 1651078253));
            this.Fields.Add(new PadField("", 160));
            this.Fields.Add(new BlockField<RulesBlock>("rules", 16));
        }
        /// <summary>
        /// Gets and returns the name of the cellular_automata2d_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "cellular_automata2d_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the cellular_automata2d_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "cellular_automata2d";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the cellular_automata2d_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the cellular_automata2d_block tag block.
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
