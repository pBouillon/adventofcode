using Xunit;

namespace _2021.Day4;

public class SolverTests
{
    [Fact]
    public void PartOneExamples()
    {
        var drawn = new int[] { 7, 4, 9, 5, 11, 17, 23, 2, 0, 14, 21, 24, 10, 16, 13, 6, 15, 25, 12, 22, 18, 20, 8, 19, 3, 26, 1 };

        var grids = new BingoGrid[]
        {
            new BingoGrid(new[]
            {
                new int[] { 22, 13, 17, 11,  0 },
                new int[] {  8,  2, 23,  4, 24 },
                new int[] { 21,  9, 14, 16,  7 },
                new int[] {  6, 10,  3, 18,  5 },
                new int[] {  1, 12, 20, 15, 19 },
            }),
            new BingoGrid(new[]
            {
                new int[] {  3, 15,  0,  2, 22 },
                new int[] {  9, 18, 13, 17,  5 },
                new int[] { 19,  8,  7, 25, 23 },
                new int[] { 20, 11, 10, 24,  4 },
                new int[] { 14, 21, 16, 12,  6 },
            }),

            new BingoGrid(new[]
            {
                new int[] { 14, 21, 17, 24,  4 },
                new int[] { 10, 16, 15,  9, 19 },
                new int[] { 18,  8, 23, 26, 20 },
                new int[] { 22, 11, 13,  6,  5 },
                new int[] {  2,  0, 12,  3,  7 },
            }),
        };

        var solver = new Solver();
        Assert.Equal(4512, solver.PartOne((drawn, grids)));
    }

    [Fact]
    public void PartOne()
    {
        var solver = new Solver();
        var input = solver.ReadInput(solver.InputPath);
        Assert.Equal(63552, solver.PartOne(input));
    }

    [Fact]
    public void PartTwoExamples()
    {
        var drawn = new int[] { 7, 4, 9, 5, 11, 17, 23, 2, 0, 14, 21, 24, 10, 16, 13, 6, 15, 25, 12, 22, 18, 20, 8, 19, 3, 26, 1 };

        var grids = new BingoGrid[]
        {
            new BingoGrid(new[]
            {
                new int[] { 22, 13, 17, 11,  0 },
                new int[] {  8,  2, 23,  4, 24 },
                new int[] { 21,  9, 14, 16,  7 },
                new int[] {  6, 10,  3, 18,  5 },
                new int[] {  1, 12, 20, 15, 19 },
            }),
            new BingoGrid(new[]
            {
                new int[] {  3, 15,  0,  2, 22 },
                new int[] {  9, 18, 13, 17,  5 },
                new int[] { 19,  8,  7, 25, 23 },
                new int[] { 20, 11, 10, 24,  4 },
                new int[] { 14, 21, 16, 12,  6 },
            }),

            new BingoGrid(new[]
            {
                new int[] { 14, 21, 17, 24,  4 },
                new int[] { 10, 16, 15,  9, 19 },
                new int[] { 18,  8, 23, 26, 20 },
                new int[] { 22, 11, 13,  6,  5 },
                new int[] {  2,  0, 12,  3,  7 },
            }),
        };

        var solver = new Solver();
        Assert.Equal(1924, solver.PartTwo((drawn, grids)));
    }

    [Fact]
    public void PartTwo()
    {
        var solver = new Solver();
        var input = solver.ReadInput(solver.InputPath);
        Assert.Equal(9020, solver.PartTwo(input));
    }
}
