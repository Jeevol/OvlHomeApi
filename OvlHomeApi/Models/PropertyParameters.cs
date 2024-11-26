using OvlHomeApi.Enums;

namespace OvlHomeApi.Models;

public class PropertyParameters
{
    public PropertyInstance Instance {  get; set; }
    public Unit? Unit {  get; set; }
    public List<PropertyEvent>? Events { get; set; }
}
