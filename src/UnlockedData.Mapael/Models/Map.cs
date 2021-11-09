using System.Text.Json.Serialization;

namespace UnlockedData.Mapael.Models;

public class Map
{
    public string Name { get; set; } = "world_countries_miller";
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public ZoomOptions? Zoom { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Tooltip? Tooltip { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? CssClass { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public MapObject? DefaultArea { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public PlotObject? DefaultPlot { get; set; } 
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public MapObject? DefaultLink { get; set; }


}