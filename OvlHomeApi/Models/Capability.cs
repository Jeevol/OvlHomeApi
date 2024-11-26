using OvlHomeApi.Enums;

namespace OvlHomeApi.Models;

public class Capability
{
    public CapabilityType Type { get; set; }
    public bool? Retrievable { get; set; }
    public bool? Reportable { get; set; }
    public CapabilityParameters? Parameters { get; set; }
    public CapabilityState? State { get; set; }
}
