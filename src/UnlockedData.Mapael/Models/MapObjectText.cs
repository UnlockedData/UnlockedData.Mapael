namespace UnlockedData.Mapael.Models;

public class MapObjectText
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string Content { get; set; }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public TextPosition Position { get; set; } = TextPosition.right;

    public dynamic Margin { get; set; } = 10;
    public RaphaelObjectAttrs Attrs { get; set; } = new();
    public RaphaelObjectAttrs AttrsHover { get; set; } = new();
}