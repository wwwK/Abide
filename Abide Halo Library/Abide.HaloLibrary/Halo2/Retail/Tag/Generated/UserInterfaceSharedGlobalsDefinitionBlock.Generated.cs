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
    /// Represents the generated user_interface_shared_globals_definition_block tag block.
    /// </summary>
    internal sealed class UserInterfaceSharedGlobalsDefinitionBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserInterfaceSharedGlobalsDefinitionBlock"/> class.
        /// </summary>
        public UserInterfaceSharedGlobalsDefinitionBlock()
        {
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new PadField("", 16));
            this.Fields.Add(new PadField("", 8));
            this.Fields.Add(new PadField("", 8));
            this.Fields.Add(new PadField("", 16));
            this.Fields.Add(new PadField("", 8));
            this.Fields.Add(new PadField("", 8));
            this.Fields.Add(new ExplanationField("UI Rendering Globals", "miscellaneous rendering globals, more below..."));
            this.Fields.Add(new RealField("overlayed screen alpha mod"));
            this.Fields.Add(new ShortIntegerField("inc. text update period:milliseconds"));
            this.Fields.Add(new ShortIntegerField("inc. text block character:ASCII code"));
            this.Fields.Add(new RealField("callout text scale"));
            this.Fields.Add(new RealArgbColorField("progress bar color"));
            this.Fields.Add(new RealField("near clip plane distance:objects closer than this are not drawn"));
            this.Fields.Add(new RealField("projection plane distance:distance at which objects are rendered when z=0 (normal" +
                        " size)"));
            this.Fields.Add(new RealField("far clip plane distance:objects farther than this are not drawn"));
            this.Fields.Add(new ExplanationField("Overlayed UI Color", "This is the color of the overlayed ui effect; the alpha component is the maximum " +
                        "opacity"));
            this.Fields.Add(new RealArgbColorField("overlayed interface color"));
            this.Fields.Add(new PadField("", 12));
            this.Fields.Add(new ExplanationField("Displayed Errors", "For each error condition displayed in the UI, set the title and description strin" +
                        "g ids here"));
            this.Fields.Add(new BlockField<UiErrorCategoryBlock>("errors", 100));
            this.Fields.Add(new ExplanationField("Cursor Sound", "This is the sound that plays as you tab through items"));
            this.Fields.Add(new TagReferenceField("sound tag", 1936614433));
            this.Fields.Add(new ExplanationField("Selection Sound", "This is the sound that plays when an item is selected"));
            this.Fields.Add(new TagReferenceField("sound tag", 1936614433));
            this.Fields.Add(new ExplanationField("Error Sound", "This is the sound that plays to alert the user that something went wrong"));
            this.Fields.Add(new TagReferenceField("sound tag", 1936614433));
            this.Fields.Add(new ExplanationField("Advancing Sound", "This is the sound that plays when advancing to a new screen"));
            this.Fields.Add(new TagReferenceField("sound tag", 1936614433));
            this.Fields.Add(new ExplanationField("Retreating Sound", "This is the sound that plays when retreating to a previous screen"));
            this.Fields.Add(new TagReferenceField("sound tag", 1936614433));
            this.Fields.Add(new ExplanationField("Initial Login Sound", "This is the sound that plays when advancing past the initial login screen"));
            this.Fields.Add(new TagReferenceField("sound tag", 1936614433));
            this.Fields.Add(new ExplanationField("VKBD Cursor Sound", "This is the sound that plays when cursoring in the vkeyboard"));
            this.Fields.Add(new TagReferenceField("sound tag", 1936614433));
            this.Fields.Add(new ExplanationField("VKBD Character Insertion Sound", "This is the sound that plays when selecting buttons in the vkeyboard"));
            this.Fields.Add(new TagReferenceField("sound tag", 1936614433));
            this.Fields.Add(new ExplanationField("Online Notification Sound", "This is the sound that plays when you receive an online notification"));
            this.Fields.Add(new TagReferenceField("sound tag", 1936614433));
            this.Fields.Add(new ExplanationField("Tabbed View Pane Tabbing Sound", "This is the sound that plays when tabbing thru views in a tabbed view pane (eg, o" +
                        "nline menu)"));
            this.Fields.Add(new TagReferenceField("sound tag", 1936614433));
            this.Fields.Add(new ExplanationField("Pregame Countdown Timer Sound", "This is the sound that plays as the countdown timer progresses"));
            this.Fields.Add(new TagReferenceField("sound tag", 1936614433));
            this.Fields.Add(new TagReferenceField("", 1936614433));
            this.Fields.Add(new ExplanationField("Matchmaking Advance Sound", "This is the sound that plays as matchmaking enters the final stage"));
            this.Fields.Add(new TagReferenceField("sound tag", 1936614433));
            this.Fields.Add(new TagReferenceField("", 1936614433));
            this.Fields.Add(new TagReferenceField("", 1936614433));
            this.Fields.Add(new TagReferenceField("", 1936614433));
            this.Fields.Add(new ExplanationField("Global Bitmaps", "Sprite sequences for global ui bitmaps, as follows:\n1) vkeyboard cursor\n"));
            this.Fields.Add(new TagReferenceField("global bitmaps tag", 1651078253));
            this.Fields.Add(new ExplanationField("Global Text Strings", "Global UI Text goes here"));
            this.Fields.Add(new TagReferenceField("unicode string list tag", 1970170211));
            this.Fields.Add(new ExplanationField("Screen Animations", "Animations used by screen definitions for transitions and ambient animating"));
            this.Fields.Add(new BlockField<AnimationReferenceBlock>("screen animations", 64));
            this.Fields.Add(new ExplanationField("Polygonal Shape Groups", "Define the various groups of shape-objects for use on any ui screens here"));
            this.Fields.Add(new BlockField<ShapeGroupReferenceBlock>("shape groups", 64));
            this.Fields.Add(new ExplanationField("Persistant Background Animations", "These are the animations used by elements that live in the persistant background"));
            this.Fields.Add(new BlockField<PersistentBackgroundAnimationBlock>("animations", 100));
            this.Fields.Add(new ExplanationField("List Skins", @"These define the visual appearances (skins) available for UI lists
They are expected to be entered in the following order:
0) default
1) squad lobby player list
2) settings list
3) playlist entry list
4) variants list
5) game browser list
6) online player menu
7) game setup menu
8) playlist contents display
9) profile picker
10) mp map list
11) main menu
"));
            this.Fields.Add(new BlockField<ListSkinReferenceBlock>("list item skins", 32));
            this.Fields.Add(new ExplanationField("Additional UI Strings", "These are for specific purposes as noted"));
            this.Fields.Add(new TagReferenceField("button key type strings", 1970170211));
            this.Fields.Add(new TagReferenceField("game type strings", 1970170211));
            this.Fields.Add(new TagReferenceField("", -3));
            this.Fields.Add(new ExplanationField("Skill to rank mapping table", ""));
            this.Fields.Add(new BlockField<SkillToRankMappingBlock>("skill mappings", 65535));
            this.Fields.Add(new ExplanationField("WINDOW PARAMETERS", "Various settings for different sized UI windows"));
            this.Fields.Add(new EnumField("full screen header text font", "terminal", "body text", "title", "super large font", "large body text", "split screen hud message", "full screen hud message", "english body text", "HUD number text", "subtitle font", "main menu font", "text chat font"));
            this.Fields.Add(new EnumField("large dialog header text font", "terminal", "body text", "title", "super large font", "large body text", "split screen hud message", "full screen hud message", "english body text", "HUD number text", "subtitle font", "main menu font", "text chat font"));
            this.Fields.Add(new EnumField("half dialog header text font", "terminal", "body text", "title", "super large font", "large body text", "split screen hud message", "full screen hud message", "english body text", "HUD number text", "subtitle font", "main menu font", "text chat font"));
            this.Fields.Add(new EnumField("qtr dialog header text font", "terminal", "body text", "title", "super large font", "large body text", "split screen hud message", "full screen hud message", "english body text", "HUD number text", "subtitle font", "main menu font", "text chat font"));
            this.Fields.Add(new RealArgbColorField("default text color"));
            this.Fields.Add(new Rectangle2dField("full screen header text bounds"));
            this.Fields.Add(new Rectangle2dField("full screen button key text bounds"));
            this.Fields.Add(new Rectangle2dField("large dialog header text bounds"));
            this.Fields.Add(new Rectangle2dField("large dialog button key text bounds"));
            this.Fields.Add(new Rectangle2dField("half dialog header text bounds"));
            this.Fields.Add(new Rectangle2dField("half dialog button key text bounds"));
            this.Fields.Add(new Rectangle2dField("qtr dialog header text bounds"));
            this.Fields.Add(new Rectangle2dField("qtr dialog button key text bounds"));
            this.Fields.Add(new ExplanationField("Main menu music", "Looping sound that plays while the main menu is active"));
            this.Fields.Add(new TagReferenceField("main menu music", 1819504228));
            this.Fields.Add(new LongIntegerField("music fade time:milliseconds"));
        }
        /// <summary>
        /// Gets and returns the name of the user_interface_shared_globals_definition_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "user_interface_shared_globals_definition_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the user_interface_shared_globals_definition_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "user_interface_shared_globals_definition";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the user_interface_shared_globals_definition_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the user_interface_shared_globals_definition_block tag block.
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
