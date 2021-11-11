public static class ScaleCalculatorFactory
{
    public static IScaleCalculator<TOutput>? CreateScaleCalculator<TOutput, T>(List<T> data,
        Tuple<TOutput, TOutput> range) where T : MapObject
    {
        if (typeof(TOutput) == typeof(double))
        {
            var _range = new Tuple<double, double>(Convert.ToDouble(range.Item1), Convert.ToDouble(range.Item2));
            return (IScaleCalculator<TOutput>)new DoubleScaleCalculator<T>(data, _range);
        }

        return default;
    }
}