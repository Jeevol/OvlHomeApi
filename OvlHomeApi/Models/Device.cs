using OvlHomeApi.Enums;

namespace OvlHomeApi.Models;

public class Device
{
    public string Id { get; set; } = string.Empty;
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? Room { get; set; }
    public DeviceType? Type { get; set; }
    public Dictionary<string, object>? CustomData { get; set; }
    public List<Capability>? Capabilities { get; set; }
    public List<Property>? Properties { get; set; }
    public DeviceInfo? DeviceInfo { get; set; }
    public ActionResult? ActionResult { get; set; }
    public ErrorCode? ErrorCode { get; set; }
    public string? ErrorMessage { get; set; }
}
