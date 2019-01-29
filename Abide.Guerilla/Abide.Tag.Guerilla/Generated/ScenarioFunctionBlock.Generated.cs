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
    /// Represents the generated scenario_function_block tag block.
    /// </summary>
    public sealed class ScenarioFunctionBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScenarioFunctionBlock"/> class.
        /// </summary>
        public ScenarioFunctionBlock()
        {
            this.Fields.Add(new LongFlagsField("Flags", "Scripted#Level script will set this value; other settings here will be ignored.", "Invert#Result of function is 1 minus actual result.", "Additive", "Always Active#Function does not deactivate when at or below lower bound."));
            this.Fields.Add(new StringField("Name^"));
            this.Fields.Add(new RealField("Period:Seconds#Period for above function (lower values make function oscillate qu" +
                        "ickly; higher values make it oscillate slowly)."));
            this.Fields.Add(new ShortBlockIndexField("Scale Period By#Multiply this function by above period"));
            this.Fields.Add(new EnumField("Function", "one", "zero", "cosine", "cosine (variable period)", "diagonal wave", "diagonal wave (variable period)", "slide", "slide (variable period)", "noise", "jitter", "wander", "spark"));
            this.Fields.Add(new ShortBlockIndexField("Scale Function By#Multiply this function by result of above function."));
            this.Fields.Add(new EnumField("Wobble Function#Curve used for wobble.", "one", "zero", "cosine", "cosine (variable period)", "diagonal wave", "diagonal wave (variable period)", "slide", "slide (variable period)", "noise", "jitter", "wander", "spark"));
            this.Fields.Add(new RealField("Wobble Period:Seconds#Time it takes for magnitude of this function to complete a " +
                        "wobble."));
            this.Fields.Add(new RealField("Wobble Magnitude:Percent#Amount of random wobble in the magnitude."));
            this.Fields.Add(new RealFractionField("Square Wave Threshold#If non-zero, all values above square wave threshold are sna" +
                        "pped to 1.0, and all values below it are snapped to 0.0 to create a square wave." +
                        ""));
            this.Fields.Add(new ShortIntegerField("Step Count#Number of discrete values to snap to (e.g., step count of 5 snaps func" +
                        "tion to 0.00, 0.25, 0.50,0.75, or 1.00)."));
            this.Fields.Add(new EnumField("Map to", "linear", "early", "very early", "late", "very late", "cosine", "one", "zero"));
            this.Fields.Add(new ShortIntegerField("Sawtooth Count#Number of times this function should repeat (e.g., sawtooth count " +
                        "of 5 gives function value of 1.0 at each of 0.25, 0.50, and 0.75, as well as at " +
                        "1.0)."));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new ShortBlockIndexField("Scale Result by#Multiply this function (e.g., from a weapon, vehicle) final resul" +
                        "t of all of the above math."));
            this.Fields.Add(new EnumField("Bounds Mode#Controls how bounds, below, are used.", "Clip", "Clip and Normalize", "Scale to Fit"));
            this.Fields.Add(new RealFractionBoundsField("Bounds"));
            this.Fields.Add(new PadField("", 4));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new ShortBlockIndexField("Turn Off with#If specified function is off, so is this function."));
            this.Fields.Add(new PadField("", 16));
            this.Fields.Add(new PadField("", 16));
        }
        /// <summary>
        /// Gets and returns the name of the scenario_function_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "scenario_function_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the scenario_function_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "scenario_function_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the scenario_function_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 32;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the scenario_function_block tag block.
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