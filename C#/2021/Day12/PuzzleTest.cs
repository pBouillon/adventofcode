using System.Collections.Generic;

using TestCommons;

namespace _2021.Day12;

public class PuzzleTest : SolverTest<Solver, Dictionary<string, List<string>>, int>
{
    private readonly Dictionary<string, List<string>> _map = new()
    {
        ["start"] = new List<string> { "A", "b" },
        ["A"] = new List<string> { "start", "b", "c", "end" },
        ["b"] = new List<string> { "start", "A", "d", "end" },
        ["c"] = new List<string> { "A" },
        ["d"] = new List<string> { "b" },
        ["end"] = new List<string> { "A", "b" },
    };

    protected override Example PartOne => new()
    {
        Input = _map,
        Result = 10
    };

    protected override int PartOneSolution => 4104;
    
    protected override Example PartTwo => new()
    {
        Input = _map,
        Result = 36
    };

    protected override int PartTwoSolution => 119760;
}

