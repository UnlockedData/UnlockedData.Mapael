namespace UnlockedData.Mapael.Models;
#nullable enable
public class LinkObject : MapObject
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public List<dynamic>? Between { get; set; }
    
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public double? Factor { get; set; }
}
#nullable disable