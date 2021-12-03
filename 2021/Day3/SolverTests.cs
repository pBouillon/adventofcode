using Xunit;

namespace _2021.Day3;

public class SolverTests
{
    [Fact]
    public void PartOneExamples()
    {
        var solver = new Solver();
        var measures = new string[]
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
        Assert.Equal(198, solver.PartOne(measures));
    }

    [Fact]
    private void PartOneSolution()
    {
        var solver = new Solver();
        var measures = solver.ReadInput(solver.InputPath);
        Assert.Equal(2003336, solver.PartOne(measures));
    }

    [Fact]
    public void PartTwoExamples()
    {
        var solver = new Solver();
        var measures = new string[]
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
        Assert.Equal(230, solver.PartTwo(measures));
    }

    [Fact]
    private void PartTwoSolution()
    {
        var solver = new Solver();
        var measures = solver.ReadInput(solver.InputPath);
        Assert.Equal(1877139, solver.PartTwo(measures));
    }
}
