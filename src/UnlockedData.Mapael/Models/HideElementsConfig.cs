using System.Text.Json.Serialization;

namespace UnlockedData.Mapael.Models;

public class HideElementsConfig
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? Enabled { get; set; }   
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public double? Opacity { get; set; }   
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? AnimDuration { get; set; }   
}