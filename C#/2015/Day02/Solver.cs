using System.Collections.Generic;
using System.IO;
using System.Linq;
using Commons;

namespace _2015.Day02;

public record Dimension(int Length, int Width, int Height)
{
    public int CubicFeetVolume
        => Length * Width * Height;

    public int Volume
        => 2 * Length * Width
            + 2 * Width * Height
            + 2 * Height * Length;

    public int ComputeSmallestArea()
    {
        var sides = new List<int> { Length, Width, Height };
        sides.Sort();

        return sides[0] * sides[1];
    }

    public int ComputeSmallestPerimeter()
    {
        var sides = new List<int> { Length, Width, Height };
        sides.Sort();

        return 2 * sides[0] + 2 * sides[1];
    }
}

public class Solver : ISolver<IEnumerable<Dimension>, int>
{
    public string InputPath => "Day02/input.txt";

    public int PartOne(IEnumerable<Dimension> input)
        => input.Sum(dimension => dimension.Volume + dimension.ComputeSmallestArea());

    public int PartTwo(IEnumerable<Dimension> input)
        => input.Sum(dimension => dimension.CubicFeetVolume + dimension.ComputeSmallestPerimeter());

    public IEnumerable<Dimension> ReadInput(string inputPath)
        => File.ReadLines(inputPath)
            .Select(line =>
            {
                var split = line
                    .Split('x')
                    .Select(int.Parse)
                    .ToArray();

                return new Dimension(split[0], split[1], split[2]);
            });
}
