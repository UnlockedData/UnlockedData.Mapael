using System.Text.Json.Serialization;

public abstract class Tooltip
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? CssClass { get; set; }
}