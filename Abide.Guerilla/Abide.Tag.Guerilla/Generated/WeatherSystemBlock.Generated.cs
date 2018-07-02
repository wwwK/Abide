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
    /// Represents the generated weather_system_block tag block.
    /// </summary>
    public sealed class WeatherSystemBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WeatherSystemBlock"/> class.
        /// </summary>
        public WeatherSystemBlock()
        {
            this.Fields.Add(new BlockField<GlobalParticleSystemLiteBlock>("particle system", 1));
            this.Fields.Add(new BlockField<GlobalWeatherBackgroundPlateBlock>("background plates", 3));
            this.Fields.Add(new StructField<GlobalWindModelStructBlock>("wind model"));
            this.Fields.Add(new RealField("fade radius"));
        }
        /// <summary>
        /// Gets and returns the name of the weather_system_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "weather_system_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the weather_system_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "weather_system";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the weather_system_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the weather_system_block tag block.
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
