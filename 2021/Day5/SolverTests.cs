using Xunit;

namespace _2021.Day5;

public class SolverTests
{
    [Fact]
    public void PartOneExample()
    {
        var input = new[]
        {
            new Range(new Coordinate(0, 9), new Coordinate(5, 9)),
            new Range(new Coordinate(8, 0), new Coordinate(0, 8)),
            new Range(new Coordinate(9, 4), new Coordinate(3, 4)),
            new Range(new Coordinate(2, 2), new Coordinate(2, 1)),
            new Range(new Coordinate(7, 0), new Coordinate(7, 4)),
            new Range(new Coordinate(6, 4), new Coordinate(2, 0)),
            new Range(new Coordinate(0, 9), new Coordinate(2, 9)),
            new Range(new Coordinate(3, 4), new Coordinate(1, 4)),
            new Range(new Coordinate(0, 0), new Coordinate(8, 8)),
            new Range(new Coordinate(5, 5), new Coordinate(8, 2)),
        };

        var solver = new Solver();
        Assert.Equal(5, solver.PartOne(input));
    }

    [Fact]
    public void PartOne()
    {
        var solver = new Solver();
        var input = solver.ReadInput(solver.InputPath);
        Assert.Equal(6311, solver.PartOne(input));
    }

    [Fact]
    public void PartTwoExample()
    {
        var input = new[]
        {
            new Range(new Coordinate(0, 9), new Coordinate(5, 9)),
            new Range(new Coordinate(8, 0), new Coordinate(0, 8)),
            new Range(new Coordinate(9, 4), new Coordinate(3, 4)),
            new Range(new Coordinate(2, 2), new Coordinate(2, 1)),
            new Range(new Coordinate(7, 0), new Coordinate(7, 4)),
            new Range(new Coordinate(6, 4), new Coordinate(2, 0)),
            new Range(new Coordinate(0, 9), new Coordinate(2, 9)),
            new Range(new Coordinate(3, 4), new Coordinate(1, 4)),
            new Range(new Coordinate(0, 0), new Coordinate(8, 8)),
            new Range(new Coordinate(5, 5), new Coordinate(8, 2)),
        };

        var solver = new Solver();
        Assert.Equal(12, solver.PartTwo(input));
    }

    [Fact]
    public void PartTwo()
    {
        var solver = new Solver();
        var input = solver.ReadInput(solver.InputPath);
        Assert.Equal(19929, solver.PartTwo(input));
    }

}
