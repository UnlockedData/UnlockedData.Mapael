using System.Text.Json.Serialization;

namespace UnlockedData.Mapael.Models;

public abstract class ZoomButtons
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public ZoomButton? Reset { get; set; } 
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public ZoomButton? In { get; set; } 
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public ZoomButton? Out { get; set; } 
}