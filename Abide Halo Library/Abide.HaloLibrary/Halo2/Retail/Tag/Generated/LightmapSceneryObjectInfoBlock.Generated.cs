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
    /// Represents the generated lightmap_scenery_object_info_block tag block.
    /// </summary>
    public sealed class LightmapSceneryObjectInfoBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LightmapSceneryObjectInfoBlock"/> class.
        /// </summary>
        public LightmapSceneryObjectInfoBlock()
        {
            this.Fields.Add(new LongIntegerField("unique ID"));
            this.Fields.Add(new ShortIntegerField("origin BSP index"));
            this.Fields.Add(new CharIntegerField("type"));
            this.Fields.Add(new CharIntegerField("source"));
            this.Fields.Add(new LongIntegerField("render model checksum"));
        }
        /// <summary>
        /// Gets and returns the name of the lightmap_scenery_object_info_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "lightmap_scenery_object_info_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the lightmap_scenery_object_info_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "lightmap_scenery_object_info_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the lightmap_scenery_object_info_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 2000;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the lightmap_scenery_object_info_block tag block.
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
