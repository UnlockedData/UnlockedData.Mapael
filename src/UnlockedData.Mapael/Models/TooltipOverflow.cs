using System.Text.Json.Serialization;

namespace UnlockedData.Mapael.Models;

public class TooltipOverflow
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? Right { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? Bottom { get; set; }
}