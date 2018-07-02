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
    using Abide.Tag;
    
    /// <summary>
    /// Represents the generated squads_block tag block.
    /// </summary>
    public sealed class SquadsBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SquadsBlock"/> class.
        /// </summary>
        public SquadsBlock()
        {
            this.Fields.Add(new StringField("name^"));
            this.Fields.Add(new LongFlagsField("flags", "unused", "never search", "start timer immediately", "no timer, delay forever", "magic sight after timer", "automatic migration", "DEPRECATED", "respawn enabled", "blind", "deaf", "braindead", "3d_firing_positions", "initially placed", "units not enterable by player"));
            this.Fields.Add(new EnumField("team", "default", "player", "human", "covenant", "flood", "sentinel", "heretic", "prophet", "unused8", "unused9", "unused10", "unused11", "unused12", "unused13", "unused14", "unused15"));
            this.Fields.Add(new ShortBlockIndexField("parent"));
            this.Fields.Add(new RealField("squad delay time:seconds"));
            this.Fields.Add(new ShortIntegerField("normal diff count#initial number of actors on normal difficulty"));
            this.Fields.Add(new ShortIntegerField("insane diff count#initial number of actors on insane difficulty (hard difficulty " +
                        "is midway between normal and insane)"));
            this.Fields.Add(new EnumField("major upgrade", "normal", "few", "many", "none", "all"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new ExplanationField("Actor defaults", "The following default values are used for spawned actors"));
            this.Fields.Add(new ShortBlockIndexField("vehicle type"));
            this.Fields.Add(new ShortBlockIndexField("character type"));
            this.Fields.Add(new ShortBlockIndexField("initial zone"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new ShortBlockIndexField("initial weapon"));
            this.Fields.Add(new ShortBlockIndexField("initial secondary weapon"));
            this.Fields.Add(new EnumField("grenade type", "NONE", "Human grenade", "Covenant Plasma"));
            this.Fields.Add(new ShortBlockIndexField("initial order"));
            this.Fields.Add(new StringIdField("vehicle variant"));
            this.Fields.Add(new BlockField<ActorStartingLocationsBlock>("starting locations", 32));
            this.Fields.Add(new StringField("Placement script"));
            this.Fields.Add(new SkipField("", 2));
            this.Fields.Add(new PadField("", 2));
        }
        /// <summary>
        /// Gets and returns the name of the squads_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "squads_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the squads_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "squads_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the squads_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 335;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the squads_block tag block.
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
