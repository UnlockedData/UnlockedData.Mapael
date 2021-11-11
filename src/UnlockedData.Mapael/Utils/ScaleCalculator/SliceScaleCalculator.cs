public interface IScaleCalculator<out TOutput>
{
    TOutput ScaleLinear(object value);
}