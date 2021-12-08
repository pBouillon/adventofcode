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
        => input
            .Select(entry =>
            {
                var sortedSignals = entry.SignalPatterns
                    .Select(digit => string.Join(string.Empty, digit.OrderBy(x => x)));

                var symbol = GetSymbolsTable(sortedSignals);

                return entry.OutputValueDigits
                    .Select(digit => string.Join(string.Empty, digit.OrderBy(x => x)))
                    .Aggregate(
                        string.Empty,
                        (current, next) => current + symbol[next]);
            })
            .Sum(int.Parse);

    private static Dictionary<string, string> GetSymbolsTable(IEnumerable<string> signalPatterns)
    {
        var uniqueSymbolSegmentsCount = new Dictionary<string, int>
        {
            { "1", 2 },
            { "4", 4 },
            { "7", 3 },
            { "8", 7 },
        };

        var symbols = uniqueSymbolSegmentsCount.ToDictionary(
            kvp => kvp.Key,
            kvp => signalPatterns.Single(pattern => pattern.Length == kvp.Value));

        // 6 digits symbols (0, 6, 9)
        var sixDigitsSymbols = signalPatterns
            .Where(signalPatterns => signalPatterns.Length == 6)
            .ToList();

        // '6' is the only digit made of 6 segments that does not contains all of the segments of '7'
        symbols["6"] = sixDigitsSymbols.Single(candidate => !symbols["7"]
            .All(segments => candidate.Contains(segments)));

        sixDigitsSymbols.Remove(symbols["6"]);

        // 5 digits symbols (2, 3, 5)
        var fiveDigitsSymbols = signalPatterns
            .Where(signalPatterns => signalPatterns.Length == 5)
            .ToList();

        // '3' is the only digit made of 5 segments and containing all of the segments of '1'
        symbols["3"] = fiveDigitsSymbols.Single(candidate => symbols["1"].ToCharArray()
            .All(segment => candidate.Contains(segment)));

        fiveDigitsSymbols.Remove(symbols["3"]);

        // '9' is the only remaining digit made of 6 segments that contains all the segments of '3'
        symbols["9"] = sixDigitsSymbols.Single(candidate => symbols["3"]
            .All(digit => candidate.Contains(digit)));

        sixDigitsSymbols.Remove(symbols["9"]);

        // '0' is the only remaining digit of 6 segments
        symbols["0"] = sixDigitsSymbols.Single();

        // '5' is the only digit made of 5 segments distinct from '6' by only one segment
        symbols["5"] = fiveDigitsSymbols.Single(candidate => symbols["6"]
        .Count(segment => !candidate.Contains(segment)) == 1);

        fiveDigitsSymbols.Remove(symbols["5"]);

        // '2' is the only remaining digit of 5 segments
        symbols["2"] = fiveDigitsSymbols.Single();

        // Invert the map to return a decoder as: "segments" => "digit"
        return symbols.ToDictionary(
            kvp => kvp.Value,
            kvp => kvp.Key); ;
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
