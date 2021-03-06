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
    /// Represents the generated global_geometry_section_info_struct_block tag block.
    /// </summary>
    public sealed class GlobalGeometrySectionInfoStructBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalGeometrySectionInfoStructBlock"/> class.
        /// </summary>
        public GlobalGeometrySectionInfoStructBlock()
        {
            this.Fields.Add(new ExplanationField("SECTION INFO", ""));
            this.Fields.Add(new ShortIntegerField("Total Vertex Count*"));
            this.Fields.Add(new ShortIntegerField("Total Triangle Count*"));
            this.Fields.Add(new ShortIntegerField("Total Part Count*"));
            this.Fields.Add(new ShortIntegerField("Shadow-Casting Triangle Count*"));
            this.Fields.Add(new ShortIntegerField("Shadow-Casting Part Count*"));
            this.Fields.Add(new ShortIntegerField("Opaque Point Count*"));
            this.Fields.Add(new ShortIntegerField("Opaque Vertex Count*"));
            this.Fields.Add(new ShortIntegerField("Opaque Part Count*"));
            this.Fields.Add(new CharIntegerField("Opaque Max Nodes/Vertex*"));
            this.Fields.Add(new CharIntegerField("Transparent Max Nodes/Vertex*"));
            this.Fields.Add(new ShortIntegerField("Shadow-Casting Rigid Triangle Count*"));
            this.Fields.Add(new EnumField("Geometry Classification*", "Worldspace", "Rigid", "Rigid Boned", "Skinned", "Unsupported (Reimport)"));
            this.Fields.Add(new WordFlagsField("Geometry Compression Flags*", "Compressed Position", "Compressed Texcoord", "Compressed Secondary Texcoord"));
            this.Fields.Add(new BlockField<GlobalGeometryCompressionInfoBlock>("", 1));
            this.Fields.Add(new CharIntegerField("Hardware Node Count*"));
            this.Fields.Add(new CharIntegerField("Node Map Size*"));
            this.Fields.Add(new ShortIntegerField("Software Plane Count*"));
            this.Fields.Add(new ShortIntegerField("total subpart_cont*"));
            this.Fields.Add(new WordFlagsField("Section Lighting Flags*", "has lm texcoords", "has lm inc. rad.", "Has lm Colors", "has lm prt"));
        }
        /// <summary>
        /// Gets and returns the name of the global_geometry_section_info_struct_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "global_geometry_section_info_struct_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the global_geometry_section_info_struct_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "global_geometry_section_info_struct";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the global_geometry_section_info_struct_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the global_geometry_section_info_struct_block tag block.
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
