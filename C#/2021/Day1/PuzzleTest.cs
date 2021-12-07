using TestCommons;

namespace _2021.Day1;

public class PuzzleTest : SolverTest<Solver, int[], int>
{
    private readonly int[] Measures = new[] { 199, 200, 208, 210, 200, 207, 240, 269, 260, 263 };

    protected override Example PartOne => new()
    {
        Input = Measures,
        Result = 7,
    };

    protected override Example PartTwo => new()
    {
        Input = Measures,
        Result = 5,
    };
}
