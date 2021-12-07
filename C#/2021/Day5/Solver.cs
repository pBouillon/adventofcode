using Commons;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _2021.Day5;

public record Coordinate(int X, int Y);

public record Range(Coordinate Begin, Coordinate End)
{
    public Coordinate Vector => new(End.X - Begin.X, End.Y - Begin.Y);

    public IEnumerable<Coordinate> GetPointsInRange()
    {
        var pointsToGenerate = Math.Max(Math.Abs(Vector.X), Math.Abs(Vector.Y));
        var direction = new Coordinate(Math.Sign(Vector.X), Math.Sign(Vector.Y));

        return Enumerable.Range(0, pointsToGenerate + 1)
            .Select(i => new Coordinate(Begin.X + i * direction.X, Begin.Y + i * direction.Y));
    }
}

public class Solver : ISolver<IEnumerable<Range>, int>
{
    public string InputPath
        => "Day5/input.txt";

    public int PartOne(IEnumerable<Range> input)
    {
        var straightRanges = input.Where(range => range.Begin.X == range.End.X || range.Begin.Y == range.End.Y);
        return CountIntersections(straightRanges);
    }

    public int PartTwo(IEnumerable<Range> input)
        => CountIntersections(input);

    public int CountIntersections(IEnumerable<Range> ranges)
    {
        var grid = new Dictionary<Coordinate, int>();

        foreach (var range in ranges)
        {
            foreach (var point in range.GetPointsInRange())
            {
                grid[point] = grid.GetValueOrDefault(point, 0) + 1;
            }
        }

        return grid.Count(entry => entry.Value > 1);
    }

    public IEnumerable<Range> ReadInput(string inputPath)
        => File
            .ReadLines(inputPath)
            .Select(line => line
                .Split(" -> ")
                .ToList()
                .Select(coordinate =>
                {
                    var points = coordinate
                        .Split(',')
                        .Select(raw => int.Parse(raw))
                        .ToArray();

                    return new Coordinate(points[0], points[1]);
                })
                .ToArray())
            .Select(coordinates => new Range(coordinates[0], coordinates[1]));
}
