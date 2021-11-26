namespace Commons;

/// <summary>
/// Represent the solver for each day
/// </summary>
/// <typeparam name="TInput">The type of the data used to solve the puzzle</typeparam>
/// <typeparam name="TResult">The type of the result of the puzzle</typeparam>
public interface ISolver<TInput, TResult>
{
    string InputPath { get; }

    TInput ReadInput(string inputPath);

    TResult PartOne(TInput input);

    TResult PartTwo(TInput input);
}
