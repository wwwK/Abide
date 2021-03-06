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
    /// Represents the generated character_perception_block tag block.
    /// </summary>
    internal sealed class CharacterPerceptionBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterPerceptionBlock"/> class.
        /// </summary>
        public CharacterPerceptionBlock()
        {
            this.Fields.Add(new LongFlagsField("perception flags", "Flag1"));
            this.Fields.Add(new RealField("max vision distance:world units#maximum range of sight"));
            this.Fields.Add(new AngleField("central vision angle:degrees#horizontal angle within which we see targets out to " +
                        "our maximum range"));
            this.Fields.Add(new AngleField("max vision angle:degrees#maximum horizontal angle within which we see targets at " +
                        "range"));
            this.Fields.Add(new AngleField("peripheral vision angle:degrees#maximum horizontal angle within which we can see " +
                        "targets out of the corner of our eye"));
            this.Fields.Add(new RealField("peripheral distance:world units#maximum range at which we can see targets our of " +
                        "the corner of our eye"));
            this.Fields.Add(new RealField("hearing distance:world units#maximum range at which sounds can be heard"));
            this.Fields.Add(new RealField("notice projectile chance:[0,1]#random chance of noticing a dangerous enemy projec" +
                        "tile (e.g. grenade)"));
            this.Fields.Add(new RealField("notice vehicle chance:[0,1]#random chance of noticing a dangerous vehicle"));
            this.Fields.Add(new RealField("combat perception time:seconds#time required to acknowledge a visible enemy when " +
                        "we are already in combat or searching for them"));
            this.Fields.Add(new RealField("guard perception time:seconds#time required to acknowledge a visible enemy when w" +
                        "e have been alerted"));
            this.Fields.Add(new RealField("non-combat perception time:seconds#time required to acknowledge a visible enemy w" +
                        "hen we are not alerted"));
            this.Fields.Add(new RealField("first ack. surprise distance:world units#If a new prop is acknowledged within the" +
                        " given distance, surprise is registerd"));
        }
        /// <summary>
        /// Gets and returns the name of the character_perception_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "character_perception_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the character_perception_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "character_perception_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the character_perception_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 4;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the character_perception_block tag block.
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
