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
    /// Represents the generated flock_definition_block tag block.
    /// </summary>
    public sealed class FlockDefinitionBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FlockDefinitionBlock"/> class.
        /// </summary>
        public FlockDefinitionBlock()
        {
            this.Fields.Add(new ShortBlockIndexField("bsp"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new ShortBlockIndexField("bounding volume"));
            this.Fields.Add(new WordFlagsField("flags", "hard boundaries on volume", "flock initially stopped"));
            this.Fields.Add(new RealField("ecology margin:wus#distance from ecology boundary that creature begins to be repu" +
                        "lsed"));
            this.Fields.Add(new BlockField<FlockSourceBlock>("sources", 10));
            this.Fields.Add(new BlockField<FlockSinkBlock>("sinks", 10));
            this.Fields.Add(new RealField("production frequency:boids/sec#How frequently boids are produced at one of the so" +
                        "urces (limited by the max boid count)"));
            this.Fields.Add(new RealBoundsField("scale"));
            this.Fields.Add(new TagReferenceField("creature^", "crea"));
            this.Fields.Add(new ShortBoundsField("boid count"));
            this.Fields.Add(new ExplanationField("Flock parameters", @"Recommended initial values (for a sentinel-sized unit): 
	neighborhood radius= 6.0 
	avoidance radius= 3 
 forward scale= 0.5 
 alignment scale= 0.5 
 avoidance scale= 1.0 
 leveling force scale= 0.1 
 perception angle= 120 
 average throttle= 0.75 
 maximum throttle= 1.0 
 position scale= 1.0 
 position min radius= 3 
 position max radius = 9"));
            this.Fields.Add(new ExplanationField("Let me give you a piece of free advice.", @"Flocks with a neighborhood radius of 0 don't FLOCK, per se (in the creature-creature interaction kind of way), but they are much cheaper. The best thing is to have a non-zero radius for small flocks, and a zero radius for large flocks (or for 'flow-flocks', ones with sources and sinks that are intended to create a steady flow of something). Note also that for flocks with a 0 neighborhood radius, the parameters for avoidance, alignment, position and perception angle are ignored entirely."));
            this.Fields.Add(new RealField("neighborhood radius:world units#distance within which one boid is affected by ano" +
                        "ther"));
            this.Fields.Add(new RealField("avoidance radius:world units#distance that a boid tries to maintain from another"));
            this.Fields.Add(new RealField("forward scale:[0..1]#weight given to boid\'s desire to fly straight ahead"));
            this.Fields.Add(new RealField("alignment scale:[0..1]#weight given to boid\'s desire to align itself with neighbo" +
                        "ring boids"));
            this.Fields.Add(new RealField("avoidance scale:[0..1]#weight given to boid\'s desire to avoid collisions with oth" +
                        "er boids, when within the avoidance radius"));
            this.Fields.Add(new RealField("leveling force scale:[0..1]#weight given to boids desire to fly level"));
            this.Fields.Add(new RealField("sink scale:[0..1]#weight given to boid\'s desire to fly towards its sinks"));
            this.Fields.Add(new AngleField("perception angle:degrees#angle-from-forward within which one boid can perceive an" +
                        "d react to another"));
            this.Fields.Add(new RealField("average throttle:[0..1]#throttle at which boids will naturally fly"));
            this.Fields.Add(new RealField("maximum throttle:[0..1]#maximum throttle applicable"));
            this.Fields.Add(new RealField("position scale:[0..1]#weight given to boid\'s desire to be near flock center"));
            this.Fields.Add(new RealField("position min radius:wus#distance to flock center beyond which an attracting force" +
                        " is applied"));
            this.Fields.Add(new RealField("position max radius:wus#distance to flock center at which the maximum attracting " +
                        "force is applied"));
            this.Fields.Add(new RealField("movement weight threshold#The threshold of accumulated weight over which movement" +
                        " occurs"));
            this.Fields.Add(new RealField("danger radius:wus#distance within which boids will avoid a dangerous object (e.g." +
                        " the player)"));
            this.Fields.Add(new RealField("danger scale#weight given to boid\'s desire to avoid danger"));
            this.Fields.Add(new ExplanationField("Perlin noise parameters", "Recommended initial values: \n\trandom offset scale= 0.2 \n\toffset period bounds= 1," +
                        " 3"));
            this.Fields.Add(new RealField("random offset scale:[0..1]#weight given to boid\'s random heading offset"));
            this.Fields.Add(new RealBoundsField("random offset period:seconds"));
            this.Fields.Add(new StringIdField("flock name"));
        }
        /// <summary>
        /// Gets and returns the name of the flock_definition_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "flock_definition_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the flock_definition_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "flock_definition_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the flock_definition_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 20;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the flock_definition_block tag block.
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
