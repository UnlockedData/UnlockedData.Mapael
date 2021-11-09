using System.Text.Json.Serialization;

namespace UnlockedData.Mapael.Models;

#nullable enable
public class MapOptions
{
    public Map Map { get; set; } = new Map();

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Dictionary<string, MapPlot>? Plots { get; set; } 
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Dictionary<string, AreaObject>? Areas { get; set; } 

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Legend? Legend { get; set; }

}

#nullable disable

