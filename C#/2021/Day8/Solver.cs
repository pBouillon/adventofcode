using Commons;

using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _2021.Day8;

public record Digit(string Value, char[] Components);

public record Entry(IEnumerable<string> SignalPatterns, IEnumerable<string> OutputValueDigits);

public class Solver : ISolver<IEnumerable<Entry>, int>
{
    public string InputPath => "Day8/input.txt";

    private readonly Dictionary<int, Digit> Digits = new Dictionary<int, Digit>
    {
        { 0, new Digit("0", new[] { 'a', 'b', 'c',      'e', 'f', 'g' })},  // 6 segments
        { 1, new Digit("1", new[] {           'c',           'f'      })},  // 2 segments <- unique
        { 2, new Digit("2", new[] { 'a',      'c', 'd', 'e',      'g' })},  // 5 segments
        { 3, new Digit("3", new[] { 'a',      'c', 'd',      'f', 'g' })},  // 5 segments
        { 4, new Digit("4", new[] {      'b', 'c', 'd',      'f'      })},  // 4 segments <- unique
        { 5, new Digit("5", new[] { 'a', 'b',      'd',      'f', 'g' })},  // 5 segments
        { 6, new Digit("6", new[] { 'a', 'b',      'd', 'e', 'f', 'g' })},  // 6 segments
        { 7, new Digit("7", new[] { 'a',      'c',           'f'      })},  // 3 segments <- unique
        { 8, new Digit("8", new[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g' })},  // 7 segments <- unique
        { 9, new Digit("9", new[] { 'a', 'b', 'c', 'd',      'f', 'g' })},  // 6 segments
    };

    public int PartOne(IEnumerable<Entry> input)
        => input
            .Select(entry => entry.OutputValueDigits)
            .Sum(digits => digits.Count(digit => new List<int>()
                {
                    Digits[1].Components.Length,
                    Digits[4].Components.Length,
                    Digits[7].Components.Length,
                    Digits[8].Components.Length,
                }
                .Contains(digit.Distinct().Count())));
    //.Count(digits => new List<int>()
    //    {
    //        Digits[1].Components.Length,
    //        Digits[4].Components.Length,
    //        Digits[7].Components.Length,
    //        Digits[8].Components.Length,
    //    }
    //    .Contains(digits.Distinct().Count()));

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
