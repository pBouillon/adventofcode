using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using TestCommons;

namespace _2021.Day11;

public class PuzzleTest : SolverTest<Solver, Dictionary<Coordinate, int>, int>
{
    private static Dictionary<Coordinate, int> GetOctopuses()
    {
        var raw = new[]
        {
            "5483143223",
            "2745854711",
            "5264556173",
            "6141336146",
            "6357385478",
            "4167524645",
            "2176841721",
            "6882881134",
            "4846848554",
            "5283751526"
        };

        return new Dictionary<Coordinate, int>(
            from y in Enumerable.Range(0, 10)
            from x in Enumerable.Range(0, 10)
            select new KeyValuePair<Coordinate, int>(new Coordinate(x, y), raw[y][x] - '0')
        );
    }

    protected override Example PartOne => new()
    {
        Input = GetOctopuses(),
        Result = 1656,
    };

    protected override int PartOneSolution => 1613;

    protected override Example PartTwo => new()
    {
        Input = GetOctopuses(),
        Result = 195,
    };

    protected override int PartTwoSolution => 510;
}
