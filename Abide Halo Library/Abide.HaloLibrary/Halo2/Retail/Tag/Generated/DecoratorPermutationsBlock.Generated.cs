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
    /// Represents the generated decorator_permutations_block tag block.
    /// </summary>
    public sealed class DecoratorPermutationsBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DecoratorPermutationsBlock"/> class.
        /// </summary>
        public DecoratorPermutationsBlock()
        {
            this.Fields.Add(new StringIdField("name"));
            this.Fields.Add(new CharBlockIndexField("shader"));
            this.Fields.Add(new PadField("", 3));
            this.Fields.Add(new ByteFlagsField("flags", "align to normal", "only on ground", "upright"));
            this.Fields.Add(new CharEnumField("fade distance", "close", "medium", "far"));
            this.Fields.Add(new CharIntegerField("index"));
            this.Fields.Add(new CharIntegerField("distribution weight"));
            this.Fields.Add(new RealBoundsField("scale"));
            this.Fields.Add(new RgbColorField("tint 1"));
            this.Fields.Add(new PadField("", 1));
            this.Fields.Add(new RgbColorField("tint 2"));
            this.Fields.Add(new PadField("", 1));
            this.Fields.Add(new RealField("base map tint percentage"));
            this.Fields.Add(new RealField("lightmap tint percentage"));
            this.Fields.Add(new RealField("wind scale"));
        }
        /// <summary>
        /// Gets and returns the name of the decorator_permutations_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "decorator_permutations_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the decorator_permutations_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "decorator_permutations_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the decorator_permutations_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 64;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the decorator_permutations_block tag block.
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
