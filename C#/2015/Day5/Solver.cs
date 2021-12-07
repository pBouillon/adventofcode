using Commons;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _2015.Day5;

public class Solver : ISolver<IEnumerable<string>, int>
{
    public string InputPath
        => "Day5/input.txt";

    private static bool ContainsAtLeastThreeVoyels(string @string)
        => @string.Count("aeiou".Contains) > 2;

    private static bool ContainsAnyConsecutiveLetter(string @string)
        => Enumerable
            .Range(0, @string.Length - 1)
            .Any(offset => @string[offset] == @string[offset + 1]);

    private static bool ContainsAnyForbiddenString(string @string)
        => new string[] { "ab", "cd", "pq", "xy" }.Any(@string.Contains);

    private static bool ContainsAnyLetterSeparatedByAnother(string @string)
        => Enumerable
            .Range(0, @string.Length - 2)
            .Any(offset => @string[offset] == @string[offset + 2]);

    private static bool ContainsAnyRepeatingSequence(string @string)
        => Enumerable
            .Range(0, @string.Length - 2)
            .Any(offset => @string.IndexOf(@string.Substring(offset, 2), offset + 2) > -1);

    public int PartOne(IEnumerable<string> input)
        => input.Count(@string =>
            ContainsAtLeastThreeVoyels(@string)
            && ContainsAnyConsecutiveLetter(@string)
            && !ContainsAnyForbiddenString(@string));

    public int PartTwo(IEnumerable<string> input)
         => input.Count(@string =>
            ContainsAnyLetterSeparatedByAnother(@string)
            && ContainsAnyRepeatingSequence(@string));

    public IEnumerable<string> ReadInput(string inputPath)
        => File.ReadLines(inputPath);
}
