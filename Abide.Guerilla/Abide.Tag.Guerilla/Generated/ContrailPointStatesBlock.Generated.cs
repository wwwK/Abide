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
    /// Represents the generated contrail_point_states_block tag block.
    /// </summary>
    public sealed class ContrailPointStatesBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContrailPointStatesBlock"/> class.
        /// </summary>
        public ContrailPointStatesBlock()
        {
            this.Fields.Add(new ExplanationField("state timing", ""));
            this.Fields.Add(new RealBoundsField("duration:seconds#the time a point spends in this state"));
            this.Fields.Add(new RealBoundsField("transition duration:seconds#the time a point takes to transition to the next stat" +
                        "e"));
            this.Fields.Add(new ExplanationField("point variables", ""));
            this.Fields.Add(new TagReferenceField("physics", "pphy"));
            this.Fields.Add(new RealField("width:world units#contrail width at this point"));
            this.Fields.Add(new RealArgbColorField("color lower bound#contrail color at this point"));
            this.Fields.Add(new RealArgbColorField("color upper bound#contrail color at this point"));
            this.Fields.Add(new LongFlagsField("scale flags#these flags determine which fields are scaled by the contrail density" +
                        "", "duration", "duration delta", "transition duration", "transition duration delta", "width", "color"));
        }
        /// <summary>
        /// Gets and returns the name of the contrail_point_states_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "contrail_point_states_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the contrail_point_states_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "contrail_point_states_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the contrail_point_states_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 16;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the contrail_point_states_block tag block.
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
