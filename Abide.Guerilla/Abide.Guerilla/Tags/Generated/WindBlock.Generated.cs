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
    
    [FieldSetAttribute(64, 4)]
    [TagGroupAttribute("wind", 2003398244u, 4294967293u, typeof(WindBlock))]
    public sealed class WindBlock : AbideTagBlock
    {
        [FieldAttribute("variation area#the wind direction varies inside a box defined by these angles on " +
            "either side of the direction from the weather region.", typeof(Vector2))]
        public Vector2 VariationArea;
        [FieldAttribute("local variation weight", typeof(Single))]
        public Single LocalVariationWeight;
        [FieldAttribute("local variation rate", typeof(Single))]
        public Single LocalVariationRate;
        [FieldAttribute("damping", typeof(Single))]
        public Single Damping;
        [FieldAttribute("", typeof(Byte[]))]
        [PaddingAttribute(36)]
        public Byte[] EmptyString;
        public override int Size
        {
            get
            {
                return 64;
            }
        }
        public override void Initialize()
        {
            this.VariationArea = Vector2.Zero;
            this.LocalVariationWeight = 0;
            this.LocalVariationRate = 0;
            this.Damping = 0;
            this.EmptyString = new byte[36];
        }
        public override void Read(BinaryReader reader)
        {
            this.VariationArea = reader.Read<Vector2>();
            this.LocalVariationWeight = reader.ReadSingle();
            this.LocalVariationRate = reader.ReadSingle();
            this.Damping = reader.ReadSingle();
            this.EmptyString = reader.ReadBytes(36);
        }
        public override void Write(BinaryWriter writer)
        {
        }
    }
}
#pragma warning restore CS1591