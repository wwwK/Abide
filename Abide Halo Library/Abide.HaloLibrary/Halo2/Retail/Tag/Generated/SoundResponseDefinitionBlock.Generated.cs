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
    /// Represents the generated sound_response_definition_block tag block.
    /// </summary>
    internal sealed class SoundResponseDefinitionBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SoundResponseDefinitionBlock"/> class.
        /// </summary>
        public SoundResponseDefinitionBlock()
        {
            this.Fields.Add(new WordFlagsField("sound flags", "announcer sound"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new TagReferenceField("english sound^", 1936614433));
            this.Fields.Add(new StructField<SoundResponseExtraSoundsStructBlock>("extra sounds"));
            this.Fields.Add(new RealField("probability"));
        }
        /// <summary>
        /// Gets and returns the name of the sound_response_definition_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "sound_response_definition_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the sound_response_definition_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "sound_response_definition_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the sound_response_definition_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 10;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the sound_response_definition_block tag block.
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
