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
    using System;
    using Abide.HaloLibrary;
    using Abide.Tag;
    
    /// <summary>
    /// Represents the generated additional_node_data_block tag block.
    /// </summary>
    public sealed class AdditionalNodeDataBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalNodeDataBlock"/> class.
        /// </summary>
        public AdditionalNodeDataBlock()
        {
            this.Fields.Add(new StringIdField("node name^"));
            this.Fields.Add(new QuaternionField("default rotation*"));
            this.Fields.Add(new RealPoint3dField("default translation*"));
            this.Fields.Add(new RealField("default scale*"));
            this.Fields.Add(new RealPoint3dField("min bounds"));
            this.Fields.Add(new RealPoint3dField("max bounds"));
        }
        /// <summary>
        /// Gets and returns the name of the additional_node_data_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "additional_node_data_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the additional_node_data_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "additional_node_data_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the additional_node_data_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 255;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the additional_node_data_block tag block.
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
