//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Abide.Tag.Guerilla.Generated
{
    using Abide.Tag;
    
    /// <summary>
    /// Represents the generated character_physics_flying_struct_block tag block.
    /// </summary>
    public sealed class CharacterPhysicsFlyingStructBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterPhysicsFlyingStructBlock"/> class.
        /// </summary>
        public CharacterPhysicsFlyingStructBlock()
        {
            this.Fields.Add(new AngleField("bank angle:degrees#angle at which we bank left/right when sidestepping or turning" +
                        " while moving forwards"));
            this.Fields.Add(new RealField("bank apply time:seconds#time it takes us to apply a bank"));
            this.Fields.Add(new RealField("bank decay time:seconds#time it takes us to recover from a bank"));
            this.Fields.Add(new RealField("pitch ratio#amount that we pitch up/down when moving up or down"));
            this.Fields.Add(new RealField("max velocity:world units per second#max velocity when not crouching"));
            this.Fields.Add(new RealField("max sidestep velocity:world units per second#max sideways or up/down velocity whe" +
                        "n not crouching"));
            this.Fields.Add(new RealField("acceleration:world units per second squared"));
            this.Fields.Add(new RealField("deceleration:world units per second squared"));
            this.Fields.Add(new AngleField("angular velocity maximum:degrees per second#turn rate"));
            this.Fields.Add(new AngleField("angular acceleration maximum:degrees per second squared#turn acceleration rate"));
            this.Fields.Add(new RealField("crouch velocity modifier:[0,1]#how much slower we fly if crouching (zero = same s" +
                        "peed)"));
        }
        /// <summary>
        /// Gets and returns the name of the character_physics_flying_struct_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "character_physics_flying_struct_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the character_physics_flying_struct_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "character_physics_flying_struct";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the character_physics_flying_struct_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the character_physics_flying_struct_block tag block.
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
