using System.Text.Json.Serialization;

namespace OvlHomeApi.Enums;

public enum PropertyInstance
{
    // Float category
    Amperage,
    Co2Level,
    ElectricityMeter,
    GasMeter,
    HeatMeter,
    Humidity,
    Illumination,
    Meter,
    Pm1Density,
    [JsonStringEnumMemberName("pm2.5_density")]
    Pm25Density,
    Pm10Density,
    Power,
    Pressure,
    Temperature,
    Tvoc,
    Voltage,
    WaterMeter,

    // Event category
    Vibration,
    Open,
    Button,
    Motion,
    Smoke,
    Gas,
    WaterLeak,

    // Both category
    BatteryLevel,
    FoodLevel,
    WaterLevel
}
