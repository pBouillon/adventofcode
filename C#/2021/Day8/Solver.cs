using Commons;

using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _2021.Day8;

public record Entry(IEnumerable<string> SignalPatterns, IEnumerable<string> OutputValueDigits);

public class Solver : ISolver<IEnumerable<Entry>, int>
{
    public string InputPath => "Day8/input.txt";

    public int PartOne(IEnumerable<Entry> input)
        => input
            .Select(entry => entry.OutputValueDigits)
            .Sum(digits => digits
                .Count(digit => new int[] { 2, 4, 3, 7 }
                .Contains(digit.Distinct().Count())));

    public int PartTwo(IEnumerable<Entry> input)
    {
        throw new System.NotImplementedException();
    }

    public IEnumerable<Entry> ReadInput(string inputPath)
        => File
            .ReadLines(inputPath)
            .Select(line =>
            {
                var parts = line.Split(" | ");
                return new Entry(parts[0].Split(" "), parts[1].Split(" "));
            });
}
