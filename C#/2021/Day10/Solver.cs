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
        throw new System.NotImplementedException();
    }

    public IEnumerable<string> ReadInput(string inputPath)
        => File.ReadLines(inputPath);
}
