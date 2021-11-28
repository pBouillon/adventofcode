using Commons;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;

namespace _2015.Day3;

public record Coordinate(int X, int Y);

public class Solver : ISolver<string, int>
{
    public string InputPath
        => "Day3/input.txt";

    private HashSet<Coordinate> GetVisitedHouses(string input)
    {
        var currentCoordinate = new Coordinate(0, 0);
        var visited = new HashSet<Coordinate> { currentCoordinate };

        foreach (var move in input)
        {
            currentCoordinate = move switch
            {
                '^' => currentCoordinate with { X = currentCoordinate.X + 1 },
                'v' => currentCoordinate with { X = currentCoordinate.X - 1 },
                '>' => currentCoordinate with { Y = currentCoordinate.Y + 1 },
                '<' => currentCoordinate with { Y = currentCoordinate.Y - 1 },
                _ => throw new Exception($"Unexpected move '{move}'"),
            };

            visited.Add(currentCoordinate);
        }

        return visited;
    }

    public int PartOne(string input)
        => GetVisitedHouses(input).Count;

    public int PartTwo(string input)
    {
        var santaPath = string.Join(string.Empty, input
            .ToCharArray()
            .Where((direction, index) => index % 2 != 0));

        var robotPath = string.Join(string.Empty, input
            .ToCharArray()
            .Where((direction, index) => index % 2 == 0));

        var visitedHouses = GetVisitedHouses(santaPath);
        visitedHouses.UnionWith(GetVisitedHouses(robotPath));

        return visitedHouses.Count;
    }

    public string ReadInput(string inputPath)
    {
        var fullPath = Path.Join(AppDomain.CurrentDomain.BaseDirectory, inputPath);
        return File.ReadLines(fullPath).FirstOrDefault() ?? String.Empty;
    }
}
