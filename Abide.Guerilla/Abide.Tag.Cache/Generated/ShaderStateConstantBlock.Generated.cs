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
    /// Represents the generated shader_state_constant_block tag block.
    /// </summary>
    public sealed class ShaderStateConstantBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShaderStateConstantBlock"/> class.
        /// </summary>
        public ShaderStateConstantBlock()
        {
            this.Fields.Add(new StringIdField("source parameter"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new EnumField("constant^", "constant blend color", "constant blend alpha (value)", "alpha-test ref (value)", "depth bias slope scale (value)", "depth bias (value)", "line width (value)", "fog color"));
        }
        /// <summary>
        /// Gets and returns the name of the shader_state_constant_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "shader_state_constant_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the shader_state_constant_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "render state constant";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the shader_state_constant_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 7;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the shader_state_constant_block tag block.
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
