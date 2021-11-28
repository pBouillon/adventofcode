using Xunit;

namespace _2015.Day3;

public class SolverTests
{
    [Theory]
    [InlineData(">", 2)]
    [InlineData("^>v<", 4)]
    [InlineData("^v^v^v^v^v", 2)]
    public void PartOneExamples(string moves, int expected)
    {
        var solver = new Solver();
        Assert.Equal(expected, solver.PartOne(moves));
    }

    [Fact]
    private void PartOneSolution()
    {
        var solver = new Solver();
        var moves = solver.ReadInput(solver.InputPath);
        Assert.Equal(2565, solver.PartOne(moves));
    }

    [Theory]
    [InlineData(">v", 3)]
    [InlineData("^>v<", 3)]
    [InlineData("^v^v^v^v^v", 11)]
    public void PartTwoExamples(string moves, int expected)
    {
        var solver = new Solver();
        Assert.Equal(expected, solver.PartTwo(moves));
    }

    [Fact]
    private void PartTwoSolution()
    {
        var solver = new Solver();
        var moves = solver.ReadInput(solver.InputPath);
        Assert.Equal(2639, solver.PartTwo(moves));
    }
}
