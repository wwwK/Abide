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

namespace Abide.Guerilla.Tags
{
    using Abide.Guerilla.Types;
    using Abide.HaloLibrary;
    using System;
    using System.IO;
    
    [FieldSetAttribute(16, 4)]
    [TagGroupAttribute("sound_scenery", 1936941925u, 1868720741u, typeof(SoundSceneryBlock))]
    public sealed class SoundSceneryBlock : AbideTagBlock
    {
        [FieldAttribute("", typeof(Byte[]))]
        [PaddingAttribute(16)]
        public Byte[] EmptyString;
        public override int Size
        {
            get
            {
                return 16;
            }
        }
        public override void Initialize()
        {
            this.EmptyString = new byte[16];
        }
        public override void Read(BinaryReader reader)
        {
            this.EmptyString = reader.ReadBytes(16);
        }
        public override void Write(BinaryWriter writer)
        {
        }
    }
}
#pragma warning restore CS1591