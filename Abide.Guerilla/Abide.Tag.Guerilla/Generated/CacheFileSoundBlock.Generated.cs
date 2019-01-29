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
    
    /// <summary>
    /// Represents the generated cache_file_sound_block tag block.
    /// </summary>
    public sealed class CacheFileSoundBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CacheFileSoundBlock"/> class.
        /// </summary>
        public CacheFileSoundBlock()
        {
            this.Fields.Add(new WordFlagsField("flags", "fit to adpcm blocksize", "split long sound into permutations", "always spatialize#always play as 3d sound, even in first person", "never obstruct#disable occlusion/obstruction for this sound", "internal don\'t touch", "use huge sound transmission", "link count to owner unit", "pitch range is language", "don\'t use sound class speaker flag", "don\'t use lipsync data"));
            this.Fields.Add(new CharEnumField("sound class*", "projectile_impact", "projectile_detonation", "projectile_flyby", "", "weapon_fire", "weapon_ready", "weapon_reload", "weapon_empty", "weapon_charge", "weapon_overheat", "weapon_idle", "weapon_melee", "weapon_animation", "object_impacts", "particle_impacts", "", "", "", "unit_footsteps", "unit_dialog", "unit_animation", "", "vehicle_collision", "vehicle_engine", "vehicle_animation", "", "device_door", "", "device_machinery", "device_stationary", "", "", "music", "ambient_nature", "ambient_machinery", "", "huge_ass", "object_looping", "cinematic_music", "", "", "", "", "", "", "cortana_mission", "cortana_cinematic", "mission_dialog", "cinematic_dialog", "scripted_cinematic_foley", "game_event", "ui", "test", "multilingual_test"));
            this.Fields.Add(new CharEnumField("sample rate*", "22kHz", "44kHz", "32kHz"));
            this.Fields.Add(new CharEnumField("encoding*", "mono", "stereo", "codec"));
            this.Fields.Add(new CharEnumField("compression*", "none (big endian)", "xbox adpcm", "ima adpcm", "none (little endian)", "wma"));
            this.Fields.Add(new ShortIntegerField("playback index"));
            this.Fields.Add(new ShortIntegerField("first pitch range index"));
            this.Fields.Add(new CharIntegerField("pitch range count"));
            this.Fields.Add(new CharIntegerField("scale index"));
            this.Fields.Add(new CharIntegerField("promotion index"));
            this.Fields.Add(new CharIntegerField("custom playback index"));
            this.Fields.Add(new ShortIntegerField("extra info index"));
            this.Fields.Add(new LongIntegerField("maximum play time:ms"));
        }
        /// <summary>
        /// Gets and returns the name of the cache_file_sound_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "cache_file_sound_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the cache_file_sound_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "cache_file_sound";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the cache_file_sound_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the cache_file_sound_block tag block.
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