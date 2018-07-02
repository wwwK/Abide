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
    /// Represents the generated unit_boost_struct_block tag block.
    /// </summary>
    public sealed class UnitBoostStructBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnitBoostStructBlock"/> class.
        /// </summary>
        public UnitBoostStructBlock()
        {
            this.Fields.Add(new RealField("boost peak power"));
            this.Fields.Add(new RealField("boost rise power"));
            this.Fields.Add(new RealField("boost peak time"));
            this.Fields.Add(new RealField("boost fall power"));
            this.Fields.Add(new RealField("dead time"));
        }
        /// <summary>
        /// Gets and returns the name of the unit_boost_struct_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "unit_boost_struct_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the unit_boost_struct_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "unit_boost_struct";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the unit_boost_struct_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the unit_boost_struct_block tag block.
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
