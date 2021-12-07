using System.Collections.Generic;

using TestCommons;

namespace _2021.Day5;

public class PuzzleTest : SolverTest<Solver, IEnumerable<Range>, int>
{
    private readonly Range[] Ranges = new[]
    {
        new Range(new Coordinate(0, 9), new Coordinate(5, 9)),
        new Range(new Coordinate(8, 0), new Coordinate(0, 8)),
        new Range(new Coordinate(9, 4), new Coordinate(3, 4)),
        new Range(new Coordinate(2, 2), new Coordinate(2, 1)),
        new Range(new Coordinate(7, 0), new Coordinate(7, 4)),
        new Range(new Coordinate(6, 4), new Coordinate(2, 0)),
        new Range(new Coordinate(0, 9), new Coordinate(2, 9)),
        new Range(new Coordinate(3, 4), new Coordinate(1, 4)),
        new Range(new Coordinate(0, 0), new Coordinate(8, 8)),
        new Range(new Coordinate(5, 5), new Coordinate(8, 2)),
    };

    protected override Example PartOne => new()
    {
        Input = Ranges,
        Result = 5,
    };

    protected override Example PartTwo => new()
    {
        Input = Ranges,
        Result = 12,
    };
}
