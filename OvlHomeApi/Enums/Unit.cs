using System.Text.Json.Serialization;

namespace OvlHomeApi.Enums;

public enum Unit
{
    [JsonStringEnumMemberName("unit.ampere")]
    Ampere,
    [JsonStringEnumMemberName("unit.percent")]
    Percent,
    [JsonStringEnumMemberName("unit.ppm")]
    Ppm,
    [JsonStringEnumMemberName("unit.kilowatt_hour")]
    KilowattHour,
    [JsonStringEnumMemberName("unit.cubic_meter")]
    CubicMeter,
    [JsonStringEnumMemberName("unit.gigacalorie")]
    Gigacalorie,
    [JsonStringEnumMemberName("unit.illumination.lux")]
    IlluminationLux,
    [JsonStringEnumMemberName("unit.density.mcg_m3")]
    DensityMcgM3,
    [JsonStringEnumMemberName("unit.watt")]
    Watt,
    [JsonStringEnumMemberName("unit.pressure.atm")]
    PressureAtm,
    [JsonStringEnumMemberName("unit.pressure.pascal")]
    PressurePascal,
    [JsonStringEnumMemberName("unit.pressure.bar")]
    PressureBar,
    [JsonStringEnumMemberName("unit.pressure.mmhg")]
    PressureMmhg,
    [JsonStringEnumMemberName("unit.temperature.celsius")]
    TemperatureCelsius,
    [JsonStringEnumMemberName("unit.temperature.kelvin")]
    TemperatureKelvin,
    [JsonStringEnumMemberName("unit.volt")]
    Volt
}
