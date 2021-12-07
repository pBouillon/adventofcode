using System.Collections.Generic;

using TestCommons;

namespace _2021.Day6;

public class PuzzleTest : SolverTest<Solver, IDictionary<int, long>, long>
{
    protected override Example PartOne => new()
    {
        Input = new Dictionary<int, long>
        {
            { 1, 1 },
            { 2, 1 },
            { 3, 2 },
            { 4, 1 }
        },
        Result = 5934,
    };

    protected override Example PartTwo => new()
    {
        Input = new Dictionary<int, long>
        {
            { 1, 1 },
            { 2, 1 },
            { 3, 2 },
            { 4, 1 }
        },
        Result = 26984457539,
    };
}

