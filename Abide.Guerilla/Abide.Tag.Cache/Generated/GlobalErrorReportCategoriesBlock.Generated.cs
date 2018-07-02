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
    /// Represents the generated global_error_report_categories_block tag block.
    /// </summary>
    public sealed class GlobalErrorReportCategoriesBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalErrorReportCategoriesBlock"/> class.
        /// </summary>
        public GlobalErrorReportCategoriesBlock()
        {
            this.Fields.Add(new LongStringField("Name*^"));
            this.Fields.Add(new EnumField("Report Type*", "Silent", "Comment", "Warning", "Error"));
            this.Fields.Add(new WordFlagsField("Flags*", "Rendered", "Tangent Space", "Noncritical", "Lightmap Light", "Report key is valid."));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new PadField("", 404));
            this.Fields.Add(new BlockField<ErrorReportsBlock>("Reports*", 1024));
        }
        /// <summary>
        /// Gets and returns the name of the global_error_report_categories_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "global_error_report_categories_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the global_error_report_categories_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "error report category";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the global_error_report_categories_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 64;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the global_error_report_categories_block tag block.
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
