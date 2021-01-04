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
    /// Represents the generated hs_globals_block tag block.
    /// </summary>
    public sealed class HsGlobalsBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HsGlobalsBlock"/> class.
        /// </summary>
        public HsGlobalsBlock()
        {
            this.Fields.Add(new StringField("name*"));
            this.Fields.Add(new EnumField("type*", "unparsed", "special form", "function name", "passthrough", "void", "boolean", "real", "short", "long", "string", "script", "string_id", "unit_seat_mapping", "trigger_volume", "cutscene_flag", "cutscene_camera_point", "cutscene_title", "cutscene_recording", "device_group", "ai", "ai_command_list", "ai_command_script", "ai_behavior", "ai_orders", "starting_profile", "conversation", "structure_bsp", "navpoint", "point reference", "style", "hud_message", "object_list", "sound", "effect", "damage", "looping_sound", "animation_graph", "damage_effect", "object_definition", "bitmap", "shader", "render model", "structure definition", "lightmap definition", "game_difficulty", "team", "actor_type", "hud_corner", "model_state", "network_event", "object", "unit", "vehicle", "weapon", "device", "scenery", "object_name", "unit_name", "vehicle_name", "weapon_name", "device_name", "scenery_name"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new LongIntegerField("initialization expression index*"));
        }
        /// <summary>
        /// Gets and returns the name of the hs_globals_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "hs_globals_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the hs_globals_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "hs_globals_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the hs_globals_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 256;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the hs_globals_block tag block.
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
