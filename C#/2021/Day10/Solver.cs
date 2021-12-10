using Commons;

using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _2021.Day10;

public class Solver : ISolver<IEnumerable<string>, int>
{
    public string InputPath => "Day10/input.txt";

    private char? GetCorruptingChar(string line)
    {
        var closingSymbols = new Dictionary<char, char>()
        {
            ['('] = ')',
            ['{'] = '}',
            ['['] = ']',
            ['<'] = '>',
        };

        var symbols = new Stack<char>();
        foreach (var @char in line)
        {
            if (closingSymbols.ContainsKey(@char))
            {
                symbols.Push(@char);
                continue;
            }

            var expectedClosing = closingSymbols[symbols.Pop()];
            if (closingSymbols.Values.Contains(@char) && expectedClosing != @char)
            {
                return @char;
            }
        }

        return null;
    }

    public IEnumerable<char> GetAutocompletionFor(string line)
    {
        var closingSymbols = new Dictionary<char, char>()
        {
            ['('] = ')',
            ['{'] = '}',
            ['['] = ']',
            ['<'] = '>',
        };

        var symbols = new Stack<char>();
        foreach (var @char in line)
        {
            if (closingSymbols.ContainsKey(@char))
            {
                symbols.Push(@char);
                continue;
            }

            symbols.Pop();
        }

        var autocompletion = new Queue<char>();
        foreach (var remaining in symbols)
        {
            autocompletion.Enqueue(closingSymbols[remaining]);
        }
        return autocompletion;
    }

    public int PartOne(IEnumerable<string> input)
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

    public int PartTwo(IEnumerable<string> input)
    {
        var scores = input
            .Where(line => GetCorruptingChar(line) is null)
            .Select(incomplete => GetAutocompletionFor(incomplete))
            .Select(autocompletion => autocompletion.Aggregate(
                0,
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
