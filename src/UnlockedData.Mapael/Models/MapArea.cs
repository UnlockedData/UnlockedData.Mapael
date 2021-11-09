using System.Text.Json.Serialization;

namespace UnlockedData.Mapael.Models;

public class MapArea : MapObject
{
    
  
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public double? Value { get; set; } 
   

}