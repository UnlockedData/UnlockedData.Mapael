namespace UnlockedData.Mapael.Models;

public abstract class Point
{
    
}

public class GeoPoint : Point
{
    public double Latitude { get; set; }
    public double Longitude { get; set; }
}

public class CartesianPoint : Point
{
    public double X { get; set; }
    public double Y { get; set; }
}