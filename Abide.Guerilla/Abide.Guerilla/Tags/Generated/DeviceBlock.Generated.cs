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
    
    [FieldSetAttribute(152, 4)]
    [TagGroupAttribute("device", 1684371049u, 1868720741u, typeof(DeviceBlock))]
    public sealed class DeviceBlock : AbideTagBlock
    {
        [FieldAttribute("flags", typeof(FlagsOptions))]
        [OptionsAttribute(typeof(FlagsOptions), true)]
        public FlagsOptions Flags;
        [FieldAttribute("power transition time:seconds", typeof(Single))]
        public Single PowerTransitionTime;
        [FieldAttribute("power acceleration time:seconds", typeof(Single))]
        public Single PowerAccelerationTime;
        [FieldAttribute("position transition time:seconds", typeof(Single))]
        public Single PositionTransitionTime;
        [FieldAttribute("position acceleration time:seconds", typeof(Single))]
        public Single PositionAccelerationTime;
        [FieldAttribute("depowered position transition time:seconds", typeof(Single))]
        public Single DepoweredPositionTransitionTime;
        [FieldAttribute("depowered position acceleration time:seconds", typeof(Single))]
        public Single DepoweredPositionAccelerationTime;
        [FieldAttribute("lightmap flags", typeof(LightmapFlagsOptions))]
        [OptionsAttribute(typeof(LightmapFlagsOptions), true)]
        public LightmapFlagsOptions LightmapFlags;
        [FieldAttribute("", typeof(Byte[]))]
        [PaddingAttribute(2)]
        public Byte[] EmptyString;
        [FieldAttribute("open (up)", typeof(TagReference))]
        public TagReference OpenUp;
        [FieldAttribute("close (down)", typeof(TagReference))]
        public TagReference CloseDown;
        [FieldAttribute("opened", typeof(TagReference))]
        public TagReference Opened;
        [FieldAttribute("closed", typeof(TagReference))]
        public TagReference Closed;
        [FieldAttribute("depowered", typeof(TagReference))]
        public TagReference Depowered;
        [FieldAttribute("repowered", typeof(TagReference))]
        public TagReference Repowered;
        [FieldAttribute("delay time:seconds", typeof(Single))]
        public Single DelayTime;
        [FieldAttribute("delay effect", typeof(TagReference))]
        public TagReference DelayEffect;
        [FieldAttribute("automatic activation radius:world units", typeof(Single))]
        public Single AutomaticActivationRadius;
        public override int Size
        {
            get
            {
                return 152;
            }
        }
        public override void Initialize()
        {
            this.Flags = ((FlagsOptions)(0));
            this.PowerTransitionTime = 0;
            this.PowerAccelerationTime = 0;
            this.PositionTransitionTime = 0;
            this.PositionAccelerationTime = 0;
            this.DepoweredPositionTransitionTime = 0;
            this.DepoweredPositionAccelerationTime = 0;
            this.LightmapFlags = ((LightmapFlagsOptions)(0));
            this.EmptyString = new byte[2];
            this.OpenUp = TagReference.Null;
            this.CloseDown = TagReference.Null;
            this.Opened = TagReference.Null;
            this.Closed = TagReference.Null;
            this.Depowered = TagReference.Null;
            this.Repowered = TagReference.Null;
            this.DelayTime = 0;
            this.DelayEffect = TagReference.Null;
            this.AutomaticActivationRadius = 0;
        }
        public override void Read(BinaryReader reader)
        {
            this.Flags = ((FlagsOptions)(reader.ReadInt32()));
            this.PowerTransitionTime = reader.ReadSingle();
            this.PowerAccelerationTime = reader.ReadSingle();
            this.PositionTransitionTime = reader.ReadSingle();
            this.PositionAccelerationTime = reader.ReadSingle();
            this.DepoweredPositionTransitionTime = reader.ReadSingle();
            this.DepoweredPositionAccelerationTime = reader.ReadSingle();
            this.LightmapFlags = ((LightmapFlagsOptions)(reader.ReadInt16()));
            this.EmptyString = reader.ReadBytes(2);
            this.OpenUp = reader.Read<TagReference>();
            this.CloseDown = reader.Read<TagReference>();
            this.Opened = reader.Read<TagReference>();
            this.Closed = reader.Read<TagReference>();
            this.Depowered = reader.Read<TagReference>();
            this.Repowered = reader.Read<TagReference>();
            this.DelayTime = reader.ReadSingle();
            this.DelayEffect = reader.Read<TagReference>();
            this.AutomaticActivationRadius = reader.ReadSingle();
        }
        public override void Write(BinaryWriter writer)
        {
        }
        public enum FlagsOptions : Int32
        {
            PositionLoops = 1,
            Unused = 2,
            AllowInterpolation = 4,
        }
        public enum LightmapFlagsOptions : Int16
        {
            DontUseInLightmap = 1,
            DontUseInLightprobe = 2,
        }
    }
}
#pragma warning restore CS1591