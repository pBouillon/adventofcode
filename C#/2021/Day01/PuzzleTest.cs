using TestCommons;

namespace _2021.Day01;

public class PuzzleTest : SolverTest<Solver, int[], int>
{
    private readonly int[] _measures = { 199, 200, 208, 210, 200, 207, 240, 269, 260, 263 };

    protected override Example PartOne => new()
    {
        Input = _measures,
        Result = 7,
    };

    protected override int PartOneSolution => 1696;

    protected override Example PartTwo => new()
    {
        Input = _measures,
        Result = 5,
    };

    protected override int PartTwoSolution => 1737;
}
