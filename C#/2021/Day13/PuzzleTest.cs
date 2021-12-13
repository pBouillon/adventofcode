using System;
using System.Collections.Generic;

using TestCommons;

namespace _2021.Day13;

public class PuzzleTest : SolverTest<Solver, (Dictionary<Coordinate, bool>, IEnumerable<FoldingInstruction>), int>
{
    protected override Example PartOne => new()
    {
        Input = (new Dictionary<Coordinate, bool>(), Array.Empty<FoldingInstruction>()),
        Result = 17,
    };

    protected override int PartOneSolution => 0;

    protected override Example PartTwo => new()
    {
        Input = (new Dictionary<Coordinate, bool>(), Array.Empty<FoldingInstruction>()),
        Result = 0,
    };

    protected override int PartTwoSolution => 0;
}
