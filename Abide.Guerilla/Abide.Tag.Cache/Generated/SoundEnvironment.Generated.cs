//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Abide.Tag.Cache.Generated
{
    using System;
    using Abide.HaloLibrary;
    using Abide.Tag;
    
    /// <summary>
    /// Represents the generated sound_environment (snde) tag group.
    /// </summary>
    public class SoundEnvironment : Group
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SoundEnvironment"/> class.
        /// </summary>
        public SoundEnvironment()
        {
            // Add tag block to list.
            this.TagBlocks.Add(new SoundEnvironmentBlock());
        }
        /// <summary>
        /// Gets and returns the name of the sound_environment tag group.
        /// </summary>
        public override string Name
        {
            get
            {
                return "sound_environment";
            }
        }
        /// <summary>
        /// Gets and returns the group tag of the sound_environment tag group.
        /// </summary>
        public override TagFourCc Tag
        {
            get
            {
                return "snde";
            }
        }
    }
}
