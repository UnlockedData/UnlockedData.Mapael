namespace UnlockedData.Mapael.Utils.ScaleCalculator;
public interface IScaleCalculator<out TOutput>
{
    TOutput ScaleLinear(object value);
}