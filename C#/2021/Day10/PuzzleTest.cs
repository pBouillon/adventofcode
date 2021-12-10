using System.Collections.Generic;

using TestCommons;

namespace _2021.Day10;

public class PuzzleTest : SolverTest<Solver, IEnumerable<string>, int>
{
    private readonly IEnumerable<string> input = new List<string>
    {
        "[({(<(())[]>[[{[]{<()<>>",
        "[(()[<>])]({[<{<<[]>>(",
        "{([(<{}[<>[]}>{[]{[(<()>",
        "(((({<>}<{<{<>}{[]{[]{}",
        "[[<[([]))<([[{}[[()]]]",
        "[{[{({}]{}}([{[{{{}}([]",
        "{<[[]]>}<{[{[{[]{()[[[]",
        "[<(<(<(<{}))><([]([]()",
        "<{([([[(<>()){}]>(<<{{",
        "<{([{{}}[<[[[<>{}]]]>[]]"
    };

    protected override Example PartOne => new()
    {
        Input = input,
        Result = 26397,
    };

    protected override int PartOneSolution => 243939;

    protected override Example PartTwo => new()
    {
        Input = input,
        Result = 0,
    };

    protected override int PartTwoSolution => 0;
}
