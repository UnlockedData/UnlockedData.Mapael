using System.Text.Json.Serialization;

public class Legend
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public LegendOptions? Area { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public LegendOptions? Plot { get; set; }
}