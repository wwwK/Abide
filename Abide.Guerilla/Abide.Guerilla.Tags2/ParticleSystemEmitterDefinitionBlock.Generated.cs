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
    
    [Abide.Guerilla.Tags.FieldSetAttribute(228, 4)]
    public class ParticleSystemEmitterDefinitionBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("particle physics", typeof(TagReference))]
        public TagReference ParticlePhysics;
        [Abide.Guerilla.Tags.FieldAttribute("particle emission rate", typeof(ParticlePropertyScalarStructNewBlock))]
        public ParticlePropertyScalarStructNewBlock ParticleEmissionRate;
        [Abide.Guerilla.Tags.FieldAttribute("particle lifespan", typeof(ParticlePropertyScalarStructNewBlock))]
        public ParticlePropertyScalarStructNewBlock ParticleLifespan;
        [Abide.Guerilla.Tags.FieldAttribute("particle velocity", typeof(ParticlePropertyScalarStructNewBlock))]
        public ParticlePropertyScalarStructNewBlock ParticleVelocity;
        [Abide.Guerilla.Tags.FieldAttribute("particle angular velocity", typeof(ParticlePropertyScalarStructNewBlock))]
        public ParticlePropertyScalarStructNewBlock ParticleAngularVelocity;
        [Abide.Guerilla.Tags.FieldAttribute("particle size", typeof(ParticlePropertyScalarStructNewBlock))]
        public ParticlePropertyScalarStructNewBlock ParticleSize;
        [Abide.Guerilla.Tags.FieldAttribute("particle tint", typeof(ParticlePropertyColorStructNewBlock))]
        public ParticlePropertyColorStructNewBlock ParticleTint1;
        [Abide.Guerilla.Tags.FieldAttribute("particle alpha", typeof(ParticlePropertyScalarStructNewBlock))]
        public ParticlePropertyScalarStructNewBlock ParticleAlpha1;
        [Abide.Guerilla.Tags.FieldAttribute("emission shape", typeof(Int32))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(EmissionShapeOptions), false)]
        public Int32 EmissionShape;
        [Abide.Guerilla.Tags.FieldAttribute("emission radius", typeof(ParticlePropertyScalarStructNewBlock))]
        public ParticlePropertyScalarStructNewBlock EmissionRadius;
        [Abide.Guerilla.Tags.FieldAttribute("emission angle", typeof(ParticlePropertyScalarStructNewBlock))]
        public ParticlePropertyScalarStructNewBlock EmissionAngle;
        [Abide.Guerilla.Tags.FieldAttribute("translational offset", typeof(Vector3))]
        public Vector3 TranslationalOffset;
        [Abide.Guerilla.Tags.FieldAttribute("relative direction#particle initial velocity direction relative to the location\'s" +
            " forward", typeof(Vector2))]
        public Vector2 RelativeDirection;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(8)]
        public Byte[] EmptyString;
        public enum EmissionShapeOptions
        {
            Sprayer = 0,
            Disc = 1,
            Globe = 2,
            Implode = 3,
            Tube = 4,
            Halo = 5,
            ImpactContour = 6,
            ImpactArea = 7,
            Debris = 8,
            Line = 9,
        }
    }
}
#pragma warning restore CS1591