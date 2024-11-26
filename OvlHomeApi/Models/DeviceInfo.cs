namespace OvlHomeApi.Models;

public class DeviceInfo
{
    public string Manufacturer { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public string? HwVersion { get; set; }
    public string? SwVersion { get; set; }
}
