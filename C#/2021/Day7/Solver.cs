using Commons;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _2021.Day7;

public class Solver : ISolver<IEnumerable<int>, int>
{
    public string InputPath
        => "Day7/input.txt";

    public int PartOne(IEnumerable<int> positions)
        => Enumerable.Range(positions.Min(), positions.Max())
            .Select(distance => positions.Sum(position => Math.Abs(distance - position)))
            .Min();

    public int PartTwo(IEnumerable<int> positions)
        => Enumerable.Range(positions.Min(), positions.Max())
            .Select(distance => positions
                .Select(position => Math.Abs(distance - position))
                .Sum(consumption => consumption * (consumption + 1) / 2))
            .Min();

    public IEnumerable<int> ReadInput(string inputPath)
        => File
            .ReadLines(inputPath)
            .First()
            .Split(",")
            .Select(value => int.Parse(value));
}
