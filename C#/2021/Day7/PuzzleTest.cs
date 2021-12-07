using System.Collections.Generic;

using TestCommons;

namespace _2021.Day7;

public class PuzzleTest : SolverTest<Solver, IEnumerable<int>, int>
{
    private readonly int[] CrabPositions = new[] { 16, 1, 2, 0, 4, 2, 7, 1, 2, 14 };

    protected override Example PartOne => new()
    {
        Input = CrabPositions,
        Result = 37,
    };

    protected override Example PartTwo => new()
    {
        Input = CrabPositions,
        Result = 168,
    };
}

