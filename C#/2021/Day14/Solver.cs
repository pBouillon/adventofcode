using Commons;

using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _2021.Day14;

public class Solver : ISolver<(string, Dictionary<string, string>), int>
{
    public string InputPath => "Day14/input.txt";

    public int PartOne((string, Dictionary<string, string>) input)
    {
        var (start, conversions) = input;

        var result = Enumerable.Range(0, 10)
            .Aggregate(
                start,
                (current, _) => current = ComputePolymer(current, conversions));

        var elementsCount = result.GroupBy(letter => letter);

        var max = elementsCount.Max(element => element.Count());
        var min = elementsCount.Min(element => element.Count());

        return max - min;
    }

    private static string ComputePolymer(string current, Dictionary<string, string> conversions)
    {
        var result = string.Empty;

        for (var i = 0; i < current.Length - 1; ++i)
        {
            var p1 = current[i].ToString();
            var pair = current[i..(i + 2)];

            result += p1 + conversions.GetValueOrDefault(pair, string.Empty);
        }

        return result + current[^1];
    }

    public int PartTwo((string, Dictionary<string, string>) input)
    {
        var (start, conversions) = input;
        return 0;
    }

    public (string, Dictionary<string, string>) ReadInput(string inputPath)
    {
        var polymer = File.ReadLines(inputPath).First();

        var pairs = File.ReadLines(inputPath)
            .Skip(1)
            .Where(line => !string.IsNullOrWhiteSpace(line))
            .Select(line =>
            {
                var split = line.Split(" -> ");
                return new { Pair = split[0], Value = split[1] };
            })
            .ToDictionary(
                conversion => conversion.Pair,
                conversion => conversion.Value);

        return (polymer, pairs);
    }
}
