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
    /// Represents the generated havok_vehicle_physics_struct_block tag block.
    /// </summary>
    public sealed class HavokVehiclePhysicsStructBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HavokVehiclePhysicsStructBlock"/> class.
        /// </summary>
        public HavokVehiclePhysicsStructBlock()
        {
            this.Fields.Add(new LongFlagsField("flags*", "invalid"));
            this.Fields.Add(new RealField("ground friction# for friction based vehicles only"));
            this.Fields.Add(new RealField("ground depth# for friction based vehicles only"));
            this.Fields.Add(new RealField("ground damp factor# for friction based vehicles only"));
            this.Fields.Add(new RealField("ground moving friction# for friction based vehicles only"));
            this.Fields.Add(new RealField("ground maximum slope 0#degrees 0-90"));
            this.Fields.Add(new RealField("ground maximum slope 1#degrees 0-90.  and greater than slope 0"));
            this.Fields.Add(new PadField("", 16));
            this.Fields.Add(new RealField("anti_gravity_bank_lift#lift per WU."));
            this.Fields.Add(new RealField("steering_bank_reaction_scale#how quickly we bank when we steer "));
            this.Fields.Add(new RealField("gravity scale#value of 0 defaults to 1.  .5 is half gravity"));
            this.Fields.Add(new RealField("radius*#generated from the radius of the hkConvexShape for this vehicle"));
            this.Fields.Add(new BlockField<AntiGravityPointDefinitionBlock>("anti gravity points", 16));
            this.Fields.Add(new BlockField<FrictionPointDefinitionBlock>("friction points", 16));
            this.Fields.Add(new BlockField<VehiclePhantomShapeBlock>("*", 1));
        }
        /// <summary>
        /// Gets and returns the name of the havok_vehicle_physics_struct_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "havok_vehicle_physics_struct_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the havok_vehicle_physics_struct_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "havok_vehicle_physics_struct";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the havok_vehicle_physics_struct_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the havok_vehicle_physics_struct_block tag block.
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
