using TestCommons;

namespace _2015.Day03;

public class PuzzleTest : SolverTest<Solver, string, int>
{
    protected override Example PartOne => new()
    {
        Input = "^v^v^v^v^v",
        Result = 2,
    };

    protected override int PartOneSolution => 2565;

    protected override Example PartTwo => new()
    {
        Input = "^v^v^v^v^v",
        Result = 11,
    };

    protected override int PartTwoSolution => 2639;
}
