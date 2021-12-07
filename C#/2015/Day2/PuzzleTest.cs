using System.Collections.Generic;

using TestCommons;

namespace _2015.Day2;

public class PuzzleTest : SolverTest<Solver, IEnumerable<Dimension>, int>
{
    protected override Example PartOne => new()
    {
        Input = new[] { new Dimension(2, 3, 4) },
        Result = 58,
    };

    protected override int PartOneSolution => 1586300;

    protected override Example PartTwo => new()
    {
        Input = new[] { new Dimension(1, 1, 10) },
        Result = 14,
    };

    protected override int PartTwoSolution => 3737498;
}
