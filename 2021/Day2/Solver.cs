using Commons;

using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _2021.Day2;

public record Command(string Name, int Magnitude);

public record Coordinate(int X, int Y);

public record AimCoordinate(int X, int Y, int Aim);

public class Solver : ISolver<IEnumerable<Command>, int>
{
    public string InputPath
        => "Day2/input.txt";

    public int PartOne(IEnumerable<Command> input)
    {
        var position = new Coordinate(0, 0);

        foreach (var command in input)
        {
            position = command switch
            {
                { Name: "forward" } => position with { X = position.X + command.Magnitude },
                { Name: "down" } => position with { Y = position.Y - command.Magnitude },
                { Name: "up" } => position with { Y = position.Y + command.Magnitude },
                _ => throw new System.Exception("Unknown command"),
            };
        }

        var depth = position.Y * -1;
        return position.X * depth;
    }

    public int PartTwo(IEnumerable<Command> input)
    {
        var position = new AimCoordinate(0, 0, 0);

        foreach (var command in input)
        {
            position = command switch
            {
                { Name: "forward" } => position with
                {
                    X = position.X + command.Magnitude,
                    Y = position.Y + position.Aim * command.Magnitude,
                },
                { Name: "down" } => position with { Aim = position.Aim - command.Magnitude },
                { Name: "up" } => position with { Aim = position.Aim + command.Magnitude },
                _ => throw new System.Exception("Unknown command"),
            };
        }

        var depth = position.Y * -1;
        return position.X * depth;
    }

    public IEnumerable<Command> ReadInput(string inputPath)
        => File
            .ReadLines(inputPath)
            .Select(input =>
            {
                var splitted = input.Split(' ');
                return new Command(splitted[0], int.Parse(splitted[1]));
            });
}
