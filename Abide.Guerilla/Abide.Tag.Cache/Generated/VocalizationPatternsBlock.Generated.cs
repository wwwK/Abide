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
    /// Represents the generated vocalization_patterns_block tag block.
    /// </summary>
    public sealed class VocalizationPatternsBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VocalizationPatternsBlock"/> class.
        /// </summary>
        public VocalizationPatternsBlock()
        {
            this.Fields.Add(new EnumField("dialogue type", "death", "unused", "unused", "damage", "damage unused 1", "damage unused 2", "sighted_new", "sighted_new major", "unused", "sighted_old", "sighted_first", "sighted_special", "unused", "heard_new", "unused", "heard_old", "unused", "unused", "unused", "acknowledge_multiple", "unused", "unused", "unused", "found_unit", "found_unit_presearch", "found_unit_pursuit", "found_unit_self_preserving", "found_unit_retreating", "throwing_grenade", "noticed_grenade", "fighting", "charging", "suppressing_fire", "grenade_uncover", "unused", "unused", "dive", "evade", "avoid", "surprised", "unused", "unused", "presearch", "presearch_start", "search", "search_start", "investigate_failed", "uncover_failed", "pursuit_failed", "investigate_start", "abandoned_search_space", "abandoned_search_time", "presearch_failed", "abandoned_search_restricted", "investigate_pursuit_start", "postcombat_inspect_body", "vehicle_slow_down", "vehicle_get_in", "idle", "taunt", "taunt_reply", "retreat", "retreat_from_scary_target", "retreat_from_dead_leader", "retreat_from_proximity", "retreat_from_low_shield", "flee", "cowering", "unused", "unused", "unused", "cover", "covered", "unused", "unused", "unused", "pursuit_start", "pursuit_sync_start", "pursuit_sync_join", "pursuit_sync_quorum", "melee", "unused", "unused", "unused", "vehicle_falling", "vehicle_woohoo", "vehicle_scared", "vehicle_crazy", "unused", "unused", "leap", "unused", "unused", "postcombat_win", "postcombat_lose", "postcombat_neutral", "shoot_corpse", "postcombat start", "inspect_body_start", "postcombat_status", "unused", "vehicle_entry_start_driver", "vehicle_enter", "vehicle_entry_start_gun", "vehicle_entry_start_passenger", "vehicle_exit", "evict_driver", "evict_gunner", "evict_passenger", "unused", "unused", "new_order_advance", "new_order_charge", "new_order_fallback", "new_order_retreat", "new_order_moveon", "new_order_arrival", "new_order_entervcl", "new_order_exitvcl", "new_order_fllplr", "new_order_leaveplr", "new_order_support", "unused", "unused", "unused", "unused", "unused", "unused", "unused", "unused", "unused", "unused", "unused", "unused", "emerge", "unused", "unused", "unused", "curse", "unused", "unused", "unused", "threaten", "unused", "unused", "unused", "cover_friend", "unused", "unused", "unused", "strike", "unused", "unused", "unused", "unused", "unused", "unused", "unused", "unused", "gloat", "unused", "unused", "unused", "greet", "unused", "unused", "unused", "unused", "player_look", "player_look_longtime", "unused", "unused", "unused", "unused", "panic_grenade_attached", "unused", "unused", "unused", "unused", "help response", "unused", "unused", "unused", "remind", "unused", "unused", "unused", "unused", "weapon_trade_better", "weapon_trade_worse", "weapon_reade_equal", "unused", "unused", "unused", "betray", "unused", "forgive", "unused", "reanimate", "unused"));
            this.Fields.Add(new ShortIntegerField("vocalization index"));
            this.Fields.Add(new StringIdField("vocalization name"));
            this.Fields.Add(new EnumField("speaker type", "subject", "cause", "friend", "target", "enemy", "vehicle", "joint", "squad", "leader", "joint_leader", "clump", "peer"));
            this.Fields.Add(new WordFlagsField("flags", "subject visible", "cause visible", "friends present", "subject is speaker\'s target", "cause is speaker\'s target", "cause is player or speaker is player ally", "speaker is searching", "speaker is following player", "cause is primary player ally"));
            this.Fields.Add(new EnumField("listener/target#who/what am I speaking to/of?", "subject", "cause", "friend", "target", "enemy", "vehicle", "joint", "squad", "leader", "joint_leader", "clump", "peer"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new PadField("", 4));
            this.Fields.Add(new EnumField("hostility#The relationship between the subject and the cause", "NONE", "self", "neutral", "friend", "enemy", "traitor"));
            this.Fields.Add(new EnumField("damage type", "NONE", "falling", "bullet", "grenade", "explosive", "sniper", "melee", "flame", "mounted weapon", "vehicle", "plasma", "needle", "shotgun"));
            this.Fields.Add(new EnumField("danger level#Speaker must have danger level of at least this much", "NONE", "broadly facing", "shooting near", "shooting at", "extremely close", "shield damage", "shield extended damage", "body damage", "body extended damage"));
            this.Fields.Add(new EnumField("attitude", "Normal", "Timid", "Aggressive"));
            this.Fields.Add(new PadField("", 4));
            this.Fields.Add(new EnumField("subject actor type", "NONE", "elite", "jackal", "grunt", "hunter", "engineer", "assassin", "player", "marine", "crew", "combat form", "infection form", "carrier form", "monitor", "sentinel", "none", "mounted weapon", "brute", "prophet", "bugger", "juggernaut"));
            this.Fields.Add(new EnumField("cause actor type", "NONE", "elite", "jackal", "grunt", "hunter", "engineer", "assassin", "player", "marine", "crew", "combat form", "infection form", "carrier form", "monitor", "sentinel", "none", "mounted weapon", "brute", "prophet", "bugger", "juggernaut"));
            this.Fields.Add(new EnumField("cause type", "NONE", "player", "actor", "biped", "body", "vehicle", "projectile", "actor or player", "turret", "unit in vehicle", "unit in turret", "driver", "gunner", "passenger", "postcombat", "postcombat_won", "postcombat_lost", "player masterchief", "player dervish", "heretic", "majorly scary", "last man in vehicle", "male", "female", "grenade"));
            this.Fields.Add(new EnumField("subject type", "NONE", "player", "actor", "biped", "body", "vehicle", "projectile", "actor or player", "turret", "unit in vehicle", "unit in turret", "driver", "gunner", "passenger", "postcombat", "postcombat_won", "postcombat_lost", "player masterchief", "player dervish", "heretic", "majorly scary", "last man in vehicle", "male", "female", "grenade"));
            this.Fields.Add(new StringIdField("cause ai type name"));
            this.Fields.Add(new EnumField("spatial relation#with respect to the subject, the cause is ...", "none", "very near (<1wu)", "near (<2.5wus)", "medium range (<5wus)", "far (<10wus)", "very far (>10wus)", "in front of", "behind", "above (delta>1 wu)", "below (delta>1 wu)"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new StringIdField("subject ai type name"));
            this.Fields.Add(new PadField("", 8));
            this.Fields.Add(new LongFlagsField("Conditions", "asleep", "idle", "alert", "active", "uninspected orphan", "definite orphan", "certain orphan", "visible enemy", "clear los enemy", "dangerous enemy", "no vehicle", "vehicle driver", "vehicle passenger"));
        }
        /// <summary>
        /// Gets and returns the name of the vocalization_patterns_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "vocalization_patterns_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the vocalization_patterns_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "vocalization_patterns_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the vocalization_patterns_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1000;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the vocalization_patterns_block tag block.
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