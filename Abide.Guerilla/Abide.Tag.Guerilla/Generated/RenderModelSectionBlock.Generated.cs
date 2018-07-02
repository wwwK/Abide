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
    /// Represents the generated render_model_section_block tag block.
    /// </summary>
    public sealed class RenderModelSectionBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RenderModelSectionBlock"/> class.
        /// </summary>
        public RenderModelSectionBlock()
        {
            this.Fields.Add(new EnumField("global_geometry_classification_enum_definition", "Worldspace", "Rigid", "Rigid Boned", "Skinned", "Unsupported (Reimport)"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new StructField<GlobalGeometrySectionInfoStructBlock>("section info*"));
            this.Fields.Add(new ShortBlockIndexField("rigid node*"));
            this.Fields.Add(new WordFlagsField("flags", "geometry postprocessed"));
            this.Fields.Add(new BlockField<RenderModelSectionDataBlock>("section data*", 1));
            this.Fields.Add(new StructField<GlobalGeometryBlockInfoStructBlock>("geometry block info*"));
        }
        /// <summary>
        /// Gets and returns the name of the render_model_section_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "render_model_section_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the render_model_section_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "render_model_section_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the render_model_section_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 255;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the render_model_section_block tag block.
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
