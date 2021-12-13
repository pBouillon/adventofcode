﻿using Commons;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace _2021.Day13;

public enum Axis { X, Y }

public record Coordinate(int X, int Y);

public record FoldingInstruction(Axis Direction, int Offset);

public class Solver : ISolver<(ISet<Coordinate>, IEnumerable<FoldingInstruction>), string>
{
    private readonly Dictionary<string, string> _letters = new()
    {
        { "011010011001111110011001", "A" },
        { "011010011000100010010110", "C" },
        { "100110011111100110011001", "H" },
        { "001100010001000110010110", "J" },
        { "100110101100101010101001", "K" },
        { "100110011001100110010110", "U" },
        { "111100010010010010001111", "Z" },
    };

    public string InputPath => "Day13/input.txt";

    private static ISet<Coordinate> GetPointsAfterFolds(ISet<Coordinate> points, IEnumerable<FoldingInstruction> instructions)
    {
        foreach (var (direction, offset) in instructions)
        {
            points = direction switch
            {
                Axis.X => points
                    .Select(point => point.X > offset
                        ? point with { X = 2 * offset - point.X }
                        : point)
                    .ToHashSet(),
                Axis.Y => points
                    .Select(point => point.Y > offset
                        ? point with { Y = 2 * offset - point.Y }
                        : point)
                    .ToHashSet(),
                _ => throw new ArgumentOutOfRangeException()
            };
        }

        return points;
    }

    public string PartOne((ISet<Coordinate>, IEnumerable<FoldingInstruction>) input)
    {
        var (points, instructions) = input;

        return GetPointsAfterFolds(points, instructions.Take(1))
            .Count
            .ToString();
    }

    public string PartTwo((ISet<Coordinate>, IEnumerable<FoldingInstruction>) input)
    {
        var (points, instructions) = input;

        points = GetPointsAfterFolds(points, instructions);

        return Enumerable.Range(0, 8)
            .Aggregate(
                string.Empty, 
                (current, next) => current + InterpretLetterAt(next, points));
    }

    private string InterpretLetterAt(int index, ICollection<Coordinate> points)
    {
        var letterSpace = new
        {
            Length = 4,
            Height = 6,
            Padding = 1,
        };

        var padding = index * (letterSpace.Length + letterSpace.Padding);

        var hash = string.Empty;

        for (var y = 0; y < letterSpace.Height; ++y)
        {
            for (var x = padding; x < letterSpace.Length + padding; ++x)
            {
                hash += points.Contains(new Coordinate(x, y))
                    ? "1"
                    : "0";
            }
        }

        return _letters.GetValueOrDefault(hash, string.Empty);
    }

    public (ISet<Coordinate>, IEnumerable<FoldingInstruction>) ReadInput(string inputPath)
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
            .ToHashSet();

        var instructions = File
            .ReadLines(inputPath)
            .SkipWhile(line => string.IsNullOrEmpty(line)|| char.IsDigit(line[0]))
            .Select(line =>
            {
                var matches = Regex
                    .Match(line, @"fold along ([xy])=(\d+)")
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
