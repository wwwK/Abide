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
    
    [Abide.Guerilla.Tags.FieldSetAttribute(32, 4)]
    public class SoundEncodedDialogueSectionBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("encoded data", typeof(Byte[]))]
        public Byte[] EncodedData;
        [Abide.Guerilla.Tags.FieldAttribute("sound dialogue info", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("Sound Permutation Dialogue Info Block", 288, typeof(SoundPermutationDialogueInfoBlock))]
        public TagBlock SoundDialogueInfo;
    }
}
#pragma warning restore CS1591