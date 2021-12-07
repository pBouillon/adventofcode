using Xunit;

namespace _2015.Day1;

public class SolverTests
{
    [Theory]
    [InlineData("()()", 0)]
    [InlineData("(())", 0)]
    [InlineData("(((", 3)]
    [InlineData("(()(()(", 3)]
    [InlineData("())", -1)]
    [InlineData("))(", -1)]
    [InlineData(")))", -3)]
    [InlineData(")())())", -3)]
    public void PartOneExamples(string floors, int expected)
    {
        var solver = new Solver();
        Assert.Equal(expected, solver.PartOne(floors));
    }

    [Fact]
    private void PartOneSolution()
    {
        var solver = new Solver();
        var floors = solver.ReadInput(solver.InputPath);
        Assert.Equal(138, solver.PartOne(floors));
    }

    [Theory]
    [InlineData(")", 1)]
    [InlineData("()())", 5)]
    public void PartTwoExamples(string floors, int expected)
    {
        var solver = new Solver();
        Assert.Equal(expected, solver.PartTwo(floors));
    }

    [Fact]
    private void PartTwoSolution()
    {
        var solver = new Solver();
        var floors = solver.ReadInput(solver.InputPath);
        Assert.Equal(1771, solver.PartTwo(floors));
    }
}

