using System.Text.Json.Serialization;
using Microsoft.JSInterop;

namespace UnlockedData.Mapael.Models;

public class MapObject
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public RaphaelObjectAttrs Attrs { get; set; } = new RaphaelObjectAttrs();
    
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public RaphaelObjectAttrs AttrsHover { get; set; } = new RaphaelObjectAttrs();
    
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public MapObjectTooltip Tooltip { get; set; } 
    
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public MapObjectText Text { get; set; } = new MapObjectText();
    
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Href { get; set; }
    
    // [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    // public Dictionary<string, IJSObjectReference>? EventHandlers { get; set; }
}