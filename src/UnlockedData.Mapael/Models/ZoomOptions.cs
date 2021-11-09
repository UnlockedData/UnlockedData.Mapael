using System.Text.Json.Serialization;

namespace UnlockedData.Mapael.Models;

public class ZoomOptions
{
    public bool Enabled { get; set; } = false;
    public bool MouseWheel { get; set; } = true;
    public bool Touch { get; set; } = true;
    public int MinLevel { get; set; } = 0; 
    public int MaxLevel { get; set; } = 5;
    public double Step { get; set; } = 0.25;
    public int AnimDuration { get; set; } = 200;
    public string AnimEasing { get; set; } = "linear";
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public ZoomButtons? Buttons { get; set; } 
    
}