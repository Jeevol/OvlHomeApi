using OvlHomeApi.Enums;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace OvlHomeApi.Models;

public class PropertyState
{
    public PropertyInstance Instance { get; set; }
    [JsonInclude]
    private object? Value { get; set; }
    [JsonIgnore]
    public string? EventValue { get => Value is not null ? (Value as string ?? JsonSerializer.Deserialize<string>((JsonElement)Value)) : null; set => Value = value; }
    [JsonIgnore]
    public float? FloatValue { get => Value is not null ? (Value as float? ?? JsonSerializer.Deserialize<float>((JsonElement)Value)) : null; set => Value = value; }
}
