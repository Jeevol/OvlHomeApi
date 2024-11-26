using OvlHomeApi.Enums;

namespace OvlHomeApi.Models;

public class Property
{
    public PropertyType Type { get; set; }
    public bool? Retrievable { get; set; }
    public bool? Reportable { get; set; }
    public PropertyParameters? Parameters { get; set; }
    public PropertyState? State { get; set; }
}
