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
    using Abide.Tag;
    using HaloTag = Abide.HaloLibrary.TagFourCc;
    
    /// <summary>
    /// Represents the generated cache_file_sound ($#!+) tag group.
    /// </summary>
    public class CacheFileSound : Group
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CacheFileSound"/> class.
        /// </summary>
        public CacheFileSound()
        {
            // Add tag block to list.
            this.TagBlocks.Add(new CacheFileSoundBlock());
        }
        /// <summary>
        /// Gets and returns the name of the cache_file_sound tag group.
        /// </summary>
        public override string Name
        {
            get
            {
                return "cache_file_sound";
            }
        }
        /// <summary>
        /// Gets and returns the group tag of the cache_file_sound tag group.
        /// </summary>
        public override HaloTag GroupTag
        {
            get
            {
                return "$#!+";
            }
        }
    }
}
