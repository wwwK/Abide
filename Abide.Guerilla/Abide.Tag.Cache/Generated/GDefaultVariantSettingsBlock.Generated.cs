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
    /// Represents the generated g_default_variant_settings_block tag block.
    /// </summary>
    public sealed class GDefaultVariantSettingsBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GDefaultVariantSettingsBlock"/> class.
        /// </summary>
        public GDefaultVariantSettingsBlock()
        {
            this.Fields.Add(new LongEnumField("setting category^", "match round setting", "match ctf score to win", "match slayer score to win round", "match oddball score to win round", "match king score to win round", "match race score to win round", "match headhunter score to win round", "match juggernaut score to win round", "match territories score to win round", "match assault score to win round", "match round time limit", "match rounds reset map", "match tie resolution", "match observers", "match join in progress", "maximum players", "lives per round", "respawn time", "suicide penalty", "shields", "motion sensor", "invisibility", "team changing", "team scoring", "friendly fire", "team respawn setting", "betrayal respawn penalty", "team killer management", "slayer bonus points", "slayer suicide point loss", "slayer death point loss", "headhunter moving head bin", "headhunter point multiplier", "headhunter suicide point loss", "headhunter death point loss", "headhunter uncontested bin", "headhunter speed with heads", "headhunter max heads carried", "king uncontested hill", "king team time multiplier", "king moving hill", "king extra damage on hill", "king dmg resistance on hill", "oddball ball spawn count", "oddball ball hit damage", "oddball speed with ball", "oddball driving gunning with ball", "oddball waypoint to ball", "race random track", "race uncontested flag", "ctf game type", "ctf sudden death", "ctf flag may be returned", "ctf flag at home to score", "ctf flag reset time", "ctf speed with flag", "ctf flag hit damage", "ctf driving gunning with flag", "ctf waypoint to own flag", "assault game type", "assault sudden death", "assault detonation time", "assault bomb at home to score", "assault arming time", "assault speed with bomb", "assault bomb hit damage", "assault driving gunning with bomb", "assault waypoint to own bomb", "juggernaut betrayal point loss", "juggernaut juggy extra damage", "juggernaut juggy infinite ammo", "juggernaut juggy overshields", "juggernaut juggy active camo", "juggernaut juggy motion sensor", "territories territory count", "veh. respawn", "veh. primary light land", "veh. secondary light land", "veh. primary heavy land", "veh. primary flying", "veh. secondary heavy land", "veh. primary turret", "veh. secondary turret", "equip. weapons on map", "equip. overshields on map", "equip. active camo on map", "equip. grenades on map", "equip. weapon respawn times", "equip. starting grenades", "equip. primary starting equipment", "UNS. max. living players", "UNS. teams enabled", "UNS. assault bomb may be returned", "UNS. max. teams", "UNS. equip. secondary starting equipment", "UNS. assault fuse time", "UNS. juggy movement", "UNS. sticky fuse", "UNS. terr. contest time", "UNS. terr. control time", "UNS. oddb. carr. invis", "UNS. king invis in hill", "UNS. ball carr. dmg. resis.", "UNS. king dmg. res. in hill", "UNS. players ex. dmg", "UNS. players dmg. resis.", "UNS. ctf carr. dmg. resis.", "UNS. ctf carr. invis.", "UNS. juggy dmg. resis.", "UNS. bomb carr. dmg. resis.", "UNS. bomb carr. invis.", "UNS. force even teams"));
            this.Fields.Add(new LongIntegerField("value"));
        }
        /// <summary>
        /// Gets and returns the name of the g_default_variant_settings_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "g_default_variant_settings_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the g_default_variant_settings_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "g_default_variant_settings_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the g_default_variant_settings_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 112;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the g_default_variant_settings_block tag block.
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
