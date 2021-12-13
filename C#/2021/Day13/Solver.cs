using Commons;

using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace _2021.Day13;

public enum Axis { X, Y}

public record Coordinate(int X, int Y);

public record FoldingInstruction(Axis Direction, int Offset);

public class Solver : ISolver<(Dictionary<Coordinate, bool>, IEnumerable<FoldingInstruction>), int>
{
    public string InputPath => "Day13.txt";

    public int PartOne((Dictionary<Coordinate, bool>, IEnumerable<FoldingInstruction>) input)
    {
        throw new System.NotImplementedException();
    }

    public int PartTwo((Dictionary<Coordinate, bool>, IEnumerable<FoldingInstruction>) input)
    {
        throw new System.NotImplementedException();
    }

    public (Dictionary<Coordinate, bool>, IEnumerable<FoldingInstruction>) ReadInput(string inputPath)
    {
        var points = File
            .ReadLines(inputPath)
            .TakeWhile(line => !string.IsNullOrWhiteSpace(line))
            .Select(line =>
            {
                var split = line
                    .Split(',')
                    .Select(int.Parse)
                    .ToArray();

                return new Coordinate(split[0], split[1]);
            })
            .ToDictionary(
                coordinate => coordinate,
                coordinate => true);

        var instructions = File
            .ReadLines(inputPath)
            .SkipWhile(line => char.IsDigit(line[0]) || string.IsNullOrWhiteSpace(line))
            .Select(line =>
            {
                var matches = Regex
                    .Match(line, @"fold along ([xy])=(\d)")
                    .Groups
                    .Cast<Group>()
                    .Skip(1)
                    .Select(group => group.Value)
                    .ToArray();

                return new FoldingInstruction(
                    matches[0] == "x" ? Axis.X : Axis.Y,
                    int.Parse(matches[1]));
            });

        return (points, instructions);
    }
}
