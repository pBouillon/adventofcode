using TestCommons;

namespace _2015.Day06;

public class PuzzleTest : SolverTest<Solver, Command[], long>
{
    private readonly Command[] _commands =
    {
        new(Status.Toggle, new Coordinate(0, 0), new Coordinate(999, 999)),
    };

    protected override Example PartOne => new()
    {
        Input = _commands,
        Result = 1000000,
    };

    protected override long PartOneSolution => 569999;
    
    protected override Example PartTwo => new()
    {
        Input = _commands,
        Result = 2000000,
    };

    protected override long PartTwoSolution => 17836115;
}

