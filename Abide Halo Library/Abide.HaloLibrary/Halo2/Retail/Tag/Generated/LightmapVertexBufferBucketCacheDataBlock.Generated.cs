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
    /// Represents the generated lightmap_vertex_buffer_bucket_cache_data_block tag block.
    /// </summary>
    internal sealed class LightmapVertexBufferBucketCacheDataBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LightmapVertexBufferBucketCacheDataBlock"/> class.
        /// </summary>
        public LightmapVertexBufferBucketCacheDataBlock()
        {
            this.Fields.Add(new BlockField<GlobalGeometrySectionVertexBufferBlock>("vertex buffers*", 512));
        }
        /// <summary>
        /// Gets and returns the name of the lightmap_vertex_buffer_bucket_cache_data_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "lightmap_vertex_buffer_bucket_cache_data_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the lightmap_vertex_buffer_bucket_cache_data_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "lightmap_vertex_buffer_bucket_cache_data_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the lightmap_vertex_buffer_bucket_cache_data_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the lightmap_vertex_buffer_bucket_cache_data_block tag block.
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
