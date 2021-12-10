using System.Collections.Generic;

using TestCommons;

namespace _2021.Day02;

public class PuzzleTest : SolverTest<Solver, IEnumerable<Command>, int>
{
    private readonly Command[] _commands = {
        new Command("forward", 5),
        new Command("down", 5),
        new Command("forward", 8),
        new Command("up", 3),
        new Command("down", 8),
        new Command("forward", 2),
    };

    protected override Example PartOne => new()
    {
        Input = _commands,
        Result = 150,
    };

    protected override int PartOneSolution => 1728414;

    protected override Example PartTwo => new()
    {
        Input = _commands,
        Result = 900,
    };

    protected override int PartTwoSolution => 1765720035;
}
