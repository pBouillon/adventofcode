using System.Collections.Generic;

using TestCommons;

namespace _2015.Day5;

public class PuzzleTest : SolverTest<Solver, IEnumerable<string>, int>
{
    protected override Example PartOne => new()
    {
        Input = new[]
        {
            "ugknbfddgicrmopn",  // Nice
            "aaa",               // Nice
            "jchzalrnumimnmhp",  // Not nice
            "haegwjzuvuyypxyu",  // Not nice
            "dvszwmarrgswjxmb"   // Not nice
        },
        Result = 2,
    };

    protected override int PartOneSolution => 236;

    protected override Example PartTwo => new()
    {
        Input = new[]
        {
            "qjhvhtzxzqqjkmpb",  // Nice
            "xxyxx",             // Nice
            "uurcxstgmygtbstg",  // Not nice
            "ieodomkazucvgmuy"   // Not nice
        },
        Result = 2,
    };

    protected override int PartTwoSolution => 51;
}
