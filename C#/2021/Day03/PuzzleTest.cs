using TestCommons;

namespace _2021.Day03;

public class PuzzleTest : SolverTest<Solver, string[], int> 
{
    private readonly string[] _measures = {
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
        Input = _measures,
        Result = 198,
    };

    protected override int PartOneSolution => 2003336;

    protected override Example PartTwo => new()
    {
        Input = _measures,
        Result = 230,
    };

    protected override int PartTwoSolution => 1877139;
}
