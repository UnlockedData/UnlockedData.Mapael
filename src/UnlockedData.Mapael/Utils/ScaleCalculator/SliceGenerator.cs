﻿public static class SliceGenerator
{
    public static List<DataSlice> GenerateSlices<T, TOutput>(List<T> data, Tuple<TOutput, TOutput> range,
        int steps = 10, Scale scale = Scale.Linear) where T : MapObject
    {
        var scaleCalculator = ScaleCalculatorFactory.CreateScaleCalculator(data, range);

        var values = data.Select(x => x.Value.Value).ToList();
        var maxValue = values.Max();
        var minValue = values.Min();

        var rangeValues = RangeValues(steps, maxValue, minValue);

        var domainValues = SizeValues(rangeValues, scaleCalculator);


        var result = new List<DataSlice>();
        for (var i = 0; i < steps; i++)
            result.Add(new DataSlice
            {
                Min = i == 0 ? null : rangeValues[i],
                Max = i == steps - 1 ? null : rangeValues[i + 1],
                Size = domainValues[i]
            });

        return result;
    }

    private static List<double> RangeValues(int steps, double maxValue, double minValue)
    {
        var rangeValues = new List<double>();
        for (var i = 0; i < steps; i++) rangeValues.Add((double)i / steps * (maxValue - minValue) + minValue);

        return rangeValues;
    }

    private static List<int> SizeValues<TOutput>(List<double> rangeValues, IScaleCalculator<TOutput> calculator)
    {
        if (typeof(TOutput) == typeof(double))
            return rangeValues.Select(x =>
                (int)Math.Round(Convert.ToDouble(calculator.ScaleLinear(x)), 0)
            ).ToList();

        return null;
    }
}