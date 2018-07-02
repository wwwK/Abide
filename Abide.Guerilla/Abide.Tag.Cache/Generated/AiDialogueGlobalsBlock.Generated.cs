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
    /// Represents the generated ai_dialogue_globals_block tag block.
    /// </summary>
    public sealed class AiDialogueGlobalsBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AiDialogueGlobalsBlock"/> class.
        /// </summary>
        public AiDialogueGlobalsBlock()
        {
            this.Fields.Add(new BlockField<VocalizationDefinitionsBlock0>("vocalizations", 500));
            this.Fields.Add(new BlockField<VocalizationPatternsBlock>("patterns", 1000));
            this.Fields.Add(new PadField("", 12));
            this.Fields.Add(new BlockField<DialogueDataBlock>("dialogue data", 200));
            this.Fields.Add(new BlockField<InvoluntaryDataBlock>("involuntary data", 100));
        }
        /// <summary>
        /// Gets and returns the name of the ai_dialogue_globals_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "ai_dialogue_globals_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the ai_dialogue_globals_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "ai_dialogue_globals";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the ai_dialogue_globals_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the ai_dialogue_globals_block tag block.
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
