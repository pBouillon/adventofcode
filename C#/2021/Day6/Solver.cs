using Commons;

using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _2021.Day6;

public class Solver : ISolver<Dictionary<int, long>, long>
{
    public string InputPath
        => "Day6/input.txt";

    private Dictionary<int, long> GetNextGeneration(Dictionary<int, long> current)
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

    private long GetPopulationAfterSomeTime(Dictionary<int, long> initial, int elapsedDays)
        => Enumerable.Range(0, elapsedDays)
            .Aggregate(
                initial,
                (current, _) => GetNextGeneration(current))
            .Values
            .Sum();

    public long PartOne(Dictionary<int, long> currentPopulation)
        => GetPopulationAfterSomeTime(currentPopulation, 80);

    public long PartTwo(Dictionary<int, long> currentPopulation)
        => GetPopulationAfterSomeTime(currentPopulation, 256);

    public Dictionary<int, long> ReadInput(string inputPath)
        => File
            .ReadLines(inputPath)
            .First()
            .Split(",")
            .Select(internalTimer => int.Parse(internalTimer))
            .GroupBy(internalTimer => internalTimer)
            .ToDictionary(value => value.Key, value => (long) value.Count());
}
