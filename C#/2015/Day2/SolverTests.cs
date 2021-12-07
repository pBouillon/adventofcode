using Xunit;

namespace _2015.Day2;

public class SolverTests
{
    [Fact]
    public void PartOneFirstExample()
    {
        var solver = new Solver();
        var dimensions = new[] { new Dimension(2, 3, 4) };

        Assert.Equal(58, solver.PartOne(dimensions));
    }

    [Fact]
    public void PartOneSecondExample()
    {
        var solver = new Solver();
        var dimensions = new[] { new Dimension(1, 1, 10) };

        Assert.Equal(43, solver.PartOne(dimensions));
    }

    [Fact]
    private void PartOneSolution()
    {
        var solver = new Solver();
        var dimensions = solver.ReadInput(solver.InputPath);

        Assert.Equal(1586300, solver.PartOne(dimensions));
    }

    [Fact]
    public void PartTwoFirstExample()
    {
        var solver = new Solver();
        var dimensions = new[] { new Dimension(2, 3, 4) };

        Assert.Equal(34, solver.PartTwo(dimensions));
    }

    [Fact]
    public void PartTwoSecondExample()
    {
        var solver = new Solver();
        var dimensions = new[] { new Dimension(1, 1, 10) };

        Assert.Equal(14, solver.PartTwo(dimensions));
    }

    [Fact]
    private void PartTwoSolution()
    {
        var solver = new Solver();
        var dimensions = solver.ReadInput(solver.InputPath);

        Assert.Equal(3737498, solver.PartTwo(dimensions));
    }
}
