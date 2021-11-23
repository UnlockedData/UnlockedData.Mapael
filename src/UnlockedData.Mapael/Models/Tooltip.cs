namespace UnlockedData.Mapael.Models;
public abstract class Tooltip
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? CssClass { get; set; }
}