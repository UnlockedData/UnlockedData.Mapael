using System.Text.Json.Serialization;

namespace UnlockedData.Mapael.Models;

public class RaphaelObjectAttrs
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public double? Opacity { get; set; } 
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Fill { get; set; } 
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Stroke { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Transform { get; set; } 
    [JsonPropertyName("font-size")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? FontSize { get; set; } 
    [JsonPropertyName("font-weight")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FontWeight { get; set; } 
    [JsonPropertyName("stroke-width")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? StrokeWidth { get; set; }
    
    [JsonPropertyName("stroke-linejoin")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public StrokeLineJoin? StrokeLineJoin { get; set; } 
}