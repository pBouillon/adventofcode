using System.Collections.Generic;

using TestCommons;

namespace _2021.Day2;

public class PuzzleTest : SolverTest<Solver, IEnumerable<Command>, int>
{
    private readonly Command[] Commands = new[]
    {
        new Command("forward", 5),
        new Command("down", 5),
        new Command("forward", 8),
        new Command("up", 3),
        new Command("down", 8),
        new Command("forward", 2),
    };

    protected override Example PartOne => new()
    {
        Input = Commands,
        Result = 150,
    };

    protected override Example PartTwo => new()
    {
        Input = Commands,
        Result = 900,
    };
}
