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
    
    [Abide.Guerilla.Tags.FieldSetAttribute(24, 4)]
    public class AnimationTransitionBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("full name^#name of the mode & state of the source", typeof(StringId))]
        public StringId FullName;
        [Abide.Guerilla.Tags.FieldAttribute("state info", typeof(AnimationTransitionStateStructBlock))]
        public AnimationTransitionStateStructBlock StateInfo;
        [Abide.Guerilla.Tags.FieldAttribute("destinations|AABBCC", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("Animation Transition Destination Block", 32, typeof(AnimationTransitionDestinationBlock))]
        public TagBlock Destinationsaabbcc;
    }
}
#pragma warning restore CS1591