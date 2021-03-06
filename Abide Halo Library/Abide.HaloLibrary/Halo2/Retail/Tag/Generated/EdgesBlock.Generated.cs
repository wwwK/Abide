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
    /// Represents the generated edges_block tag block.
    /// </summary>
    internal sealed class EdgesBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdgesBlock"/> class.
        /// </summary>
        public EdgesBlock()
        {
            this.Fields.Add(new ShortIntegerField("Start Vertex*"));
            this.Fields.Add(new ShortIntegerField("End Vertex*"));
            this.Fields.Add(new ShortIntegerField("Forward Edge*"));
            this.Fields.Add(new ShortIntegerField("Reverse Edge*"));
            this.Fields.Add(new ShortIntegerField("Left Surface*"));
            this.Fields.Add(new ShortIntegerField("Right Surface*"));
        }
        /// <summary>
        /// Gets and returns the name of the edges_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "edges_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the edges_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "edges_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the edges_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 262144;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the edges_block tag block.
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
