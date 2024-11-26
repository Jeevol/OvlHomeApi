namespace OvlHomeApi.Enums;

public enum CapabilityInstance
{
    // OnOff category
    On,

    // ColorSetting category
    Hsv,
    Rgb,
    TemperatureK,
    Scene,

    // VideoStream category
    GetStream,

    // Mode category
    CleanupMode,
    CoffeeMode,
    Dishwashing,
    FanSpeed,
    Heat,
    InputSource,
    Program,
    Swing,
    TeaMode,
    Thermostat,
    VentilationMode,
    WorkSpeed,

    // Range category
    Brightness,
    Channel,
    Humidity,
    Open,
    Temperature,
    Volume,

    // Toggle category
    Backlight,
    ControlsLocked,
    Ionization,
    KeepWarm,
    Mute,
    Oscillation,
    Pause
}
