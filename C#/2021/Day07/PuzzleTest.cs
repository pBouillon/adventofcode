using TestCommons;

namespace _2021.Day07;

public class PuzzleTest : SolverTest<Solver, int[], int>
{
    private readonly int[] _crabPositions = { 16, 1, 2, 0, 4, 2, 7, 1, 2, 14 };

    protected override Example PartOne => new()
    {
        Input = _crabPositions,
        Result = 37,
    };

    protected override int PartOneSolution => 347509;

    protected override Example PartTwo => new()
    {
        Input = _crabPositions,
        Result = 168,
    };

    protected override int PartTwoSolution => 98257206;
}
