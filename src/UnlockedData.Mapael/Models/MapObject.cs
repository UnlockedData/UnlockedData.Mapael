namespace UnlockedData.Mapael.Models;

public class MapObject
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public RaphaelObjectAttrs Attrs { get; set; } = new();

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public RaphaelObjectAttrs AttrsHover { get; set; } = new();

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public MapObjectTooltip? Tooltip { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public MapObjectText Text { get; set; } = new();

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Href { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public double? Value { get; set; }
}