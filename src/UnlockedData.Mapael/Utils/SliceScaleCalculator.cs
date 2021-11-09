using UnlockedData.Mapael.Models;

namespace UnlockedData.Mapael.Utils;

public interface IScaleCalculator<out TOutput> 
{
    TOutput ScaleLinear(object value);
}

public static class ScaleCalculatorFactory
{
    public static IScaleCalculator<TOutput>? CreateScaleCalculator<TOutput, T>(List<T> data, Tuple<TOutput, TOutput> range) where T: MapObject
    {
        if (typeof(TOutput) == typeof(double))
        {
            var _range = new Tuple<double, double>(Convert.ToDouble(range.Item1), Convert.ToDouble(range.Item2));
            return (IScaleCalculator<TOutput>) new DoubleScaleCalculator<T>(data, _range);
        }

        return default;
    }
}

public class DoubleScaleCalculator<T> : IScaleCalculator<double> where T: MapObject
{
    private readonly Tuple<double, double> _domain;
    private readonly Tuple<double, double> _range;

    public double ScaleLinear(object value)
    {
        var number = (double)value;
       return _range.Item1+ (_range.Item2 -_range.Item1) * ((number - _domain.Item1)/(_domain.Item2 - _domain.Item1));
    }

 public DoubleScaleCalculator(List<T> data, Tuple<double, double> range) 
    {
        var values = data.Select(x => x.Value.Value);
        _domain = new Tuple<double, double>(values.Min(), values.Max());
        _range = range;
    }    
    
}

public class SliceGenerator
{   
   
    public static List<DataSlice> GenerateSlices<T, TOutput>(List<T> data, Tuple<TOutput, TOutput> range, int steps = 10, Scale scale = Scale.Linear) where T:MapObject
    {
        var scaleCalculator = ScaleCalculatorFactory.CreateScaleCalculator<TOutput,T>(data, range);
        
        var values = data.Select(x => x.Value.Value).ToList();
        var maxValue = values.Max();
        var minValue = values.Min();
        
        var rangeValues = RangeValues(steps, maxValue, minValue);

        var domainValues = SizeValues(rangeValues, scaleCalculator);
        
        

        var result = new List<DataSlice>();
        for (var i = 0; i < steps; i++)
        {
            result.Add(new DataSlice()
            {
                Min = (i ==0) ? null : rangeValues[i],
                Max = (i==(steps-1)) ? null: rangeValues[i + 1],
                Size = domainValues[i]
                    
            });
        }

        return result;
    }

    private static List<double> RangeValues(int steps, double maxValue, double minValue) 
    {
        var rangeValues = new List<double>();
        for (int i = 0; i < steps; i++)
        {
            rangeValues.Add(((double)i / steps * (maxValue - minValue)) + minValue);
        }

        return rangeValues;
    }
    
    private static List<int> SizeValues<TOutput>(List<double> rangeValues, IScaleCalculator<TOutput> calculator )
    {
        if (typeof(TOutput) == typeof(double))
        {
            return rangeValues.Select(x =>
                (int)Math.Round(Convert.ToDouble(calculator.ScaleLinear(x)), 0)
            ).ToList();
        }

        return null;
    }
}


public enum Scale
{
    Linear,
    Logarithmic
}





