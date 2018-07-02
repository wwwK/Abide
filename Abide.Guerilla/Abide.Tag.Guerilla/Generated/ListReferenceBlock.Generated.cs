//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Abide.Tag.Guerilla.Generated
{
    using Abide.Tag;
    
    /// <summary>
    /// Represents the generated list_reference_block tag block.
    /// </summary>
    public sealed class ListReferenceBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListReferenceBlock"/> class.
        /// </summary>
        public ListReferenceBlock()
        {
            this.Fields.Add(new LongFlagsField("flags", "list wraps", "interactive"));
            this.Fields.Add(new EnumField("skin index", "default", "squad lobby player list", "settings list", "playlist entry list", "variants", "game browser", "online player menu", "game setup menu", "playlist contents display", "player profile picker", "mp map selection", "main menu list", "color picker", "profile picker", "y menu recent list", "pcr team stats", "pcr player stats", "pcr kill stats", "pcr pvp stats", "pcr medal stats", "matchmaking progress", "default 5", "default 6", "advanced settings list", "live game browser", "default wide", "unused26", "unused27", "unused28", "unused29", "unused30", "unused31"));
            this.Fields.Add(new ShortIntegerField("num. visible items"));
            this.Fields.Add(new Point2dField("bottom left"));
            this.Fields.Add(new EnumField("animation index", "NONE", "00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63"));
            this.Fields.Add(new ShortIntegerField("intro animation delay milliseconds"));
            this.Fields.Add(new ExplanationField("UNUSED", "This is unused"));
            this.Fields.Add(new BlockField<STextValuePairReferenceBlockUNUSED>("UNUSED", 100));
        }
        /// <summary>
        /// Gets and returns the name of the list_reference_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "list_reference_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the list_reference_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "list_reference_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the list_reference_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the list_reference_block tag block.
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
