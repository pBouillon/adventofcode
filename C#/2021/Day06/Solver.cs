using Commons;

using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _2021.Day06;

public class Solver : ISolver<Dictionary<int, long>, long>
{
    public string InputPath => "Day06/input.txt";

    private static Dictionary<int, long> GetNextGeneration(Dictionary<int, long> current)
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

    private static long GetPopulationAfterSomeTime(Dictionary<int, long> initial, int elapsedDays)
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
            .Select(int.Parse)
            .GroupBy(internalTimer => internalTimer)
            .ToDictionary(value => value.Key, value => (long) value.Count());
}
