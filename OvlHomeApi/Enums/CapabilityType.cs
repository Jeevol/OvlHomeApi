using System.Text.Json.Serialization;

namespace OvlHomeApi.Enums;

public enum CapabilityType
{
    [JsonStringEnumMemberName("devices.capabilities.on_off")]
    OnOff,
    [JsonStringEnumMemberName("devices.capabilities.color_setting")]
    ColorSetting,
    [JsonStringEnumMemberName("devices.capabilities.video_stream")]
    VideoStream,
    [JsonStringEnumMemberName("devices.capabilities.mode")]
    Mode,
    [JsonStringEnumMemberName("devices.capabilities.range")]
    Range,
    [JsonStringEnumMemberName("devices.capabilities.toggle")]
    Toggle
}
