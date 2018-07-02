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
    /// Represents the generated sound_class_block tag block.
    /// </summary>
    public sealed class SoundClassBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SoundClassBlock"/> class.
        /// </summary>
        public SoundClassBlock()
        {
            this.Fields.Add(new ShortIntegerField("max sounds per tag [1,16]#maximum number of sounds playing per individual sound t" +
                        "ag"));
            this.Fields.Add(new ShortIntegerField("max sounds per object [1,16]#maximum number of sounds of this type playing on an " +
                        "object"));
            this.Fields.Add(new LongIntegerField("preemption time:ms#replaces other instances after this many milliseconds"));
            this.Fields.Add(new WordFlagsField("internal flags*", "valid", "is speech", "scripted", "stops with object", "unused", "valid doppler factor", "valid obstruction factor", "multilingual"));
            this.Fields.Add(new WordFlagsField("flags", "plays during pause", "dry stereo mix", "no object obstruction", "use center speaker unspatialized", "send (mono) to lfe", "deterministic", "use huge transmission", "always use speakers", "don\'t strip from main menu", "ignore stereo headroom", "loop fade out is linear", "stop when object dies", "allow cache file editing"));
            this.Fields.Add(new ShortIntegerField("priority*"));
            this.Fields.Add(new EnumField("cache miss mode*", "discard", "postpone"));
            this.Fields.Add(new RealField("reverb gain:dB#how much reverb applies to this sound class"));
            this.Fields.Add(new RealField("override speaker gain:dB"));
            this.Fields.Add(new RealBoundsField("distance bounds"));
            this.Fields.Add(new RealBoundsField("gain bounds:dB"));
            this.Fields.Add(new RealField("cutscene ducking:dB"));
            this.Fields.Add(new RealField("cutscene ducking fade in time:seconds"));
            this.Fields.Add(new RealField("cutscene ducking sustain time:seconds#how long this lasts after the cutscene ends" +
                        ""));
            this.Fields.Add(new RealField("cutscene ducking fade out time:seconds"));
            this.Fields.Add(new RealField("scripted dialog ducking:dB"));
            this.Fields.Add(new RealField("scripted dialog ducking fade in time:seconds"));
            this.Fields.Add(new RealField("scripted dialog ducking sustain time:seconds#how long this lasts after the script" +
                        "ed dialog ends"));
            this.Fields.Add(new RealField("scripted dialog ducking fade out time:seconds"));
            this.Fields.Add(new RealField("doppler factor"));
            this.Fields.Add(new CharEnumField("stereo playback type", "first person", "ambient"));
            this.Fields.Add(new PadField("", 3));
            this.Fields.Add(new RealField("transmission multiplier"));
            this.Fields.Add(new RealField("obstruction max bend"));
            this.Fields.Add(new RealField("occlusion max bend"));
        }
        /// <summary>
        /// Gets and returns the name of the sound_class_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "sound_class_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the sound_class_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "sound_class_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the sound_class_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 54;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the sound_class_block tag block.
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
