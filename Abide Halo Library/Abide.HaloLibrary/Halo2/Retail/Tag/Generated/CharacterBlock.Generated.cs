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
    /// Represents the generated character_block tag block.
    /// </summary>
    public sealed class CharacterBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterBlock"/> class.
        /// </summary>
        public CharacterBlock()
        {
            this.Fields.Add(new LongFlagsField("Character flags", "Flag1"));
            this.Fields.Add(new TagReferenceField("parent character", 1667785074));
            this.Fields.Add(new TagReferenceField("unit", 1970170228));
            this.Fields.Add(new TagReferenceField("creature#Creature reference for swarm characters ONLY", 1668441441));
            this.Fields.Add(new TagReferenceField("style", 1937013100));
            this.Fields.Add(new TagReferenceField("major character", 1667785074));
            this.Fields.Add(new BlockField<CharacterVariantsBlock>("variants", 64));
            this.Fields.Add(new BlockField<CharacterGeneralBlock>("general properties", 1));
            this.Fields.Add(new BlockField<CharacterVitalityBlock>("vitality properties", 1));
            this.Fields.Add(new BlockField<CharacterPlacementBlock>("placement properties", 1));
            this.Fields.Add(new BlockField<CharacterPerceptionBlock>("perception properties", 4));
            this.Fields.Add(new BlockField<CharacterLookBlock>("look properties", 1));
            this.Fields.Add(new BlockField<CharacterMovementBlock>("movement properties", 1));
            this.Fields.Add(new BlockField<CharacterSwarmBlock>("swarm properties", 3));
            this.Fields.Add(new BlockField<CharacterReadyBlock>("ready properties", 3));
            this.Fields.Add(new BlockField<CharacterEngageBlock>("engage properties", 3));
            this.Fields.Add(new BlockField<CharacterChargeBlock>("charge properties", 3));
            this.Fields.Add(new ExplanationField("Danger Values", "Danger values can be found in the ai-globals section of the globals tag."));
            this.Fields.Add(new BlockField<CharacterEvasionBlock>("evasion properties", 3));
            this.Fields.Add(new BlockField<CharacterCoverBlock>("cover properties", 3));
            this.Fields.Add(new BlockField<CharacterRetreatBlock>("retreat properties", 3));
            this.Fields.Add(new BlockField<CharacterSearchBlock>("search properties", 3));
            this.Fields.Add(new BlockField<CharacterPresearchBlock>("pre-search properties", 3));
            this.Fields.Add(new BlockField<CharacterIdleBlock>("idle properties", 3));
            this.Fields.Add(new BlockField<CharacterVocalizationBlock>("vocalization properties", 1));
            this.Fields.Add(new BlockField<CharacterBoardingBlock>("boarding properties", 1));
            this.Fields.Add(new BlockField<CharacterBossBlock>("boss properties", 1));
            this.Fields.Add(new BlockField<CharacterWeaponsBlock>("weapons properties", 100));
            this.Fields.Add(new BlockField<CharacterFiringPatternPropertiesBlock>("firing pattern properties", 100));
            this.Fields.Add(new BlockField<CharacterGrenadesBlock>("grenades properties", 10));
            this.Fields.Add(new BlockField<CharacterVehicleBlock>("vehicle properties", 100));
        }
        /// <summary>
        /// Gets and returns the name of the character_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "character_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the character_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "character";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the character_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the character_block tag block.
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
