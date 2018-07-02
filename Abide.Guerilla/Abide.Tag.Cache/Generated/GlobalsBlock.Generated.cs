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
    /// Represents the generated globals_block tag block.
    /// </summary>
    public sealed class GlobalsBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalsBlock"/> class.
        /// </summary>
        public GlobalsBlock()
        {
            this.Fields.Add(new PadField("", 172));
            this.Fields.Add(new LongEnumField("language", "english", "japanese", "german", "french", "spanish", "italian", "korean", "chinese", "portuguese"));
            this.Fields.Add(new BlockField<HavokCleanupResourcesBlock>("havok cleanup resources", 1));
            this.Fields.Add(new BlockField<CollisionDamageBlock>("collision damage", 1));
            this.Fields.Add(new BlockField<SoundGlobalsBlock>("sound globals", 1));
            this.Fields.Add(new BlockField<AiGlobalsBlock>("ai globals", 1));
            this.Fields.Add(new BlockField<GameGlobalsDamageBlock>("damage table", 1));
            this.Fields.Add(new BlockField<GNullBlock>("", 0));
            this.Fields.Add(new BlockField<GlobalsObsoleteSoundBlock>("sounds (obsolete)", 32767));
            this.Fields.Add(new BlockField<CameraBlock>("camera", 1));
            this.Fields.Add(new BlockField<PlayerControlBlock>("player control", 1));
            this.Fields.Add(new BlockField<DifficultyBlock>("difficulty", 1));
            this.Fields.Add(new BlockField<GrenadesBlock>("grenades", 2));
            this.Fields.Add(new BlockField<RasterizerDataBlock>("rasterizer data", 1));
            this.Fields.Add(new BlockField<InterfaceTagReferences>("interface tags", 1));
            this.Fields.Add(new BlockField<CheatWeaponsBlock>("@weapon list (update _weapon_list enum in game_globals.h)", 20));
            this.Fields.Add(new BlockField<CheatPowerupsBlock>("@cheat powerups", 20));
            this.Fields.Add(new BlockField<MultiplayerInformationBlock>("@multiplayer information", 1));
            this.Fields.Add(new BlockField<PlayerInformationBlock>("@player information", 1));
            this.Fields.Add(new BlockField<PlayerRepresentationBlock>("@player representation", 4));
            this.Fields.Add(new BlockField<FallingDamageBlock>("falling damage", 1));
            this.Fields.Add(new BlockField<OldMaterialsBlock>("old materials", 33));
            this.Fields.Add(new BlockField<MaterialsBlock>("materials", 256));
            this.Fields.Add(new BlockField<MultiplayerUiBlock>("multiplayer UI", 1));
            this.Fields.Add(new BlockField<MultiplayerColorBlock>("profile colors", 32));
            this.Fields.Add(new TagReferenceField("multiplayer globals", "mulg"));
            this.Fields.Add(new BlockField<RuntimeLevelsDefinitionBlock>("runtime level data", 1));
            this.Fields.Add(new BlockField<UiLevelsDefinitionBlock>("ui level data", 1));
            this.Fields.Add(new ExplanationField("Default global lighting", ""));
            this.Fields.Add(new TagReferenceField("default global lighting", "gldf"));
            this.Fields.Add(new StructField<GlobalsMultilingualUnicodeInfoStructBlock>("multilingual unicode info"));
        }
        /// <summary>
        /// Gets and returns the name of the globals_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "globals_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the globals_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "globals";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the globals_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the globals_block tag block.
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
