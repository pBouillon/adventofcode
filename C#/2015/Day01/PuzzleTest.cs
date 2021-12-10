using TestCommons;

namespace _2015.Day01;

public class PuzzleTest : SolverTest<Solver, string, int>
{
    protected override Example PartOne => new()
    {
        Input = ")())())",
        Result = -3,
    };

    protected override int PartOneSolution => 138;

    protected override Example PartTwo => new()
    {
        Input = "()())",
        Result = 5,
    };

    protected override int PartTwoSolution => 1771;
}
