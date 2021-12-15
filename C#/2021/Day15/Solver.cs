using Commons;

using System.IO;
using System.Linq;

namespace _2021.Day15;

public class Solver : ISolver<int[][], long>
{
    public string InputPath => "Day15/input.txt";

    public long PartOne(int[][] input)
    {
        return 0;
    }

    public long PartTwo(int[][] input)
    {
        return 0;
    }

    public int[][] ReadInput(string inputPath)
        => File
            .ReadLines(inputPath)
            .Select(line => line.Select(x => x - '0').ToArray())
            .ToArray();
}
