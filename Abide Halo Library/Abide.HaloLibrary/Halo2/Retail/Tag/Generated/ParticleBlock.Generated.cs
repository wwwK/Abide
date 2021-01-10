//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Abide.HaloLibrary.Halo2.Retail.Tag.Generated
{
    using System;
    using Abide.HaloLibrary;
    using Abide.HaloLibrary.Halo2.Retail.Tag;
    
    /// <summary>
    /// Represents the generated particle_block tag block.
    /// </summary>
    internal sealed class ParticleBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ParticleBlock"/> class.
        /// </summary>
        public ParticleBlock()
        {
            this.Fields.Add(new LongFlagsField("flags", "spins", "random u mirror", "random v mirror", "frame animation one shot", "select random sequence", "disable frame blending", "can animate backwards", "receive lightmap lighting", "tint from diffuse texture", "dies at rest", "dies on structure collision", "dies in media", "dies in air", "bitmap authored vertically", "has sweetener"));
            this.Fields.Add(new EnumField("particle billboard style", "screen facing", "parallel to direction", "perpendicular to direction", "vertical", "horizontal"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new ShortIntegerField("first sequence index"));
            this.Fields.Add(new ShortIntegerField("sequence count"));
            this.Fields.Add(new ExplanationField("Shader Parameters", ""));
            this.Fields.Add(new TagReferenceField("shader template", 1937007981));
            this.Fields.Add(new BlockField<GlobalShaderParameterBlock>("shader parameters", 64));
            this.Fields.Add(new ExplanationField("Color", "controls how the color of the particle changes as\na function of its input"));
            this.Fields.Add(new StructField<ParticlePropertyColorStructNewBlock>("color"));
            this.Fields.Add(new ExplanationField("Alpha", "seperate from color, controls how the particle fades\nas a function of its input"));
            this.Fields.Add(new StructField<ParticlePropertyScalarStructNewBlock>("alpha"));
            this.Fields.Add(new ExplanationField("Scale", "controls how the size of a particle changes as\na function of its input"));
            this.Fields.Add(new StructField<ParticlePropertyScalarStructNewBlock>("scale"));
            this.Fields.Add(new ExplanationField("Rotation", "controls how the particle rotates. 0= 0 degrees, .5= 180 degrees, 1.0= 360 degree" +
                        "s"));
            this.Fields.Add(new StructField<ParticlePropertyScalarStructNewBlock>("rotation"));
            this.Fields.Add(new ExplanationField("Frame index", "provides finer grain control over how the animation\nhappens.  a output of 0.25 me" +
                        "ans that when that input\nis fed in, the particle will be 25% of the way through\n" +
                        "its animation."));
            this.Fields.Add(new StructField<ParticlePropertyScalarStructNewBlock>("frame index"));
            this.Fields.Add(new ExplanationField("Spawned Effects", "collision occurs when particle physics has collision, death spawned when particle" +
                        " dies"));
            this.Fields.Add(new TagReferenceField("collision effect#effect, material effect or sound spawned when this particle coll" +
                        "ides with something", -3));
            this.Fields.Add(new TagReferenceField("death effect#effect, material effect or sound spawned when this particle dies", -3));
            this.Fields.Add(new ExplanationField("Attached Particle Systems", "Locations:\nup - particles shoot straight up\ngravity - particles shoot straight do" +
                        "wn\nNONE - opposite of particle direction"));
            this.Fields.Add(new BlockField<EffectLocationsBlock>("locations", 32));
            this.Fields.Add(new BlockField<ParticleSystemDefinitionBlockNew>("attached particle systems", 32));
            this.Fields.Add(new BlockField<ShaderPostprocessDefinitionNewBlock>("", 1));
            this.Fields.Add(new PadField("", 8));
            this.Fields.Add(new PadField("", 16));
            this.Fields.Add(new PadField("", 16));
        }
        /// <summary>
        /// Gets and returns the name of the particle_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "particle_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the particle_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "particle";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the particle_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the particle_block tag block.
        /// </summary>
        public override int Alignment
        {
            get
            {
                return 4;
            }
        }
    }
}
