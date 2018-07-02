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
    /// Represents the generated effect_event_block tag block.
    /// </summary>
    public sealed class EffectEventBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EffectEventBlock"/> class.
        /// </summary>
        public EffectEventBlock()
        {
            this.Fields.Add(new LongFlagsField("flags", "disabled for debugging"));
            this.Fields.Add(new RealFractionField("skip fraction#chance that this event will be skipped entirely"));
            this.Fields.Add(new RealBoundsField("delay bounds:seconds#delay before this event takes place"));
            this.Fields.Add(new RealBoundsField("duration bounds:seconds#duration of this event"));
            this.Fields.Add(new BlockField<EffectPartBlock>("parts", 32));
            this.Fields.Add(new BlockField<BeamBlock>("beams", 1024));
            this.Fields.Add(new BlockField<EffectAccelerationsBlock>("accelerations", 32));
            this.Fields.Add(new BlockField<ParticleSystemDefinitionBlockNew>("particle systems", 32));
        }
        /// <summary>
        /// Gets and returns the name of the effect_event_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "effect_event_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the effect_event_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "effect_event_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the effect_event_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 32;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the effect_event_block tag block.
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
