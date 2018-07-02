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
    /// Represents the generated object_block tag block.
    /// </summary>
    public sealed class ObjectBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectBlock"/> class.
        /// </summary>
        public ObjectBlock()
        {
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new WordFlagsField("flags", "does not cast shadow", "search cardinal direction lightmaps on failure", "unused", "not a pathfinding obstacle", "extension of parent#object passes all function values to parent and uses parent\'s" +
                        " markers", "does not cause collision damage", "early mover", "early mover localized physics", "use static massive lightmap sample#cast a ton of rays once and store the results " +
                        "for lighting", "object scales attachments", "inherits player\'s appearance", "dead bipeds can\'t localize", "attach to clusters by dynamic sphere#use this for the mac gun on spacestation", "Effects created by this object do not spawn objects in multiplayer."));
            this.Fields.Add(new RealField("bounding radius:world units"));
            this.Fields.Add(new RealPoint3dField("bounding offset"));
            this.Fields.Add(new RealField("acceleration scale:[0,+inf]#marine 1.0, grunt 1.4, elite 0.9, hunter 0.5, etc."));
            this.Fields.Add(new EnumField("lightmap shadow mode", "default", "never", "always"));
            this.Fields.Add(new CharEnumField("sweetener size", "small", "medium", "large"));
            this.Fields.Add(new PadField("", 1));
            this.Fields.Add(new PadField("", 4));
            this.Fields.Add(new RealField("dynamic light sphere radius#sphere to use for dynamic lights and shadows. only us" +
                        "ed if not 0"));
            this.Fields.Add(new RealPoint3dField("dynamic light sphere offset#only used if radius not 0"));
            this.Fields.Add(new StringIdField("default model variant"));
            this.Fields.Add(new TagReferenceField("model", "hlmt"));
            this.Fields.Add(new TagReferenceField("crate object", "bloc"));
            this.Fields.Add(new TagReferenceField("modifier shader", "shad"));
            this.Fields.Add(new TagReferenceField("creation effect", "effe"));
            this.Fields.Add(new TagReferenceField("material effects", "foot"));
            this.Fields.Add(new BlockField<ObjectAiPropertiesBlock>("ai properties", 1));
            this.Fields.Add(new BlockField<ObjectFunctionBlock>("functions", 256));
            this.Fields.Add(new ExplanationField("Applying collision damage", "for things that want to cause more or less collision damage"));
            this.Fields.Add(new RealField("Apply collision damage scale#0 means 1.  1 is standard scale.  Some things may wa" +
                        "nt to apply more damage"));
            this.Fields.Add(new ExplanationField("Game collision damage parameters", "0 - means take default value from globals.globals"));
            this.Fields.Add(new RealField("min game acc (default)#0-oo"));
            this.Fields.Add(new RealField("max game acc (default)#0-oo"));
            this.Fields.Add(new RealField("min game scale (default)#0-1"));
            this.Fields.Add(new RealField("max game scale (default)#0-1"));
            this.Fields.Add(new ExplanationField("Absolute collision damage parameters", "0 - means take default value from globals.globals"));
            this.Fields.Add(new RealField("min abs acc (default)#0-oo"));
            this.Fields.Add(new RealField("max abs acc (default)#0-oo"));
            this.Fields.Add(new RealField("min abs scale (default)#0-1"));
            this.Fields.Add(new RealField("max abs scale (default)#0-1"));
            this.Fields.Add(new ShortIntegerField("hud text message index"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new BlockField<ObjectAttachmentBlock>("attachments", 16));
            this.Fields.Add(new BlockField<ObjectWidgetBlock>("widgets", 4));
            this.Fields.Add(new BlockField<OldObjectFunctionBlock>("old functions", 4));
            this.Fields.Add(new BlockField<ObjectChangeColors>("change colors", 4));
            this.Fields.Add(new BlockField<PredictedResourceBlock>("predicted resources*", 2048));
        }
        /// <summary>
        /// Gets and returns the name of the object_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "object_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the object_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "object";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the object_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the object_block tag block.
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
