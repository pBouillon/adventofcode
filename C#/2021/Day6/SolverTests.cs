using System.Collections.Generic;

using Xunit;

namespace _2021.Day6;

public class SolverTests
{
    [Fact]
    public void PartOneExample()
    {
        var solver = new Solver();

        var initialPopulation = new Dictionary<int, long>
        {
            { 1, 1 },
            { 2, 1 },
            { 3, 2 },
            { 4, 1 }
        };

        Assert.Equal(5934, solver.PartOne(initialPopulation));
    }

    [Fact]
    public void PartOne()
    {
        var solver = new Solver();
        var initialPopulation = solver.ReadInput(solver.InputPath);
        Assert.Equal(352872, solver.PartOne(initialPopulation));
    }

    [Fact]
    public void PartTwoExample()
    {
        var solver = new Solver();

        var initialPopulation = new Dictionary<int, long>
        {
            { 1, 1 },
            { 2, 1 },
            { 3, 2 },
            { 4, 1 }
        };

        Assert.Equal(26984457539, solver.PartTwo(initialPopulation));
    }

    [Fact]
    public void PartTwo()
    {
        var solver = new Solver();
        var initialPopulation = solver.ReadInput(solver.InputPath);
        Assert.Equal(1604361182149, solver.PartTwo(initialPopulation));
    }
}

