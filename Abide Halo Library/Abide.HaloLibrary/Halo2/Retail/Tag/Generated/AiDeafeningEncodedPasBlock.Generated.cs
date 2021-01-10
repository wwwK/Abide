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
    /// Represents the generated ai_deafening_encoded_pas_block tag block.
    /// </summary>
    internal sealed class AiDeafeningEncodedPasBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AiDeafeningEncodedPasBlock"/> class.
        /// </summary>
        public AiDeafeningEncodedPasBlock()
        {
            this.Fields.Add(new LongIntegerField(""));
        }
        /// <summary>
        /// Gets and returns the name of the ai_deafening_encoded_pas_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "ai_deafening_encoded_pas_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the ai_deafening_encoded_pas_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "ai_deafening_encoded_pas_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the ai_deafening_encoded_pas_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 4088;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the ai_deafening_encoded_pas_block tag block.
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
