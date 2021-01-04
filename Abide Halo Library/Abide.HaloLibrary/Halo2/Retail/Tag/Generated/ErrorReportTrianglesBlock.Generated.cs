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
    /// Represents the generated error_report_triangles_block tag block.
    /// </summary>
    public sealed class ErrorReportTrianglesBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorReportTrianglesBlock"/> class.
        /// </summary>
        public ErrorReportTrianglesBlock()
        {
            this.Fields.Add(new RealPoint3dField("Position*"));
            this.Fields.Add(new CharIntegerField("Node Index*"));
            this.Fields.Add(new CharIntegerField("Node Index*"));
            this.Fields.Add(new CharIntegerField("Node Index*"));
            this.Fields.Add(new CharIntegerField("Node Index*"));
            this.Fields.Add(new RealField("Node Weight*"));
            this.Fields.Add(new RealField("Node Weight*"));
            this.Fields.Add(new RealField("Node Weight*"));
            this.Fields.Add(new RealField("Node Weight*"));
            this.Fields.Add(new RealPoint3dField("Position*"));
            this.Fields.Add(new CharIntegerField("Node Index*"));
            this.Fields.Add(new CharIntegerField("Node Index*"));
            this.Fields.Add(new CharIntegerField("Node Index*"));
            this.Fields.Add(new CharIntegerField("Node Index*"));
            this.Fields.Add(new RealField("Node Weight*"));
            this.Fields.Add(new RealField("Node Weight*"));
            this.Fields.Add(new RealField("Node Weight*"));
            this.Fields.Add(new RealField("Node Weight*"));
            this.Fields.Add(new RealPoint3dField("Position*"));
            this.Fields.Add(new CharIntegerField("Node Index*"));
            this.Fields.Add(new CharIntegerField("Node Index*"));
            this.Fields.Add(new CharIntegerField("Node Index*"));
            this.Fields.Add(new CharIntegerField("Node Index*"));
            this.Fields.Add(new RealField("Node Weight*"));
            this.Fields.Add(new RealField("Node Weight*"));
            this.Fields.Add(new RealField("Node Weight*"));
            this.Fields.Add(new RealField("Node Weight*"));
            this.Fields.Add(new RealArgbColorField("Color*"));
        }
        /// <summary>
        /// Gets and returns the name of the error_report_triangles_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "error_report_triangles_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the error_report_triangles_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "error report triangle";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the error_report_triangles_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1024;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the error_report_triangles_block tag block.
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
