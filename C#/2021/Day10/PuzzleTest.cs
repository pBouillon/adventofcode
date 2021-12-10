using System.Collections.Generic;

using TestCommons;

namespace _2021.Day10;

public class PuzzleTest : SolverTest<Solver, IEnumerable<string>, long>
{
    private readonly IEnumerable<string> _input = new List<string>
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
        Input = _input,
        Result = 26397,
    };

    protected override long PartOneSolution => 243939;

    protected override Example PartTwo => new()
    {
        Input = _input,
        Result = 288957,
    };

    protected override long PartTwoSolution => 2421222841;
}
