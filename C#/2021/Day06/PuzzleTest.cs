using System.Collections.Generic;

using TestCommons;

namespace _2021.Day06;

public class PuzzleTest : SolverTest<Solver, Dictionary<int, long>, long>
{
    private readonly Dictionary<int, long> _fishes = new()
    {
        { 1, 1 },
        { 2, 1 },
        { 3, 2 },
        { 4, 1 }
    };

    protected override Example PartOne => new()
    {
        Input = _fishes,
        Result = 5934,
    };

    protected override long PartOneSolution => 352872;

    protected override Example PartTwo => new()
    {
        Input = _fishes,
        Result = 26984457539,
    };

    protected override long PartTwoSolution => 1604361182149;
}

