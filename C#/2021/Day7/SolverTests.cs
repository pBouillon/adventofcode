using System.Collections.Generic;

using Xunit;

namespace _2021.Day7;

public class SolverTests
{
    [Fact]
    public void PartOneExample()
    {
        var input = new List<int> { 16, 1, 2, 0, 4, 2, 7, 1, 2, 14 };
        var solver = new Solver();
        Assert.Equal(37, solver.PartOne(input));
    }

    [Fact]
    public void PartOne()
    {
        var solver = new Solver();
        var input = solver.ReadInput(solver.InputPath);
        Assert.Equal(347509, solver.PartOne(input));
    }

    [Fact]
    public void PartTwoExample()
    {
        var input = new List<int> { 16, 1, 2, 0, 4, 2, 7, 1, 2, 14 };
        var solver = new Solver();
        Assert.Equal(168, solver.PartTwo(input));
    }

    [Fact]
    public void PartTwo()
    {
        var solver = new Solver();
        var input = solver.ReadInput(solver.InputPath);
        Assert.Equal(98257206, solver.PartTwo(input));
    }
}

