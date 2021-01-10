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
    /// Represents the generated variant_setting_edit_reference_block tag block.
    /// </summary>
    internal sealed class VariantSettingEditReferenceBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VariantSettingEditReferenceBlock"/> class.
        /// </summary>
        public VariantSettingEditReferenceBlock()
        {
            this.Fields.Add(new LongEnumField("setting category^", "match-ctf", "match-slayer", "match-oddball", "match-king", "match-race", "match-headhunter", "match-juggernaut", "match-territories", "match-assault", "players", "OBSOLETE", "vehicles", "equipment", "game-ctf", "game-slayer", "game-oddball", "game-king", "game-race", "game-headhunter", "game-juggernaut", "game-territories", "game-assault", "quick options-ctf", "quick options-slayer", "quick options-oddball", "quick options-king", "quick options-race", "quick options-headhunter", "quick options-juggernaut", "quick options-territories", "quick options-assault", "team-ctf", "team-slayer", "team-oddball", "team-king", "team-race", "team-headhunter", "team-juggernaut", "team-territories", "team-assault"));
            this.Fields.Add(new PadField("", 4));
            this.Fields.Add(new BlockField<TextValuePairBlock>("options", 32));
            this.Fields.Add(new BlockField<NullBlock>("", 0));
        }
        /// <summary>
        /// Gets and returns the name of the variant_setting_edit_reference_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "variant_setting_edit_reference_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the variant_setting_edit_reference_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "variant_setting_edit_reference_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the variant_setting_edit_reference_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 40;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the variant_setting_edit_reference_block tag block.
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
