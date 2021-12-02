using Xunit;

namespace _2021.Day2;

public class SolverTests
{
    [Fact]
    public void PartOneExamples()
    {
        var solver = new Solver();
        var commands = new Command[] 
        {
            new Command("forward", 5),
            new Command("down", 5),
            new Command("forward", 8),
            new Command("up", 3),
            new Command("down", 8),
            new Command("forward", 2),
        };
        Assert.Equal(150, solver.PartOne(commands));
    }

    [Fact]
    private void PartOneSolution()
    {
        var solver = new Solver();
        var commands = solver.ReadInput(solver.InputPath);
        Assert.Equal(1728414, solver.PartOne(commands));
    }

    [Fact]
    public void PartTwoExamples()
    {
        var solver = new Solver();
        var commands = new Command[]
        {
            new Command("forward", 5),
            new Command("down", 5),
            new Command("forward", 8),
            new Command("up", 3),
            new Command("down", 8),
            new Command("forward", 2),
        };
        Assert.Equal(900, solver.PartTwo(commands));
    }

    [Fact]
    private void PartTwoSolution()
    {
        var solver = new Solver();
        var commands = solver.ReadInput(solver.InputPath);
        Assert.Equal(1765720035, solver.PartTwo(commands));
    }
}
