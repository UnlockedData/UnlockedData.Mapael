public class DoubleScaleCalculator<T> : IScaleCalculator<double> where T : MapObject
{
    private readonly Tuple<double, double> _domain;
    private readonly Tuple<double, double> _range;

    public DoubleScaleCalculator(List<T> data, Tuple<double, double> range)
    {
        var values = data.Select(x => x.Value.Value);
        _domain = new Tuple<double, double>(values.Min(), values.Max());
        _range = range;
    }

    public double ScaleLinear(object value)
    {
        var number = (double)value;
        return _range.Item1 +
               (_range.Item2 - _range.Item1) * ((number - _domain.Item1) / (_domain.Item2 - _domain.Item1));
    }
}