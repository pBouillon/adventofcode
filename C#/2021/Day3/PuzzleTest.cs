using TestCommons;

namespace _2021.Day3;

public class PuzzleTest : SolverTest<Solver, string[], int> 
{
    private readonly string[] Measures = new[]
    {
        "00100",
        "11110",
        "10110",
        "10111",
        "10101",
        "01111",
        "00111",
        "11100",
        "10000",
        "11001",
        "00010",
        "01010",
    };

    protected override Example PartOne => new()
    {
        Input = Measures,
        Result = 198,
    };

    protected override Example PartTwo => new()
    {
        Input = Measures,
        Result = 230,
    };
}
