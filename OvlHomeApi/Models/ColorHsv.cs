using System.Text.Json.Serialization;

namespace OvlHomeApi.Models;

public class ColorHsv
{
    [JsonPropertyName("h")]
    public int Hue { get; set; }
    [JsonPropertyName("s")]
    public int Saturation { get; set; }
    [JsonPropertyName("v")]
    public int Value { get; set; }
}
