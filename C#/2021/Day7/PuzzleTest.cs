using System.Collections.Generic;

using TestCommons;

namespace _2021.Day7;

public class PuzzleTest : SolverTest<Solver, IEnumerable<int>, int>
{
    protected override Example PartOne => new()
    {
        Input = new List<int> { 16, 1, 2, 0, 4, 2, 7, 1, 2, 14 },
        Result = 37,
    };

    protected override Example PartTwo => new()
    {
        Input = new List<int> { 16, 1, 2, 0, 4, 2, 7, 1, 2, 14 },
        Result = 168,
    };
}

