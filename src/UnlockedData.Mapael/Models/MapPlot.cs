using System.Text.Json.Serialization;

namespace UnlockedData.Mapael.Models;

public class MapPlot : PlotObject
{
   
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public double? Latitude { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public double? Longitude { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public double? X { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public double? Y { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? PlotsOn { get; set; } 


}