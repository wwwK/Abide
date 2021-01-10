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
    /// Represents the generated player_information_block tag block.
    /// </summary>
    internal sealed class PlayerInformationBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerInformationBlock"/> class.
        /// </summary>
        public PlayerInformationBlock()
        {
            this.Fields.Add(new TagReferenceField("unused", 1970170228));
            this.Fields.Add(new PadField("", 28));
            this.Fields.Add(new RealField("walking speed:world units per second"));
            this.Fields.Add(new PadField("", 4));
            this.Fields.Add(new RealField("run forward:world units per second"));
            this.Fields.Add(new RealField("run backward:world units per second"));
            this.Fields.Add(new RealField("run sideways:world units per second"));
            this.Fields.Add(new RealField("run acceleration:world units per second squared"));
            this.Fields.Add(new RealField("sneak forward:world units per second"));
            this.Fields.Add(new RealField("sneak backward:world units per second"));
            this.Fields.Add(new RealField("sneak sideways:world units per second"));
            this.Fields.Add(new RealField("sneak acceleration:world units per second squared"));
            this.Fields.Add(new RealField("airborne acceleration:world units per second squared"));
            this.Fields.Add(new PadField("", 16));
            this.Fields.Add(new RealPoint3dField("grenade origin"));
            this.Fields.Add(new PadField("", 12));
            this.Fields.Add(new RealField("stun movement penalty:[0,1]#1.0 prevents moving while stunned"));
            this.Fields.Add(new RealField("stun turning penalty:[0,1]#1.0 prevents turning while stunned"));
            this.Fields.Add(new RealField("stun jumping penalty:[0,1]#1.0 prevents jumping while stunned"));
            this.Fields.Add(new RealField("minimum stun time:seconds#all stunning damage will last for at least this long"));
            this.Fields.Add(new RealField("maximum stun time:seconds#no stunning damage will last for longer than this"));
            this.Fields.Add(new PadField("", 8));
            this.Fields.Add(new RealBoundsField("first person idle time:seconds"));
            this.Fields.Add(new RealFractionField("first person skip fraction:[0,1]"));
            this.Fields.Add(new PadField("", 16));
            this.Fields.Add(new TagReferenceField("coop respawn effect", 1701209701));
            this.Fields.Add(new LongIntegerField("binoculars zoom count"));
            this.Fields.Add(new RealBoundsField("binoculars zoom range"));
            this.Fields.Add(new TagReferenceField("binoculars zoom in sound", 1936614433));
            this.Fields.Add(new TagReferenceField("binoculars zoom out sound", 1936614433));
            this.Fields.Add(new PadField("", 16));
            this.Fields.Add(new TagReferenceField("active camouflage on", 1936614433));
            this.Fields.Add(new TagReferenceField("active camouflage off", 1936614433));
            this.Fields.Add(new TagReferenceField("active camouflage error", 1936614433));
            this.Fields.Add(new TagReferenceField("active camouflage ready", 1936614433));
            this.Fields.Add(new TagReferenceField("flashlight on", 1936614433));
            this.Fields.Add(new TagReferenceField("flashlight off", 1936614433));
            this.Fields.Add(new TagReferenceField("ice cream", 1936614433));
        }
        /// <summary>
        /// Gets and returns the name of the player_information_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "player_information_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the player_information_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "player_information_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the player_information_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the player_information_block tag block.
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
