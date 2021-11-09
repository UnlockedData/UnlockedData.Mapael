using System.Text.Json.Serialization;

namespace UnlockedData.Mapael.Models;

public class PlotObject : MapObject
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public PlotShape? Type { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? Size { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? Width { get; set; } 
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? Height { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Url { get; set; } 
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Path { get; set; }
    
   

}