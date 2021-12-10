using Commons;

using System;
using System.IO;
using System.Linq;

namespace _2021.Day07;

public class Solver : ISolver<int[], int>
{
    public string InputPath => "Day07/input.txt";

    public int PartOne(int[] positions)
        => Enumerable.Range(positions.Min(), positions.Max())
            .Select(distance => positions.Sum(position => Math.Abs(distance - position)))
            .Min();

    public int PartTwo(int[] positions)
        => Enumerable.Range(positions.Min(), positions.Max())
            .Select(distance => positions
                .Select(position => Math.Abs(distance - position))
                .Sum(consumption => consumption * (consumption + 1) / 2))
            .Min();

    public int[] ReadInput(string inputPath)
        => File
            .ReadLines(inputPath)
            .First()
            .Split(",")
            .Select(int.Parse)
            .ToArray();
}
