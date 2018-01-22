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
    
    [FieldSetAttribute(224, 4)]
    [TagGroupAttribute("creature", 1668441441u, 1868720741u, typeof(CreatureBlock))]
    public sealed class CreatureBlock : AbideTagBlock
    {
        [FieldAttribute("flags", typeof(FlagsOptions))]
        [OptionsAttribute(typeof(FlagsOptions), true)]
        public FlagsOptions Flags;
        [FieldAttribute("default team", typeof(DefaultTeamOptions))]
        [OptionsAttribute(typeof(DefaultTeamOptions), false)]
        public DefaultTeamOptions DefaultTeam;
        [FieldAttribute("motion sensor blip size", typeof(MotionSensorBlipSizeOptions))]
        [OptionsAttribute(typeof(MotionSensorBlipSizeOptions), false)]
        public MotionSensorBlipSizeOptions MotionSensorBlipSize;
        [FieldAttribute("turning velocity maximum:degrees per second", typeof(Single))]
        public Single TurningVelocityMaximum;
        [FieldAttribute("turning acceleration maximum:degrees per second squared", typeof(Single))]
        public Single TurningAccelerationMaximum;
        [FieldAttribute("casual turning modifier:[0,1]", typeof(Single))]
        public Single CasualTurningModifier;
        [FieldAttribute("autoaim width:world units", typeof(Single))]
        public Single AutoaimWidth;
        [FieldAttribute("physics", typeof(CharacterPhysicsStructBlock))]
        public CharacterPhysicsStructBlock Physics;
        [FieldAttribute("impact damage", typeof(TagReference))]
        public TagReference ImpactDamage;
        [FieldAttribute("impact shield damage#if not specified, uses \'impact damage\'", typeof(TagReference))]
        public TagReference ImpactShieldDamage;
        public override int Size
        {
            get
            {
                return 224;
            }
        }
        public override void Initialize()
        {
            this.Flags = ((FlagsOptions)(0));
            this.DefaultTeam = ((DefaultTeamOptions)(0));
            this.MotionSensorBlipSize = ((MotionSensorBlipSizeOptions)(0));
            this.TurningVelocityMaximum = 0;
            this.TurningAccelerationMaximum = 0;
            this.CasualTurningModifier = 0;
            this.AutoaimWidth = 0;
            this.Physics = new CharacterPhysicsStructBlock();
            this.ImpactDamage = TagReference.Null;
            this.ImpactShieldDamage = TagReference.Null;
        }
        public override void Read(BinaryReader reader)
        {
            this.Flags = ((FlagsOptions)(reader.ReadInt32()));
            this.DefaultTeam = ((DefaultTeamOptions)(reader.ReadInt16()));
            this.MotionSensorBlipSize = ((MotionSensorBlipSizeOptions)(reader.ReadInt16()));
            this.TurningVelocityMaximum = reader.ReadSingle();
            this.TurningAccelerationMaximum = reader.ReadSingle();
            this.CasualTurningModifier = reader.ReadSingle();
            this.AutoaimWidth = reader.ReadSingle();
            this.Physics = reader.ReadDataStructure<CharacterPhysicsStructBlock>();
            this.ImpactDamage = reader.Read<TagReference>();
            this.ImpactShieldDamage = reader.Read<TagReference>();
        }
        public override void Write(BinaryWriter writer)
        {
        }
        [FieldSetAttribute(160, 4)]
        public sealed class CharacterPhysicsStructBlock : AbideTagBlock
        {
            private TagBlockList<SpheresBlock> deadSphereShapesList = new TagBlockList<SpheresBlock>(1024);
            private TagBlockList<PillsBlock> pillShapesList = new TagBlockList<PillsBlock>(1024);
            [FieldAttribute("flags", typeof(FlagsOptions))]
            [OptionsAttribute(typeof(FlagsOptions), true)]
            public FlagsOptions Flags;
            [FieldAttribute("height standing", typeof(Single))]
            public Single HeightStanding;
            [FieldAttribute("height crouching", typeof(Single))]
            public Single HeightCrouching;
            [FieldAttribute("radius", typeof(Single))]
            public Single Radius;
            [FieldAttribute("mass", typeof(Single))]
            public Single Mass;
            [FieldAttribute("living material name#collision material used when character is alive", typeof(StringId))]
            public StringId LivingMaterialName;
            [FieldAttribute("dead material name#collision material used when character is dead", typeof(StringId))]
            public StringId DeadMaterialName;
            [FieldAttribute("", typeof(Byte[]))]
            [PaddingAttribute(4)]
            public Byte[] EmptyString;
            [FieldAttribute("dead sphere shapes", typeof(TagBlock))]
            [BlockAttribute("spheres_block", 1024, typeof(SpheresBlock))]
            public TagBlock DeadSphereShapes;
            [FieldAttribute("pill shapes", typeof(TagBlock))]
            [BlockAttribute("pills_block", 1024, typeof(PillsBlock))]
            public TagBlock PillShapes;
            [FieldAttribute("sphere shapes", typeof(TagBlock))]
            [BlockAttribute("spheres_block", 1024, typeof(SpheresBlock))]
            public TagBlock SphereShapes;
            [FieldAttribute("ground physics", typeof(CharacterPhysicsGroundStructBlock))]
            public CharacterPhysicsGroundStructBlock GroundPhysics;
            [FieldAttribute("flying physics", typeof(CharacterPhysicsFlyingStructBlock))]
            public CharacterPhysicsFlyingStructBlock FlyingPhysics;
            [FieldAttribute("dead physics", typeof(CharacterPhysicsDeadStructBlock))]
            public CharacterPhysicsDeadStructBlock DeadPhysics;
            [FieldAttribute("sentinel physics", typeof(CharacterPhysicsSentinelStructBlock))]
            public CharacterPhysicsSentinelStructBlock SentinelPhysics;
            public TagBlockList<SpheresBlock> DeadSphereShapesList
            {
                get
                {
                    return this.deadSphereShapesList;
                }
            }
            public TagBlockList<PillsBlock> PillShapesList
            {
                get
                {
                    return this.pillShapesList;
                }
            }
            public override int Size
            {
                get
                {
                    return 160;
                }
            }
            public override void Initialize()
            {
                this.deadSphereShapesList.Clear();
                this.pillShapesList.Clear();
                this.Flags = ((FlagsOptions)(0));
                this.HeightStanding = 0;
                this.HeightCrouching = 0;
                this.Radius = 0;
                this.Mass = 0;
                this.LivingMaterialName = StringId.Zero;
                this.DeadMaterialName = StringId.Zero;
                this.EmptyString = new byte[4];
                this.DeadSphereShapes = TagBlock.Zero;
                this.PillShapes = TagBlock.Zero;
                this.SphereShapes = TagBlock.Zero;
                this.GroundPhysics = new CharacterPhysicsGroundStructBlock();
                this.FlyingPhysics = new CharacterPhysicsFlyingStructBlock();
                this.DeadPhysics = new CharacterPhysicsDeadStructBlock();
                this.SentinelPhysics = new CharacterPhysicsSentinelStructBlock();
            }
            public override void Read(BinaryReader reader)
            {
                this.Flags = ((FlagsOptions)(reader.ReadInt32()));
                this.HeightStanding = reader.ReadSingle();
                this.HeightCrouching = reader.ReadSingle();
                this.Radius = reader.ReadSingle();
                this.Mass = reader.ReadSingle();
                this.LivingMaterialName = reader.ReadInt32();
                this.DeadMaterialName = reader.ReadInt32();
                this.EmptyString = reader.ReadBytes(4);
                this.DeadSphereShapes = reader.ReadInt64();
                this.deadSphereShapesList.Read(reader, this.DeadSphereShapes);
                this.PillShapes = reader.ReadInt64();
                this.pillShapesList.Read(reader, this.PillShapes);
                this.SphereShapes = reader.ReadInt64();
                this.pillShapesList.Read(reader, this.SphereShapes);
                this.GroundPhysics = reader.ReadDataStructure<CharacterPhysicsGroundStructBlock>();
                this.FlyingPhysics = reader.ReadDataStructure<CharacterPhysicsFlyingStructBlock>();
                this.DeadPhysics = reader.ReadDataStructure<CharacterPhysicsDeadStructBlock>();
                this.SentinelPhysics = reader.ReadDataStructure<CharacterPhysicsSentinelStructBlock>();
            }
            public override void Write(BinaryWriter writer)
            {
            }
            [FieldSetAttribute(128, 16)]
            public sealed class SpheresBlock : AbideTagBlock
            {
                [FieldAttribute("name^*", typeof(StringId))]
                public StringId Name;
                [FieldAttribute("material*", typeof(Int16))]
                public Int16 Material;
                [FieldAttribute("flags", typeof(FlagsOptions))]
                [OptionsAttribute(typeof(FlagsOptions), true)]
                public FlagsOptions Flags;
                [FieldAttribute("relative mass scale", typeof(Single))]
                public Single RelativeMassScale;
                [FieldAttribute("friction", typeof(Single))]
                public Single Friction;
                [FieldAttribute("restitution", typeof(Single))]
                public Single Restitution;
                [FieldAttribute("volume *", typeof(Single))]
                public Single Volume;
                [FieldAttribute("mass*", typeof(Single))]
                public Single Mass;
                [FieldAttribute("", typeof(Byte[]))]
                [PaddingAttribute(2)]
                public Byte[] EmptyString;
                [FieldAttribute("phantom*", typeof(Int16))]
                public Int16 Phantom;
                [FieldAttribute("", typeof(Byte[]))]
                [PaddingAttribute(4)]
                public Byte[] EmptyString1;
                [FieldAttribute("size*", typeof(Int16))]
                public Int16 Size1;
                [FieldAttribute("count*", typeof(Int16))]
                public Int16 Count;
                [FieldAttribute("", typeof(Byte[]))]
                [PaddingAttribute(4)]
                public Byte[] EmptyString2;
                [FieldAttribute("radius*", typeof(Single))]
                public Single Radius;
                [FieldAttribute("", typeof(Byte[]))]
                [PaddingAttribute(4)]
                public Byte[] EmptyString3;
                [FieldAttribute("size*", typeof(Int16))]
                public Int16 Size2;
                [FieldAttribute("count*", typeof(Int16))]
                public Int16 Count1;
                [FieldAttribute("", typeof(Byte[]))]
                [PaddingAttribute(4)]
                public Byte[] EmptyString4;
                [FieldAttribute("", typeof(Byte[]))]
                [PaddingAttribute(4)]
                public Byte[] EmptyString5;
                [FieldAttribute("rotation i*", typeof(Vector3))]
                public Vector3 RotationI;
                [FieldAttribute("", typeof(Byte[]))]
                [PaddingAttribute(4)]
                public Byte[] EmptyString6;
                [FieldAttribute("rotation j*", typeof(Vector3))]
                public Vector3 RotationJ;
                [FieldAttribute("", typeof(Byte[]))]
                [PaddingAttribute(4)]
                public Byte[] EmptyString7;
                [FieldAttribute("rotation k*", typeof(Vector3))]
                public Vector3 RotationK;
                [FieldAttribute("", typeof(Byte[]))]
                [PaddingAttribute(4)]
                public Byte[] EmptyString8;
                [FieldAttribute("translation*", typeof(Vector3))]
                public Vector3 Translation;
                [FieldAttribute("", typeof(Byte[]))]
                [PaddingAttribute(4)]
                public Byte[] EmptyString9;
                public override int Size
                {
                    get
                    {
                        return 128;
                    }
                }
                public override void Initialize()
                {
                    this.Name = StringId.Zero;
                    this.Material = 0;
                    this.Flags = ((FlagsOptions)(0));
                    this.RelativeMassScale = 0;
                    this.Friction = 0;
                    this.Restitution = 0;
                    this.Volume = 0;
                    this.Mass = 0;
                    this.EmptyString = new byte[2];
                    this.Phantom = 0;
                    this.EmptyString1 = new byte[4];
                    this.Size1 = 0;
                    this.Count = 0;
                    this.EmptyString2 = new byte[4];
                    this.Radius = 0;
                    this.EmptyString3 = new byte[4];
                    this.Size2 = 0;
                    this.Count1 = 0;
                    this.EmptyString4 = new byte[4];
                    this.EmptyString5 = new byte[4];
                    this.RotationI = Vector3.Zero;
                    this.EmptyString6 = new byte[4];
                    this.RotationJ = Vector3.Zero;
                    this.EmptyString7 = new byte[4];
                    this.RotationK = Vector3.Zero;
                    this.EmptyString8 = new byte[4];
                    this.Translation = Vector3.Zero;
                    this.EmptyString9 = new byte[4];
                }
                public override void Read(BinaryReader reader)
                {
                    this.Name = reader.ReadInt32();
                    this.Material = reader.ReadInt16();
                    this.Flags = ((FlagsOptions)(reader.ReadInt16()));
                    this.RelativeMassScale = reader.ReadSingle();
                    this.Friction = reader.ReadSingle();
                    this.Restitution = reader.ReadSingle();
                    this.Volume = reader.ReadSingle();
                    this.Mass = reader.ReadSingle();
                    this.EmptyString = reader.ReadBytes(2);
                    this.Phantom = reader.ReadInt16();
                    this.EmptyString1 = reader.ReadBytes(4);
                    this.Size1 = reader.ReadInt16();
                    this.Count = reader.ReadInt16();
                    this.EmptyString2 = reader.ReadBytes(4);
                    this.Radius = reader.ReadSingle();
                    this.EmptyString3 = reader.ReadBytes(4);
                    this.Size2 = reader.ReadInt16();
                    this.Count1 = reader.ReadInt16();
                    this.EmptyString4 = reader.ReadBytes(4);
                    this.EmptyString5 = reader.ReadBytes(4);
                    this.RotationI = reader.Read<Vector3>();
                    this.EmptyString6 = reader.ReadBytes(4);
                    this.RotationJ = reader.Read<Vector3>();
                    this.EmptyString7 = reader.ReadBytes(4);
                    this.RotationK = reader.Read<Vector3>();
                    this.EmptyString8 = reader.ReadBytes(4);
                    this.Translation = reader.Read<Vector3>();
                    this.EmptyString9 = reader.ReadBytes(4);
                }
                public override void Write(BinaryWriter writer)
                {
                }
                public enum FlagsOptions : Int16
                {
                    Unused = 1,
                }
            }
            [FieldSetAttribute(80, 16)]
            public sealed class PillsBlock : AbideTagBlock
            {
                [FieldAttribute("name^*", typeof(StringId))]
                public StringId Name;
                [FieldAttribute("material*", typeof(Int16))]
                public Int16 Material;
                [FieldAttribute("flags", typeof(FlagsOptions))]
                [OptionsAttribute(typeof(FlagsOptions), true)]
                public FlagsOptions Flags;
                [FieldAttribute("relative mass scale", typeof(Single))]
                public Single RelativeMassScale;
                [FieldAttribute("friction", typeof(Single))]
                public Single Friction;
                [FieldAttribute("restitution", typeof(Single))]
                public Single Restitution;
                [FieldAttribute("volume *", typeof(Single))]
                public Single Volume;
                [FieldAttribute("mass*", typeof(Single))]
                public Single Mass;
                [FieldAttribute("", typeof(Byte[]))]
                [PaddingAttribute(2)]
                public Byte[] EmptyString;
                [FieldAttribute("phantom*", typeof(Int16))]
                public Int16 Phantom;
                [FieldAttribute("", typeof(Byte[]))]
                [PaddingAttribute(4)]
                public Byte[] EmptyString1;
                [FieldAttribute("size*", typeof(Int16))]
                public Int16 Size1;
                [FieldAttribute("count*", typeof(Int16))]
                public Int16 Count;
                [FieldAttribute("", typeof(Byte[]))]
                [PaddingAttribute(4)]
                public Byte[] EmptyString2;
                [FieldAttribute("radius*", typeof(Single))]
                public Single Radius;
                [FieldAttribute("bottom*", typeof(Vector3))]
                public Vector3 Bottom;
                [FieldAttribute("", typeof(Byte[]))]
                [PaddingAttribute(4)]
                public Byte[] EmptyString3;
                [FieldAttribute("top*", typeof(Vector3))]
                public Vector3 Top;
                [FieldAttribute("", typeof(Byte[]))]
                [PaddingAttribute(4)]
                public Byte[] EmptyString4;
                public override int Size
                {
                    get
                    {
                        return 80;
                    }
                }
                public override void Initialize()
                {
                    this.Name = StringId.Zero;
                    this.Material = 0;
                    this.Flags = ((FlagsOptions)(0));
                    this.RelativeMassScale = 0;
                    this.Friction = 0;
                    this.Restitution = 0;
                    this.Volume = 0;
                    this.Mass = 0;
                    this.EmptyString = new byte[2];
                    this.Phantom = 0;
                    this.EmptyString1 = new byte[4];
                    this.Size1 = 0;
                    this.Count = 0;
                    this.EmptyString2 = new byte[4];
                    this.Radius = 0;
                    this.Bottom = Vector3.Zero;
                    this.EmptyString3 = new byte[4];
                    this.Top = Vector3.Zero;
                    this.EmptyString4 = new byte[4];
                }
                public override void Read(BinaryReader reader)
                {
                    this.Name = reader.ReadInt32();
                    this.Material = reader.ReadInt16();
                    this.Flags = ((FlagsOptions)(reader.ReadInt16()));
                    this.RelativeMassScale = reader.ReadSingle();
                    this.Friction = reader.ReadSingle();
                    this.Restitution = reader.ReadSingle();
                    this.Volume = reader.ReadSingle();
                    this.Mass = reader.ReadSingle();
                    this.EmptyString = reader.ReadBytes(2);
                    this.Phantom = reader.ReadInt16();
                    this.EmptyString1 = reader.ReadBytes(4);
                    this.Size1 = reader.ReadInt16();
                    this.Count = reader.ReadInt16();
                    this.EmptyString2 = reader.ReadBytes(4);
                    this.Radius = reader.ReadSingle();
                    this.Bottom = reader.Read<Vector3>();
                    this.EmptyString3 = reader.ReadBytes(4);
                    this.Top = reader.Read<Vector3>();
                    this.EmptyString4 = reader.ReadBytes(4);
                }
                public override void Write(BinaryWriter writer)
                {
                }
                public enum FlagsOptions : Int16
                {
                    Unused = 1,
                }
            }
            [FieldSetAttribute(48, 4)]
            public sealed class CharacterPhysicsGroundStructBlock : AbideTagBlock
            {
                [FieldAttribute("maximum slope angle:degrees", typeof(Single))]
                public Single MaximumSlopeAngle;
                [FieldAttribute("downhill falloff angle:degrees", typeof(Single))]
                public Single DownhillFalloffAngle;
                [FieldAttribute("downhill cutoff angle:degrees", typeof(Single))]
                public Single DownhillCutoffAngle;
                [FieldAttribute("uphill falloff angle:degrees", typeof(Single))]
                public Single UphillFalloffAngle;
                [FieldAttribute("uphill cutoff angle:degrees", typeof(Single))]
                public Single UphillCutoffAngle;
                [FieldAttribute("downhill velocity scale", typeof(Single))]
                public Single DownhillVelocityScale;
                [FieldAttribute("uphill velocity scale", typeof(Single))]
                public Single UphillVelocityScale;
                [FieldAttribute("", typeof(Byte[]))]
                [PaddingAttribute(20)]
                public Byte[] EmptyString;
                public override int Size
                {
                    get
                    {
                        return 48;
                    }
                }
                public override void Initialize()
                {
                    this.MaximumSlopeAngle = 0;
                    this.DownhillFalloffAngle = 0;
                    this.DownhillCutoffAngle = 0;
                    this.UphillFalloffAngle = 0;
                    this.UphillCutoffAngle = 0;
                    this.DownhillVelocityScale = 0;
                    this.UphillVelocityScale = 0;
                    this.EmptyString = new byte[20];
                }
                public override void Read(BinaryReader reader)
                {
                    this.MaximumSlopeAngle = reader.ReadSingle();
                    this.DownhillFalloffAngle = reader.ReadSingle();
                    this.DownhillCutoffAngle = reader.ReadSingle();
                    this.UphillFalloffAngle = reader.ReadSingle();
                    this.UphillCutoffAngle = reader.ReadSingle();
                    this.DownhillVelocityScale = reader.ReadSingle();
                    this.UphillVelocityScale = reader.ReadSingle();
                    this.EmptyString = reader.ReadBytes(20);
                }
                public override void Write(BinaryWriter writer)
                {
                }
            }
            [FieldSetAttribute(44, 4)]
            public sealed class CharacterPhysicsFlyingStructBlock : AbideTagBlock
            {
                [FieldAttribute("bank angle:degrees#angle at which we bank left/right when sidestepping or turning" +
                    " while moving forwards", typeof(Single))]
                public Single BankAngle;
                [FieldAttribute("bank apply time:seconds#time it takes us to apply a bank", typeof(Single))]
                public Single BankApplyTime;
                [FieldAttribute("bank decay time:seconds#time it takes us to recover from a bank", typeof(Single))]
                public Single BankDecayTime;
                [FieldAttribute("pitch ratio#amount that we pitch up/down when moving up or down", typeof(Single))]
                public Single PitchRatio;
                [FieldAttribute("max velocity:world units per second#max velocity when not crouching", typeof(Single))]
                public Single MaxVelocity;
                [FieldAttribute("max sidestep velocity:world units per second#max sideways or up/down velocity whe" +
                    "n not crouching", typeof(Single))]
                public Single MaxSidestepVelocity;
                [FieldAttribute("acceleration:world units per second squared", typeof(Single))]
                public Single Acceleration;
                [FieldAttribute("deceleration:world units per second squared", typeof(Single))]
                public Single Deceleration;
                [FieldAttribute("angular velocity maximum:degrees per second#turn rate", typeof(Single))]
                public Single AngularVelocityMaximum;
                [FieldAttribute("angular acceleration maximum:degrees per second squared#turn acceleration rate", typeof(Single))]
                public Single AngularAccelerationMaximum;
                [FieldAttribute("crouch velocity modifier:[0,1]#how much slower we fly if crouching (zero = same s" +
                    "peed)", typeof(Single))]
                public Single CrouchVelocityModifier;
                public override int Size
                {
                    get
                    {
                        return 44;
                    }
                }
                public override void Initialize()
                {
                    this.BankAngle = 0;
                    this.BankApplyTime = 0;
                    this.BankDecayTime = 0;
                    this.PitchRatio = 0;
                    this.MaxVelocity = 0;
                    this.MaxSidestepVelocity = 0;
                    this.Acceleration = 0;
                    this.Deceleration = 0;
                    this.AngularVelocityMaximum = 0;
                    this.AngularAccelerationMaximum = 0;
                    this.CrouchVelocityModifier = 0;
                }
                public override void Read(BinaryReader reader)
                {
                    this.BankAngle = reader.ReadSingle();
                    this.BankApplyTime = reader.ReadSingle();
                    this.BankDecayTime = reader.ReadSingle();
                    this.PitchRatio = reader.ReadSingle();
                    this.MaxVelocity = reader.ReadSingle();
                    this.MaxSidestepVelocity = reader.ReadSingle();
                    this.Acceleration = reader.ReadSingle();
                    this.Deceleration = reader.ReadSingle();
                    this.AngularVelocityMaximum = reader.ReadSingle();
                    this.AngularAccelerationMaximum = reader.ReadSingle();
                    this.CrouchVelocityModifier = reader.ReadSingle();
                }
                public override void Write(BinaryWriter writer)
                {
                }
            }
            [FieldSetAttribute(0, 4)]
            public sealed class CharacterPhysicsDeadStructBlock : AbideTagBlock
            {
                public override int Size
                {
                    get
                    {
                        return 0;
                    }
                }
                public override void Initialize()
                {
                }
                public override void Read(BinaryReader reader)
                {
                }
                public override void Write(BinaryWriter writer)
                {
                }
            }
            [FieldSetAttribute(0, 4)]
            public sealed class CharacterPhysicsSentinelStructBlock : AbideTagBlock
            {
                public override int Size
                {
                    get
                    {
                        return 0;
                    }
                }
                public override void Initialize()
                {
                }
                public override void Read(BinaryReader reader)
                {
                }
                public override void Write(BinaryWriter writer)
                {
                }
            }
            public enum FlagsOptions : Int32
            {
                CenteredAtOrigin = 1,
                ShapeSpherical = 2,
                UsePlayerPhysics = 4,
                ClimbAnySurface = 8,
                Flying = 16,
                NotPhysical = 32,
                DeadCharacterCollisionGroup = 64,
            }
        }
        public enum FlagsOptions : Int32
        {
            Unused = 1,
            InfectionForm = 2,
            ImmuneToFallingDamage = 4,
            RotateWhileAirborne = 8,
            ZappedByShields = 16,
            AttachUponImpact = 32,
            NotOnMotionSensor = 64,
        }
        public enum DefaultTeamOptions : Int16
        {
            Default = 0,
            Player = 1,
            Human = 2,
            Covenant = 3,
            Flood = 4,
            Sentinel = 5,
            Heretic = 6,
            Prophet = 7,
            Unused8 = 8,
            Unused9 = 9,
            Unused10 = 10,
            Unused11 = 11,
            Unused12 = 12,
            Unused13 = 13,
            Unused14 = 14,
            Unused15 = 15,
        }
        public enum MotionSensorBlipSizeOptions : Int16
        {
            Medium = 0,
            Small = 1,
            Large = 2,
        }
    }
}
#pragma warning restore CS1591