using System.Collections.Generic;

using TestCommons;

namespace _2021.Day6;

public class PuzzleTest : SolverTest<Solver, Dictionary<int, long>, long>
{
    private readonly Dictionary<int, long> Fishes = new()
    {
        { 1, 1 },
        { 2, 1 },
        { 3, 2 },
        { 4, 1 }
    };

    protected override Example PartOne => new()
    {
        Input = Fishes,
        Result = 5934,
    };

    protected override Example PartTwo => new()
    {
        Input = Fishes,
        Result = 26984457539,
    };
}

