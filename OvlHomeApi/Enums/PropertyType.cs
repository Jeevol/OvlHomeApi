using System.Text.Json.Serialization;

namespace OvlHomeApi.Enums;

public enum PropertyType
{
    [JsonStringEnumMemberName("devices.properties.float")]
    Float,
    [JsonStringEnumMemberName("devices.properties.event")]
    Event
}
