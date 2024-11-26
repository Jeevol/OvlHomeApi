using OvlHomeApi.Enums;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace OvlHomeApi.Models;

public class CapabilityState
{
    public CapabilityInstance Instance { get; set; }
    [JsonInclude]
    private object? Value { get; set; }
    [JsonIgnore]
    public bool? OnValue { get => Value is not null ? (Value as bool? ?? JsonSerializer.Deserialize<bool>((JsonElement)Value)) : null; set => Value = value; }
    [JsonIgnore]
    public int? ColorValue { get => Value is not null ? (Value as int? ?? JsonSerializer.Deserialize<int>((JsonElement)Value)) : null; set => Value = value; }
    [JsonIgnore]
    public ColorSceneType? ColorSceneValue { get => Value is not null ? (Value as ColorSceneType? ?? JsonSerializer.Deserialize<ColorSceneType>((JsonElement)Value)) : null; set => Value = value; }
    [JsonIgnore]
    public ColorHsv? ColorHsvValue { get => Value is not null ? (Value as ColorHsv ?? JsonSerializer.Deserialize<ColorHsv>((JsonElement)Value)) : null; set => Value = value; }
    [JsonIgnore]
    public ModeType? ModeValue { get => Value as ModeType?; set => Value = value; }
    [JsonIgnore]
    public float? RangeValue { get => Value is not null ? (Value as float? ?? JsonSerializer.Deserialize<float>((JsonElement)Value)) : null; set => Value = value; }
    [JsonIgnore]
    public bool? ToggleValue { get => Value is not null ? (Value as bool? ?? JsonSerializer.Deserialize<bool>((JsonElement)Value)) : null; set => Value = value; }
    public ActionResult? ActionResult { get; set; }
}
