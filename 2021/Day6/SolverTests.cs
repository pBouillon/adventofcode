using System.Collections.Generic;

using Xunit;

namespace _2021.Day6;

public class SolverTests
{
    [Fact]
    public void PartOneExample()
    {
        var solver = new Solver();

        var initialPopulation = new LanternFishPopulation(new List<LanternFish>
        {
            new LanternFish(3),
            new LanternFish(4),
            new LanternFish(3),
            new LanternFish(1),
            new LanternFish(2),
        });

        Assert.Equal(5934, solver.PartOne(initialPopulation));
    }

    [Fact]
    public void PartOne()
    {
        var solver = new Solver();
        var initialPopulation = solver.ReadInput(solver.InputPath);
        Assert.Equal(6311, solver.PartOne(initialPopulation));
    }
}

