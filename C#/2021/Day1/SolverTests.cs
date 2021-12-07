using _2021.Day5;

using Xunit;

namespace _2021.Day1;

public class SolverTests
{
    [Fact]
    public void PartOneExamples()
    {
        var solver = new Solver();
        var measures = new int[] { 199, 200, 208, 210, 200, 207, 240, 269, 260,263 };
        Assert.Equal(7, solver.PartOne(measures));
    }

    [Fact]
    private void PartOneSolution()
    {
        var solver = new Solver();
        var measures = solver.ReadInput(solver.InputPath);
        Assert.Equal(1696, solver.PartOne(measures));
    }

    [Fact]
    public void PartTwoExamples()
    {
        var solver = new Solver();
        var measures = new int[] { 199, 200, 208, 210, 200, 207, 240, 269, 260, 263 };
        Assert.Equal(5, solver.PartTwo(measures));
    }

    [Fact]
    private void PartTwoSolution()
    {
        var solver = new Solver();
        var measures = solver.ReadInput(solver.InputPath);
        Assert.Equal(1737, solver.PartTwo(measures));
    }
}
