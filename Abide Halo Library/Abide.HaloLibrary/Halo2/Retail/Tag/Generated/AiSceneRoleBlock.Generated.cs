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
    /// Represents the generated ai_scene_role_block tag block.
    /// </summary>
    internal sealed class AiSceneRoleBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AiSceneRoleBlock"/> class.
        /// </summary>
        public AiSceneRoleBlock()
        {
            this.Fields.Add(new StringIdField("name^"));
            this.Fields.Add(new EnumField("group", "group 1", "group 2", "group 3"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new BlockField<AiSceneRoleVariantsBlock>("role variants", 10));
        }
        /// <summary>
        /// Gets and returns the name of the ai_scene_role_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "ai_scene_role_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the ai_scene_role_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "ai_scene_role_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the ai_scene_role_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 10;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the ai_scene_role_block tag block.
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
