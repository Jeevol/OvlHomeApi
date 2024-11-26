using System.Text.Json.Serialization;

namespace OvlHomeApi.Enums;

public enum Status
{
    [JsonStringEnumMemberName("DONE")]
    Done,
    [JsonStringEnumMemberName("ERROR")]
    Error
}
