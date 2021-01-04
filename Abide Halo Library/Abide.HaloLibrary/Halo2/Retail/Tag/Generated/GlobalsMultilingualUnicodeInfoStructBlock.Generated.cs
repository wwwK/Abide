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
    /// Represents the generated globals_multilingual_unicode_info_struct_block tag block.
    /// </summary>
    public sealed class GlobalsMultilingualUnicodeInfoStructBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalsMultilingualUnicodeInfoStructBlock"/> class.
        /// </summary>
        public GlobalsMultilingualUnicodeInfoStructBlock()
        {
            this.Fields.Add(new PadField("", 8));
            this.Fields.Add(new LongIntegerField("English string count"));
            this.Fields.Add(new LongIntegerField("English strings length"));
            this.Fields.Add(new LongIntegerField("English string index offset"));
            this.Fields.Add(new LongIntegerField("English strings offset"));
            this.Fields.Add(new PadField("", 4));
            this.Fields.Add(new PadField("", 8));
            this.Fields.Add(new LongIntegerField("Japanese string count"));
            this.Fields.Add(new LongIntegerField("Japanese strings length"));
            this.Fields.Add(new LongIntegerField("Japanese string index offset"));
            this.Fields.Add(new LongIntegerField("Japanese strings offset"));
            this.Fields.Add(new PadField("", 4));
            this.Fields.Add(new PadField("", 8));
            this.Fields.Add(new LongIntegerField("Dutch string count"));
            this.Fields.Add(new LongIntegerField("Dutch strings length"));
            this.Fields.Add(new LongIntegerField("Dutch string index offset"));
            this.Fields.Add(new LongIntegerField("Dutch strings offset"));
            this.Fields.Add(new PadField("", 4));
            this.Fields.Add(new PadField("", 8));
            this.Fields.Add(new LongIntegerField("French string count"));
            this.Fields.Add(new LongIntegerField("French strings length"));
            this.Fields.Add(new LongIntegerField("French string index offset"));
            this.Fields.Add(new LongIntegerField("French strings offset"));
            this.Fields.Add(new PadField("", 4));
            this.Fields.Add(new PadField("", 8));
            this.Fields.Add(new LongIntegerField("Spanish string count"));
            this.Fields.Add(new LongIntegerField("Spanish strings length"));
            this.Fields.Add(new LongIntegerField("Spanish string index offset"));
            this.Fields.Add(new LongIntegerField("Spanish strings offset"));
            this.Fields.Add(new PadField("", 4));
            this.Fields.Add(new PadField("", 8));
            this.Fields.Add(new LongIntegerField("Italian string count"));
            this.Fields.Add(new LongIntegerField("Italian strings length"));
            this.Fields.Add(new LongIntegerField("Italian string index offset"));
            this.Fields.Add(new LongIntegerField("Italian strings offset"));
            this.Fields.Add(new PadField("", 4));
            this.Fields.Add(new PadField("", 8));
            this.Fields.Add(new LongIntegerField("Korean string count"));
            this.Fields.Add(new LongIntegerField("Korean strings length"));
            this.Fields.Add(new LongIntegerField("Korean string index offset"));
            this.Fields.Add(new LongIntegerField("Korean strings offset"));
            this.Fields.Add(new PadField("", 4));
            this.Fields.Add(new PadField("", 8));
            this.Fields.Add(new LongIntegerField("Chinese string count"));
            this.Fields.Add(new LongIntegerField("Chinese strings length"));
            this.Fields.Add(new LongIntegerField("Chinese string index offset"));
            this.Fields.Add(new LongIntegerField("Chinese strings offset"));
            this.Fields.Add(new PadField("", 4));
            this.Fields.Add(new PadField("", 8));
            this.Fields.Add(new LongIntegerField("Portuguese string count"));
            this.Fields.Add(new LongIntegerField("Portuguese strings length"));
            this.Fields.Add(new LongIntegerField("Portuguese string index offset"));
            this.Fields.Add(new LongIntegerField("Portuguese strings offset"));
            this.Fields.Add(new PadField("", 4));
        }
        /// <summary>
        /// Gets and returns the name of the globals_multilingual_unicode_info_struct_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "globals_multilingual_unicode_info_struct_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the globals_multilingual_unicode_info_struct_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "globals_multilingual_unicode_info_struct_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the globals_multilingual_unicode_info_struct_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the globals_multilingual_unicode_info_struct_block tag block.
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
