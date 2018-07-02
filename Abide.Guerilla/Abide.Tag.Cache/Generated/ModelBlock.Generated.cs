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
    /// Represents the generated model_block tag block.
    /// </summary>
    public sealed class ModelBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelBlock"/> class.
        /// </summary>
        public ModelBlock()
        {
            this.Fields.Add(new ExplanationField("MODEL", ""));
            this.Fields.Add(new TagReferenceField("render model", "mode"));
            this.Fields.Add(new TagReferenceField("collision model", "coll"));
            this.Fields.Add(new TagReferenceField("animation", "jmad"));
            this.Fields.Add(new TagReferenceField("physics", "phys"));
            this.Fields.Add(new TagReferenceField("physics_model", "phmo"));
            this.Fields.Add(new ExplanationField("level of detail", @"If a model is further away than the LOD reduction distance, it will be reduced to that LOD.
So the L1 reduction distance should be really long and the L5 reduction distance should be really short.
This means distances should be in descending order, e.g. 5 4 3 2 1.

Note that if we run out of memory or too many models are on screen at once, the engine may reduce
models to a lower LOD BEFORE they reach the reduction distance for that LOD.

If a model has a begin fade distance and disappear distance, it will begin fading out at that distance,
reaching zero alpha and disappearing at the disappear distance. These distances should be greater than all
of the LOD reduction distances.
"));
            this.Fields.Add(new RealField("disappear distance:world units"));
            this.Fields.Add(new RealField("begin fade distance:world units"));
            this.Fields.Add(new PadField("", 4));
            this.Fields.Add(new RealField("reduce to L1:world units (super low)"));
            this.Fields.Add(new RealField("reduce to L2:world units (low)"));
            this.Fields.Add(new RealField("reduce to L3:world units (medium)"));
            this.Fields.Add(new RealField("reduce to L4:world units (high)"));
            this.Fields.Add(new RealField("reduce to L5:world units (super high)"));
            this.Fields.Add(new SkipField("", 4));
            this.Fields.Add(new EnumField("shadow fade distance", "fade at super high detail level", "fade at high detail level", "fade at medium detail level", "fade at low detail level", "fade at super low detail level", "fade never"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new BlockField<ModelVariantBlock>("variants", 64));
            this.Fields.Add(new BlockField<ModelMaterialBlock>("materials", 32));
            this.Fields.Add(new BlockField<GlobalDamageInfoBlock>("new damage info", 1));
            this.Fields.Add(new BlockField<ModelTargetBlock>("targets", 32));
            this.Fields.Add(new BlockField<ModelRegionBlock>("", 16));
            this.Fields.Add(new BlockField<ModelNodeBlock>("", 255));
            this.Fields.Add(new PadField("", 4));
            this.Fields.Add(new BlockField<ModelObjectDataBlock>("model object data", 1));
            this.Fields.Add(new ExplanationField("more stuff", ""));
            this.Fields.Add(new TagReferenceField("default dialogue#The default dialogue tag for this model (overriden by variants)", "udlg"));
            this.Fields.Add(new TagReferenceField("UNUSED*", "shad"));
            this.Fields.Add(new LongFlagsField("flags", "active camo always on", "active camo always merge", "active camo never merge"));
            this.Fields.Add(new StringIdField("default dialogue effect#The default dialogue tag for this model (overriden by var" +
                        "iants)"));
            this.Fields.Add(new CharIntegerField(""));
            this.Fields.Add(new CharIntegerField(""));
            this.Fields.Add(new CharIntegerField(""));
            this.Fields.Add(new CharIntegerField(""));
            this.Fields.Add(new CharIntegerField(""));
            this.Fields.Add(new CharIntegerField(""));
            this.Fields.Add(new CharIntegerField(""));
            this.Fields.Add(new CharIntegerField(""));
            this.Fields.Add(new CharIntegerField(""));
            this.Fields.Add(new CharIntegerField(""));
            this.Fields.Add(new CharIntegerField(""));
            this.Fields.Add(new CharIntegerField(""));
            this.Fields.Add(new CharIntegerField(""));
            this.Fields.Add(new CharIntegerField(""));
            this.Fields.Add(new CharIntegerField(""));
            this.Fields.Add(new CharIntegerField(""));
            this.Fields.Add(new CharIntegerField(""));
            this.Fields.Add(new CharIntegerField(""));
            this.Fields.Add(new CharIntegerField(""));
            this.Fields.Add(new CharIntegerField(""));
            this.Fields.Add(new CharIntegerField(""));
            this.Fields.Add(new CharIntegerField(""));
            this.Fields.Add(new CharIntegerField(""));
            this.Fields.Add(new CharIntegerField(""));
            this.Fields.Add(new CharIntegerField(""));
            this.Fields.Add(new CharIntegerField(""));
            this.Fields.Add(new CharIntegerField(""));
            this.Fields.Add(new CharIntegerField(""));
            this.Fields.Add(new CharIntegerField(""));
            this.Fields.Add(new CharIntegerField(""));
            this.Fields.Add(new CharIntegerField(""));
            this.Fields.Add(new CharIntegerField(""));
            this.Fields.Add(new CharIntegerField(""));
            this.Fields.Add(new CharIntegerField(""));
            this.Fields.Add(new CharIntegerField(""));
            this.Fields.Add(new CharIntegerField(""));
            this.Fields.Add(new CharIntegerField(""));
            this.Fields.Add(new CharIntegerField(""));
            this.Fields.Add(new CharIntegerField(""));
            this.Fields.Add(new CharIntegerField(""));
            this.Fields.Add(new CharIntegerField(""));
            this.Fields.Add(new CharIntegerField(""));
            this.Fields.Add(new CharIntegerField(""));
            this.Fields.Add(new CharIntegerField(""));
            this.Fields.Add(new CharIntegerField(""));
            this.Fields.Add(new CharIntegerField(""));
            this.Fields.Add(new CharIntegerField(""));
            this.Fields.Add(new CharIntegerField(""));
            this.Fields.Add(new CharIntegerField(""));
            this.Fields.Add(new CharIntegerField(""));
            this.Fields.Add(new CharIntegerField(""));
            this.Fields.Add(new CharIntegerField(""));
            this.Fields.Add(new CharIntegerField(""));
            this.Fields.Add(new CharIntegerField(""));
            this.Fields.Add(new CharIntegerField(""));
            this.Fields.Add(new CharIntegerField(""));
            this.Fields.Add(new CharIntegerField(""));
            this.Fields.Add(new CharIntegerField(""));
            this.Fields.Add(new CharIntegerField(""));
            this.Fields.Add(new CharIntegerField(""));
            this.Fields.Add(new CharIntegerField(""));
            this.Fields.Add(new CharIntegerField(""));
            this.Fields.Add(new CharIntegerField(""));
            this.Fields.Add(new CharIntegerField(""));
            this.Fields.Add(new LongFlagsField("runtime flags*", "contains run-time nodes"));
            this.Fields.Add(new BlockField<GlobalScenarioLoadParametersBlock>("scenario load parameters", 32));
            this.Fields.Add(new ExplanationField("HOLOGRAM", "hologram shader is applied whenever the control function from it\'s object is non-" +
                        "zero"));
            this.Fields.Add(new TagReferenceField("hologram shader", "shad"));
            this.Fields.Add(new StringIdField("hologram control function"));
        }
        /// <summary>
        /// Gets and returns the name of the model_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "model_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the model_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "model";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the model_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the model_block tag block.
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
