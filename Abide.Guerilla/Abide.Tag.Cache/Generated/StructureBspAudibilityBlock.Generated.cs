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
    /// Represents the generated structure_bsp_audibility_block tag block.
    /// </summary>
    public sealed class StructureBspAudibilityBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StructureBspAudibilityBlock"/> class.
        /// </summary>
        public StructureBspAudibilityBlock()
        {
            this.Fields.Add(new LongIntegerField("door portal count"));
            this.Fields.Add(new RealBoundsField("cluster distance bounds"));
            this.Fields.Add(new BlockField<DoorEncodedPasBlock>("encoded door pas", 4096));
            this.Fields.Add(new BlockField<ClusterDoorPortalEncodedPasBlock>("cluster door portal encoded pas", 2048));
            this.Fields.Add(new BlockField<AiDeafeningEncodedPasBlock>("ai deafening pas", 4088));
            this.Fields.Add(new BlockField<EncodedClusterDistancesBlock>("cluster distances", 130816));
            this.Fields.Add(new BlockField<OccluderToMachineDoorMapping>("machine door mapping", 128));
        }
        /// <summary>
        /// Gets and returns the name of the structure_bsp_audibility_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "structure_bsp_audibility_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the structure_bsp_audibility_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "structure_bsp_audibility_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the structure_bsp_audibility_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the structure_bsp_audibility_block tag block.
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
