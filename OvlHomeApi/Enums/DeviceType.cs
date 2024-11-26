using System.Text.Json.Serialization;

namespace OvlHomeApi.Enums;

public enum DeviceType
{
    // Sensors category
    [JsonStringEnumMemberName("devices.types.sensor")]
    Sensor,
    [JsonStringEnumMemberName("devices.types.sensor.button")]
    SensorButton,
    [JsonStringEnumMemberName("devices.types.sensor.climate")]
    SensorClimate,
    [JsonStringEnumMemberName("devices.types.sensor.gas")]
    SensorGas,
    [JsonStringEnumMemberName("devices.types.sensor.illumination")]
    SensorIllumination,
    [JsonStringEnumMemberName("devices.types.sensor.motion")]
    SensorMotion,
    [JsonStringEnumMemberName("devices.types.sensor.open")]
    SensorOpen,
    [JsonStringEnumMemberName("devices.types.sensor.smoke")]
    SensorSmoke,
    [JsonStringEnumMemberName("devices.types.sensor.vibration")]
    SensorVibration,
    [JsonStringEnumMemberName("devices.types.sensor.water_leak")]
    SensorWaterLeak,

    // Smart meter category
    [JsonStringEnumMemberName("devices.types.smart_meter")]
    SmartMeter,
    [JsonStringEnumMemberName("devices.types.smart_meter.cold_water")]
    SmartMeterColdWater,
    [JsonStringEnumMemberName("devices.types.smart_meter.electricity")]
    SmartMeterElectricity,
    [JsonStringEnumMemberName("devices.types.smart_meter.gas")]
    SmartMeterGas,
    [JsonStringEnumMemberName("devices.types.smart_meter.heat")]
    SmartMeterHeat,
    [JsonStringEnumMemberName("devices.types.smart_meter.hot_water")]
    SmartMeterHotWater,

    // Media device category
    [JsonStringEnumMemberName("devices.types.camera")]
    Camera,
    [JsonStringEnumMemberName("devices.types.media_device")]
    MediaDevice,
    [JsonStringEnumMemberName("devices.types.media_device.receiver")]
    MediaDeviceReceiver,
    [JsonStringEnumMemberName("devices.types.media_device.tv")]
    MediaDeviceTv,
    [JsonStringEnumMemberName("devices.types.media_device.tv_box")]
    MediaDeviceTvBox,

    // Cooking category
    [JsonStringEnumMemberName("devices.types.cooking")]
    Cooking,
    [JsonStringEnumMemberName("devices.types.cooking.coffee_maker")]
    CookingCoffeeMaker,
    [JsonStringEnumMemberName("devices.types.cooking.kettle")]
    CookingKettle,
    [JsonStringEnumMemberName("devices.types.cooking.multicooker")]
    CookingMulticooker,
    [JsonStringEnumMemberName("devices.types.dishwasher")]
    Dishwasher,

    // Household appliances category
    [JsonStringEnumMemberName("devices.types.iron")]
    Iron,
    [JsonStringEnumMemberName("devices.types.vacuum_cleaner")]
    VacuumCleaner,
    [JsonStringEnumMemberName("devices.types.washing_machine")]
    WashingMachine,

    // Pet category
    [JsonStringEnumMemberName("devices.types.pet_drinking_fountain")]
    PetDrinkingFountain,
    [JsonStringEnumMemberName("devices.types.pet_feeder")]
    PetFeeder,

    // Climate control category
    [JsonStringEnumMemberName("devices.types.humidifier")]
    Humidifier,
    [JsonStringEnumMemberName("devices.types.purifier")]
    Purifier,
    [JsonStringEnumMemberName("devices.types.thermostat")]
    Thermostat,
    [JsonStringEnumMemberName("devices.types.thermostat.ac")]
    ThermostatAc,
    [JsonStringEnumMemberName("devices.types.ventilation")]
    Ventilation,
    [JsonStringEnumMemberName("devices.types.ventilation.fan")]
    VentilationFan,

    // Electrics category
    [JsonStringEnumMemberName("devices.types.light")]
    Light,
    [JsonStringEnumMemberName("devices.types.light.ceiling")]
    LightCeiling,
    [JsonStringEnumMemberName("devices.types.light.strip")]
    LightStrip,
    [JsonStringEnumMemberName("devices.types.socket")]
    Socket,
    [JsonStringEnumMemberName("devices.types.switch")]
    Switch,

    // Openable category
    [JsonStringEnumMemberName("devices.types.openable")]
    Openable,
    [JsonStringEnumMemberName("devices.types.openable.curtain")]
    OpenableCurtain,
    [JsonStringEnumMemberName("devices.types.openable.valve")]
    OpenableValve,

    // Other category
    [JsonStringEnumMemberName("devices.types.other")]
    Other
}
