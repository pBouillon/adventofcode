using Commons;

using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _2021.Day9;

public class Solver : ISolver<int[][], long>
{
    public string InputPath => "Day9/input.txt";

    private static bool IsLowPointCoordinate(int i, int j, int[][] grid)
    {
        var current = grid[i][j];
        var neighbords = new Queue<int>();

        // Top neighbor
        if (i - 1 > -1) neighbords.Enqueue(grid[i - 1][j]);

        // Down neighbor
        if (i + 1 < grid.Length) neighbords.Enqueue(grid[i + 1][j]);

        // Left neighbor
        if (j - 1 > -1) neighbords.Enqueue(grid[i][j - 1]);

        // Right neighbor
        if (j + 1 < grid[i].Length) neighbords.Enqueue(grid[i][j + 1]);

        return neighbords.All(neighbor => current < neighbor);
    }

    public long PartOne(int[][] input)
    {
        var lowestPoints = new Queue<int>();

        for (var i = 0; i < input.Length; ++i)
        {
            for (var j = 0; j < input[i].Length; ++j)
            {
                if (IsLowPointCoordinate(i, j, input)) lowestPoints.Enqueue(input[i][j]);
            }
        }

        return lowestPoints.Sum(value => value + 1);
    }

    public long PartTwo(int[][] input)
    {
        return 0;
    }

    public int[][] ReadInput(string inputPath)
        => File
            .ReadLines(inputPath)
            .Select(line => line.Select(value => value.ToString())
                .Select(int.Parse)
                .ToArray())
            .ToArray();
}
