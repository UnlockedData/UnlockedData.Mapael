using System.Text.Json.Serialization;

namespace UnlockedData.Mapael.Models;

public class LegendOptions
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Title { get; set; }

    public string CssClass { get; set; } = "legend";
         
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public RaphaelObjectAttrs? LabelAttrs { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public RaphaelObjectAttrs? LabelAttrsHover { get; set; }
    
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public RaphaelObjectAttrs? TitleAttrs { get; set; }
    
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? Display { get; set; }
    
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? Exclusive { get; set; }
    
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? MarginLeft { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? MarginLeftTitle { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? MarginLeftLabel { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? MarginBottom { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? MarginBottomTitle { get; set; }  
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public HideElementsConfig? HideElemsOnClick { get; set; }  
    
    public List<DataSlice> Slices { get; set; } = new List<DataSlice>();
}