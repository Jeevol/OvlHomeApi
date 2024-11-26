using OvlHomeApi.Enums;

namespace OvlHomeApi.Models;

public class CapabilityParameters
{
    public CapabilityInstance? Instance { get; set; }

    // OnOf capability
    public bool? Split { get; set; }

    // ColorSetting capability
    public ColorModel? ColorModel { get; set; }
    public TemperatureRange? TemperatureK { get; set; }
    public ColorScenes? ColorScene { get; set; }

    // VideoStream capability
    public List<VideoProtocol>? Protocols { get; set; }

    // Mode capability
    public List<DeviceMode>? Modes { get; set; }

    // Range capability
    public Unit? Unit { get; set; }
    public bool? RandomAccess { get; set; }
    public CapabilityRange? Range { get; set; }
}
