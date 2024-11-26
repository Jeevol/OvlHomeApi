namespace OvlHomeApi.Models;

public class Payload
{
    public string? UserId { get; set; }
    public List<Device> Devices { get; set; } = [];
}
