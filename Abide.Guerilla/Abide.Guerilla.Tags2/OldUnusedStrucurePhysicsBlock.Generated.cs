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
    
    [Abide.Guerilla.Tags.FieldSetAttribute(60, 4)]
    public class OldUnusedStrucurePhysicsBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("*mopp code", typeof(Byte[]))]
        public Byte[] EmptyString;
        [Abide.Guerilla.Tags.FieldAttribute("*Evironment Object Identifiers", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("Old Unused Object Identifiers Block", 2048, typeof(OldUnusedObjectIdentifiersBlock))]
        public TagBlock EmptyString1;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(4)]
        public Byte[] EmptyString2;
        [Abide.Guerilla.Tags.FieldAttribute("mopp Bounds Min*", typeof(Vector3))]
        public Vector3 MoppBoundsMin;
        [Abide.Guerilla.Tags.FieldAttribute("mopp Bounds Max*", typeof(Vector3))]
        public Vector3 MoppBoundsMax;
    }
}
#pragma warning restore CS1591