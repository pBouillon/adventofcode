using TestCommons;

namespace _2015.Day4;

public class PuzzleTest : SolverTest<Solver, string, int>
{
    protected override Example PartOne => new()
    {
        Input = "abcdef",
        Result = 609043,
    };

    protected override int PartOneSolution => 254575;

    protected override Example PartTwo => new()
    {
        Input = "abcdef",
        Result = 6742839,
    };

    protected override int PartTwoSolution => 1038736;
}

