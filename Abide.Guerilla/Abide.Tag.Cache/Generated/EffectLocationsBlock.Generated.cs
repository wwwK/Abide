//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Abide.Tag.Cache.Generated
{
    using Abide.Tag;
    
    /// <summary>
    /// Represents the generated effect_locations_block tag block.
    /// </summary>
    public sealed class EffectLocationsBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EffectLocationsBlock"/> class.
        /// </summary>
        public EffectLocationsBlock()
        {
            this.Fields.Add(new ExplanationField("MARKER NAMES", @"In addition to the marker in the render model there are several special marker names:

replace
Replace allows you to use the same effect with different markers. Damage transition effects support this for example.

gravity, up
The direction of gravity (down) and the opposite direction (up).  Always supplied

normal
Vector pointing directly away from the surface you collided with. Supplied for effects from collision.

forward
The 'negative incident' vector i.e. the direction the object is moving in. Most commonly used to generated decals. Supplied for effects from collision.

backward
The 'incident' vector i.e. the opposite of the direction the object is moving in. Supplied for effects from collision.

reflection
The way the effect would reflect off the surface it hit. Supplied for effects from collision.

root
The object root (pivot). These can used for all effects which are associated with an object.

impact
The location of a havok impact.

"));
            this.Fields.Add(new OldStringIdField("marker name^"));
        }
        /// <summary>
        /// Gets and returns the name of the effect_locations_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "effect_locations_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the effect_locations_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "effect_locations_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the effect_locations_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 32;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the effect_locations_block tag block.
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
