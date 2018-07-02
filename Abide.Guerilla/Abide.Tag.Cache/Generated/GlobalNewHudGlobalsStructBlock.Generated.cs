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
    /// Represents the generated global_new_hud_globals_struct_block tag block.
    /// </summary>
    public sealed class GlobalNewHudGlobalsStructBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalNewHudGlobalsStructBlock"/> class.
        /// </summary>
        public GlobalNewHudGlobalsStructBlock()
        {
            this.Fields.Add(new TagReferenceField("hud text", "unic"));
            this.Fields.Add(new BlockField<HudDashlightsBlock>("dashlights", 9));
            this.Fields.Add(new BlockField<HudWaypointArrowBlock>("waypoint arrows", 4));
            this.Fields.Add(new BlockField<HudWaypointBlock>("waypoints", 8));
            this.Fields.Add(new BlockField<NewHudSoundBlock>("hud sounds", 6));
            this.Fields.Add(new BlockField<PlayerTrainingEntryDataBlock>("player training data", 32));
            this.Fields.Add(new StructField<GlobalNewHudGlobalsConstantsStructBlock>("constants"));
        }
        /// <summary>
        /// Gets and returns the name of the global_new_hud_globals_struct_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "global_new_hud_globals_struct_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the global_new_hud_globals_struct_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "global_new_hud_globals_struct";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the global_new_hud_globals_struct_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the global_new_hud_globals_struct_block tag block.
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
