using TestCommons;

namespace _2021.Day9;

public class PuzzleTest : SolverTest<Solver, int[][], long>
{
    protected override Example PartOne => new()
    {
        Input = new[]
        {
            new[] { 2, 1, 9, 9, 9, 4, 3, 2, 1, 0 },
            new[] { 3, 9, 8, 7, 8, 9, 4, 9, 2, 1 },
            new[] { 9, 8, 5, 6, 7, 8, 9, 8, 9, 2 },
            new[] { 8, 7, 6, 7, 8, 9, 6, 7, 8, 9 },
            new[] { 9, 8, 9, 9, 9, 6, 5, 6, 7, 8 },
        },
        Result = 15,
    };

    protected override long PartOneSolution => 591;

    protected override Example PartTwo => new()
    {
        Input = new[]
        {
            new[] { 2, 1, 9, 9, 9, 4, 3, 2, 1, 0 },
            new[] { 9, 8, 5, 6, 7, 8, 9, 8, 9, 2 },
            new[] { 8, 7, 6, 7, 8, 9, 6, 7, 8, 9 },
            new[] { 9, 8, 9, 9, 9, 6, 5, 6, 7, 8 },
        },
        Result = 0,
    };

    protected override long PartTwoSolution => 0;
}

