using OvlHomeApi.Enums;

namespace OvlHomeApi.Models;

public class ActionResult
{
    public Status Status { get; set; }
    public ErrorCode? ErrorCode { get; set; }
    public string? ErrorMessage { get; set; }
}
