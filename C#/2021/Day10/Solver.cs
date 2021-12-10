using Commons;

using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _2021.Day10;

public class Solver : ISolver<IEnumerable<string>, long>
{
    public string InputPath => "Day10/input.txt";

    private readonly IDictionary<char, char> _closingSymbols = new Dictionary<char, char>
    {
        ['('] = ')',
        ['{'] = '}',
        ['['] = ']',
        ['<'] = '>',
    };

    private char? GetCorruptingChar(string line)
    {
        var symbols = new Stack<char>();
        foreach (var @char in line)
        {
            if (_closingSymbols.ContainsKey(@char))
            {
                symbols.Push(@char);
                continue;
            }

            var expectedClosing = _closingSymbols[symbols.Pop()];
            if (_closingSymbols.Values.Contains(@char) && expectedClosing != @char)
            {
                return @char;
            }
        }

        return null;
    }

    public IEnumerable<char> GetAutocompleteFor(string line)
    {
        var symbols = new Stack<char>();
        foreach (var @char in line)
        {
            if (_closingSymbols.ContainsKey(@char))
            {
                symbols.Push(@char);
                continue;
            }

            symbols.Pop();
        }

        var autocomplete = new Queue<char>();
        foreach (var remaining in symbols)
        {
            autocomplete.Enqueue(_closingSymbols[remaining]);
        }
        return autocomplete;
    }

    public long PartOne(IEnumerable<string> input)
    {
        return input
            .Select(GetCorruptingChar)
            .Sum(corruptingChar => corruptingChar switch
            {
                ')' => 3,
                ']' => 57,
                '}' => 1197,
                '>' => 25137,
                _ => 0,
            });
    }

    public long PartTwo(IEnumerable<string> input)
    {
        var scores = input
            .Where(line => GetCorruptingChar(line) is null)
            .Select(GetAutocompleteFor)
            .Select(autocomplete => autocomplete.Aggregate(
                0L,
                (score, @char) => 5 * score + @char switch
                {
                    ')' => 1,
                    ']' => 2,
                    '}' => 3,
                    '>' => 4,
                    _ => 0,
                })
            )
            .OrderBy(score => score)
            .ToArray();

        return scores[scores.Length / 2];
    }

    public IEnumerable<string> ReadInput(string inputPath)
        => File.ReadLines(inputPath);
}
