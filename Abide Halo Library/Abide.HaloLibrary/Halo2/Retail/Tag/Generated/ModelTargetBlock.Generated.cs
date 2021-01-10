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
    /// Represents the generated model_target_block tag block.
    /// </summary>
    internal sealed class ModelTargetBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelTargetBlock"/> class.
        /// </summary>
        public ModelTargetBlock()
        {
            this.Fields.Add(new StringIdField("marker name^#multiple markers become multiple spheres of the same radius"));
            this.Fields.Add(new RealField("size#sphere radius"));
            this.Fields.Add(new AngleField("cone angle#the target is only visible when viewed within this angle of the marker" +
                        "\'s x axis"));
            this.Fields.Add(new ShortBlockIndexField("damage section#the target is associated with this damage section"));
            this.Fields.Add(new ShortBlockIndexField("variant#the target will only appear with this variant"));
            this.Fields.Add(new RealFractionField("targeting relevance#higher relevances turn into stronger magnetisms"));
            this.Fields.Add(new StructField<ModelTargetLockOnDataStructBlock>("lock-on data"));
        }
        /// <summary>
        /// Gets and returns the name of the model_target_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "model_target_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the model_target_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "model_target_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the model_target_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 32;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the model_target_block tag block.
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
