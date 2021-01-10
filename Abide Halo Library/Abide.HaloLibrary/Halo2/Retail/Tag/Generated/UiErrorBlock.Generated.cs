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
    /// Represents the generated ui_error_block tag block.
    /// </summary>
    internal sealed class UiErrorBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UiErrorBlock"/> class.
        /// </summary>
        public UiErrorBlock()
        {
            this.Fields.Add(new LongEnumField("error", "error_unknown", "error_generic", "error_generic_networking", "error_system_link_generic_join_failure", "error_system_link_no_network_connection", "error_system_link_connection_lost", "error_network_game_oos", "error_xbox_live_sign_out_confirmation", "error_confirm_revert_to_last_save", "error_confirm_quit_without_save", "error_confirm_delete_player_profile", "error_confirm_delete_variant_file", "error_player_profile_creation_failed", "error_variant_profile_creation_failed", "error_playlist_creation_failed", "error_core_file_load_failed", "error_mu_removed_during_player_profile_save", "error_mu_removed_during_variant_save", "error_mu_removed_during_playlist_save", "error_message_saving_to_mu", "error_message_saving_file", "error_message_creating_player_profile", "error_message_creating_variant_profile", "error_message_saving_checkpoint", "error_failed_to_load_player_profile", "error_failed_to_load_variant", "error_failed_to_load_playlist", "error_failed_to_load_save_game", "error_controller1_removed", "error_controller2_removed", "error_controller3_removed", "error_controller4_removed", "error_need_more_free_blocks_to_save", "error_maximum_saved_game_files_already_exist", "error_dirty_disk", "error_xblive_cannot_access_service", "error_xblive_title_update_required", "error_xblive_servers_too_busy", "error_xblive_duplicate_logon", "error_xblive_account_management_required", "error_warning_xblive_recommended_messages_available", "error_xblive_invalid_match_session", "error_warning_xblive_poor_network_performance", "error_not_enough_open_slots_to_join_match_session", "error_xblive_corrupt_download_content", "error_confirm_xblive_corrupt_saved_game_file_removal", "error_xblive_invalid_user_account", "error_confirm_boot_clan_member", "error_confirm_controller_sign_out", "error_beta_xblive_service_qos_report", "error_beta_feature_disabled", "error_beta_network_connection_required", "error_confirm_friend_removal", "error_confirm_boot_to_dash", "error_confirm_launch_xdemos", "error_confirm_exit_game_session", "error_xblive_connection_to_xbox_live_lost", "error_xblive_message_send_failure", "error_network_link_lost", "error_network_link_required", "error_xblive_invalid_passcode", "error_join_aborted", "error_join_session_not_found", "error_join_qos_failure", "error_join_data_decode_failure", "error_join_game_full", "error_join_game_closed", "error_join_version_mismatch", "error_join_failed_unknown_reason", "error_join_failed_friend_in_matchmade_game", "error_player_profile_name_must_be_unique", "error_variant_name_must_be_unique", "error_playlist_name_must_be_unique", "error_saved_film_name_must_be_unique", "error_no_free_slots_player_profile", "error_no_free_slots_variant", "error_no_free_slots_playlist", "error_no_free_slots_saved_film", "error_need_more_space_for_player_profile", "error_need_more_space_for_variant", "error_need_more_space_for_playlist", "error_need_more_space_for_saved_film", "error_cannot_set_privileges_on_member_whose_data_not_known", "error_cant_delete_default_profile", "error_cant_delete_default_variant", "error_cant_delete_default_playlist", "error_cant_delete_default_saved_film", "error_cant_delete_profile_in_use", "error_player_profile_name_must_have_alphanumeric_characters", "error_variant_name_must_have_alphanumeric_characters", "error_playlist_name_must_have_alphanumeric_characters", "error_saved_film_name_must_have_alphanumeric_characters", "error_teams_not_a_member", "error_teams_insufficient_privileges", "error_teams_server_busy", "error_teams_team_full", "error_teams_member_pending", "error_teams_too_many_requests", "error_teams_user_already_exists", "error_teams_user_not_found", "error_teams_user_teams_full", "error_teams_no_task", "error_teams_too_many_teams", "error_teams_team_already_exists", "error_teams_team_not_found", "error_teams_name_contains_bad_words", "error_teams_description_contains_bad_words", "error_teams_motto_contains_bad_words", "error_teams_url_contains_bad_words", "error_teams_no_admin", "error_teams_cannot_set_privileges_on_member_whose_data_not_known", "error_live_unknown", "error confirm_delete_profile", "error confirm_delete_playlist", "error confirm_delete_saved_film", "error confirm_live_sign_out", "error confirm_confirm_friend_removal", "error confirm_promotion_to_superuser", "error warn_no_more_clan_superusers", "error confirm_corrupt_profile", "error confirm_xbox_live_sign_out", "error confirm_corrupt_game_variant", "error confirm_leave_clan", "error confirm_corrupt_playlist", "error_cant_join_gameinvite_without_signon", "error confirm_proceed_to_crossgame_invite", "error confirm_decline_crossgame_invite", "error warn_insert_cd_for_crossgame_invite", "error need more space for saved game", "error saved game cannot be loaded", "error confirm controller signout with guests", "error warning party closed", "error warning party required", "error warning party full", "error warning player in mm game", "error xblive failed to sign in", "error cant sign out master with guests", "error obsolete dot command", "error not unlocked", "confirm leave lobby", "error confirm party leader leave matchmaking", "error confirm single box leave matchmaking", "error invalid clan name", "error player list full", "error blocked by player", "error friend pending", "error too many requests", "error player already in list", "error gamertag not found", "error cannot message self", "error warning last overlord cant leave clan", "error confirm boot player", "error confirm party member leave pcr", "error cannot sign in during countdown", "error xbl invalid user", "error xbl user not authorized", "OBSOLETE", "OBSOLETE2", "error xbl banned xbox", "error xbl banned user", "error xbl banned title", "error confirm exit game session leader", "error message objectionable content", "error confirm enter downloader", "error confirm block user", "error confirm negative feedback", "error confirm change clan member level", "error blank gamertag", "confirm save & quit game", "error cant join during matchmaking", "error confirm restart level", "matchmaking failure generic", "matchmaking failure missing content", "matchmaking failure aborted", "matchmaking failure membership changed", "confirm end game session", "confirm exit game session only player", "confirm exit game session xbox live ranked leader", "confirm exit game session xbox live ranked", "confirm exit game session xbox live leader", "confirm exit game session xbox live only player", "confirm exit game session xbox live", "recipient\'s list full", "confirm quit campaign (no save)", "xblive connection to xbox live lost save and quit", "booted from session", "confirm_exit_game_session_xbox_live_guest", "confirm_exit_game_session_xbox_live_ranked_only_player", "confirm_exit_game_session_xbox_live_unranked_only_player", "confirm_exit_game_session_xbox_live_unranked_leader", "confirm_exit_game_session_xbox_live_unranked", "cant join friend while in matchmade game", "map load failure", "error_achievements_interrupted", "confirm_lose_progress", "error_beta_achievements_disabled", "error_cannot_connect_versions_wrong", "confirm_booted_from_session", "confirm_boot_player_from_squad", "confirm_leave_system_link_lobby", "confirm_party_member_leave_matchmaking", "confirm_quit_single_player", "error_controller_removed", "error_download_in_progress", "error_download_fail", "error_failed_to_load_map", "error_feature_requires_gold", "error_keyboard_mapping", "error_keyboard_removed", "error_live_game_unavailable", "error_map_missing", "error_matchmaking_failed_generic", "error_matchmaking_failed_missing_content", "error_mouse_removed", "error_party_not_all_on_live", "error_party_subnet_not_shared", "error_required_game_update", "error_saved_game_cannot_be_saved", "error_sound_microphone_not_supported", "error_system_link_direct_IP", "error_text_chat_muted", "error_text_chat_parental_controls", "error_update_start", "error_update_fail", "error_update_fail_blocks", "error_update_exists", "error_insert_original", "error_update_fail_network_lost", "error_update_mp_out_of_sync", "error_update_must_upgrade", "error_voice_gold_required", "error_voice_parental_controls", "error_warning_xblive_poor_network_perofrmance", "error_you_missing_map", "error_someone_missing_map", "error_tnp_no_source", "error_tnp_disk_read", "error_tnp_no_engine_running", "error_tnp_signature_verification", "error_tnp_drive_removed", "error_tnp_disk_full", "error_tnp_permissions", "error_tnp_unknown", "continue_install", "cancel_install", "error_confirm_upsell_gold", "error_add_to_favorites", "error_remove_from_favorites", "error_updating_favorites", "choose existing checkpoint location", "choose new checkpoint location (checkpoints exist on live and local)", "choose new checkpoint location (checkpoints exist on live)", "choose new checkpoint location (checkpoints exist locally)", "xxx"));
            this.Fields.Add(new WordFlagsField("flags", "use large dialog"));
            this.Fields.Add(new CharEnumField("default button", "no default", "default ok", "default cancel"));
            this.Fields.Add(new PadField("", 1));
            this.Fields.Add(new StringIdField("title"));
            this.Fields.Add(new StringIdField("message"));
            this.Fields.Add(new StringIdField("ok"));
            this.Fields.Add(new StringIdField("cancel"));
        }
        /// <summary>
        /// Gets and returns the name of the ui_error_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "ui_error_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the ui_error_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "ui_error_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the ui_error_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 100;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the ui_error_block tag block.
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
