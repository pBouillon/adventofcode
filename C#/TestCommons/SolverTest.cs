using Commons;

using Xunit;

namespace TestCommons;

public abstract class SolverTest<TSolver, TInput, TResult>
    where TSolver : ISolver<TInput, TResult>, new()
{
    public record Example
    {
        public TInput Input { get; init; } = default!;

        public TResult Result { get; init; } = default!;
    }

    protected abstract Example PartOne { get; }

    protected abstract TResult PartOneSolution { get; }

    protected abstract Example PartTwo { get; }

    protected abstract TResult PartTwoSolution { get; }

    [Fact(DisplayName = "Part One - Example")]
    public void PartOneExampleTest()
    {
        var solver = new TSolver();
        var input = PartOne.Input;
        Assert.Equal(PartOne.Result, solver.PartOne(input));
    }

    [Fact(DisplayName = "Part One - Solution")]
    public void PartOneSolutionTest()
    {
        var solver = new TSolver();
        var input = solver.ReadInput(solver.InputPath);
        Assert.Equal(PartOneSolution, solver.PartOne(input));
    }

    [Fact(DisplayName = "Part Two - Example")]
    public void PartTwoExampleTest()
    {
        var solver = new TSolver();
        var input = PartTwo.Input;
        Assert.Equal(PartTwo.Result, solver.PartTwo(input));
    }

    [Fact(DisplayName = "Part Two - Solution")]
    public void PartTwoSolutionTest()
    {
        var solver = new TSolver();
        var input = solver.ReadInput(solver.InputPath);
        Assert.Equal(PartTwoSolution, solver.PartTwo(input));
    }
}
