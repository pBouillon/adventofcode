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

    protected abstract Example PartTwo { get; }

    [Fact]
    public void PartOneExampleTest()
    {
        var solver = new TSolver();
        var input = PartOne.Input;
        Assert.Equal(PartOne.Result, solver.PartOne(input));
    }

    [Fact]
    public void PartTwoExampleTest()
    {
        var solver = new TSolver();
        var input = PartTwo.Input;
        Assert.Equal(PartTwo.Result, solver.PartTwo(input));
    }
}
