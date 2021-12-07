
using Xunit;

namespace _2015.Day4;

public class SolverTests
{
    [Theory]
    [InlineData("abcdef", 609043)]
    [InlineData("pqrstuv", 1048970)]
    public void PartOneExamples(string floors, int expected)
    {
        var solver = new Solver();
        Assert.Equal(expected, solver.PartOne(floors));
    }

    [Fact]
    private void PartOneSolution()
    {
        var solver = new Solver();
        var secret = solver.ReadInput(solver.InputPath);
        Assert.Equal(254575, solver.PartOne(secret));
    }

    [Fact]
    private void PartTwoSolution()
    {
        var solver = new Solver();
        var secret = solver.ReadInput(solver.InputPath);
        Assert.Equal(1038736, solver.PartTwo(secret));
    }
}

