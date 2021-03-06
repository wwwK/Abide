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
    /// Represents the generated predicted_bitmaps_block tag block.
    /// </summary>
    internal sealed class PredictedBitmapsBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PredictedBitmapsBlock"/> class.
        /// </summary>
        public PredictedBitmapsBlock()
        {
            this.Fields.Add(new TagReferenceField("bitmap", 1651078253));
        }
        /// <summary>
        /// Gets and returns the name of the predicted_bitmaps_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "predicted_bitmaps_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the predicted_bitmaps_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "predicted_bitmaps_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the predicted_bitmaps_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 8;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the predicted_bitmaps_block tag block.
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
