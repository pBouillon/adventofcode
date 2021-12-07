using Commons;

using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _2021.Day6;

public class Solver : ISolver<IDictionary<int, long>, long>
{
    public string InputPath
        => "Day6/input.txt";

    private IDictionary<int, long> GetNextGeneration(IDictionary<int, long> current)
    {
        var next = current.ToDictionary(
                entry => entry.Key - 1,
                entry => entry.Value);

        if (!next.ContainsKey(-1)) return next;

        next[6] = next.GetValueOrDefault(6, 0) + next[-1];
        next[8] = next.GetValueOrDefault(8, 0) + next[-1];
        next.Remove(-1);

        return next;
    }

    public long PartOne(IDictionary<int, long> currentPopulation)
    {
        for (var i = 0; i < 80; ++i)
        {
            currentPopulation = GetNextGeneration(currentPopulation);
        }

        return currentPopulation.Values.Sum();
    }

    public long PartTwo(IDictionary<int, long> currentPopulation)
    {
        for (var i = 0; i < 256; ++i)
        {
            currentPopulation = GetNextGeneration(currentPopulation);
        }

        return currentPopulation.Values.Sum();
    }

    public IDictionary<int, long> ReadInput(string inputPath)
        => File
            .ReadLines(inputPath)
            .First()
            .Split(",")
            .Select(internalTimer => int.Parse(internalTimer))
            .GroupBy(internalTimer => internalTimer)
            .ToDictionary(value => value.Key, value => (long) value.Count());
}
