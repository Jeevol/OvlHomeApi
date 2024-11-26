namespace OvlHomeApi.Models;

public class Root
{
    public string RequestId { get; set; } = string.Empty;
    public Payload? Payload { get; set; }
}
