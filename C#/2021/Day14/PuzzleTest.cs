using System.Collections.Generic;
using TestCommons;

namespace _2021.Day14;

public class PuzzleTest : SolverTest<Solver, (string, Dictionary<string, string>), long>
{
    private readonly Dictionary<string, string> _insertions = new Dictionary<string, string>
    {
        { "CH", "B" },
        { "HH", "N" },
        { "CB", "H" },
        { "NH", "C" },
        { "HB", "C" },
        { "HC", "B" },
        { "HN", "C" },
        { "NN", "C" },
        { "BH", "H" },
        { "NC", "B" },
        { "NB", "B" },
        { "BN", "B" },
        { "BB", "N" },
        { "BC", "B" },
        { "CC", "N" },
        { "CN", "C" },
    };

    protected override Example PartOne => new()
    {
        Input = ("NNCB", _insertions),
        Result = 1588,
    };

    protected override long PartOneSolution => 3048;

    protected override Example PartTwo => new()
    {
        Input = ("NNCB", _insertions),
        Result = 2188189693529,
    };

    protected override long PartTwoSolution => 3288891573057;
}
