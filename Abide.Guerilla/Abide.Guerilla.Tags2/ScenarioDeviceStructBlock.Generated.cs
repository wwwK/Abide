#pragma warning disable CS1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Abide.Guerilla.Tags2
{
    using Abide.Guerilla.Types;
    using Abide.HaloLibrary;
    using System;
    
    [Abide.Guerilla.Tags.FieldSetAttribute(8, 4)]
    public class ScenarioDeviceStructBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("Power Group", typeof(Int16))]
        public Int16 PowerGroup;
        [Abide.Guerilla.Tags.FieldAttribute("Position Group", typeof(Int16))]
        public Int16 PositionGroup;
        [Abide.Guerilla.Tags.FieldAttribute("Flags", typeof(Int32))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(FlagsOptions), true)]
        public Int32 Flags;
        public enum FlagsOptions
        {
            InitiallyOpen10 = 1,
            InitiallyOff00 = 2,
            CanChangeOnlyOnce = 4,
            PositionReversed = 8,
            NotUsableFromAnySide = 16,
        }
    }
}
#pragma warning restore CS1591