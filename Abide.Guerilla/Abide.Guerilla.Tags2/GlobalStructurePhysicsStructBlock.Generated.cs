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
    
    [Abide.Guerilla.Tags.FieldSetAttribute(80, 4)]
    public class GlobalStructurePhysicsStructBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("*mopp Code", typeof(Byte[]))]
        public Byte[] EmptyString;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(4)]
        public Byte[] EmptyString1;
        [Abide.Guerilla.Tags.FieldAttribute("*mopp Bounds Min", typeof(Vector3))]
        public Vector3 EmptyString2;
        [Abide.Guerilla.Tags.FieldAttribute("*mopp Bounds Max", typeof(Vector3))]
        public Vector3 EmptyString3;
        [Abide.Guerilla.Tags.FieldAttribute("*Breakable Surfaces mopp Code", typeof(Byte[]))]
        public Byte[] EmptyString4;
        [Abide.Guerilla.Tags.FieldAttribute("Breakable Surface Key Table", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("Breakable Surface Key Table Block", 8192, typeof(BreakableSurfaceKeyTableBlock))]
        public TagBlock BreakableSurfaceKeyTable;
    }
}
#pragma warning restore CS1591