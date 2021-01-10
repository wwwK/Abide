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
    /// Represents the generated sector_link_block tag block.
    /// </summary>
    internal sealed class SectorLinkBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SectorLinkBlock"/> class.
        /// </summary>
        public SectorLinkBlock()
        {
            this.Fields.Add(new ShortIntegerField("vertex 1"));
            this.Fields.Add(new ShortIntegerField("vertex 2"));
            this.Fields.Add(new WordFlagsField("link flags", "sector link from collision edge", "sector intersection link", "sector link bsp2d creation error", "sector link topology error", "sector link chain error", "sector link both sectors walkable", "sector link magic hanging link", "sector link threshold", "sector link crouchable", "sector link wall base", "sector link ledge", "sector link leanable", "sector link start corner", "sector link end corner"));
            this.Fields.Add(new ShortIntegerField("hint index"));
            this.Fields.Add(new ShortIntegerField("forward link"));
            this.Fields.Add(new ShortIntegerField("reverse link"));
            this.Fields.Add(new ShortIntegerField("left sector"));
            this.Fields.Add(new ShortIntegerField("right sector"));
        }
        /// <summary>
        /// Gets and returns the name of the sector_link_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "sector_link_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the sector_link_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "sector_link_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the sector_link_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 262144;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the sector_link_block tag block.
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
