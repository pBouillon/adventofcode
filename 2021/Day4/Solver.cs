using Commons;

using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace _2021.Day4;

public class BingoGrid
{
    private readonly bool[][] _drawn = Enumerable
        .Range(0, 5)
        .Select(_ => new bool[5])
        .ToArray();

    private readonly int[][] _grid;

    public BingoGrid(int[][] grid)
        => _grid = grid;

    public void Check(int drawn)
    {
        for (int i = 0; i < _grid.Length; ++i)
        {
            for (int j = 0; j < _grid.Length; ++j)
            {
                var number = _grid[i][j];
                if (number == drawn) _drawn[i][j] = true;
            }
        }
    }
    
    public IEnumerable<int> RemainingNumbers()
    {
        var remainings = new List<int>();

        for (int i = 0; i < _drawn.Length; ++i)
        {
            for (int j = 0; j < _drawn.Length; ++j)
            {
                if (!_drawn[i][j]) remainings.Add(_grid[i][j]);
            }
        }

        return remainings;
    }

    public bool IsWinning()
    {
        if (_drawn.Any(row => row.All(drawn => drawn))) return true;

        for (int i = 0; i < _drawn.Length; ++i)
        {
            if (IsWinningColumn(i)) return true;
        }

        return false;
    }

    private bool IsWinningColumn(int column)
    {
        for (int i = 0; i < _drawn.Length; ++i)
        {
            if (!_drawn[i][column]) return false;
        }

        return true;
    }
}

public class Solver : ISolver<(IEnumerable<int>, BingoGrid[]), int>
{
    public string InputPath
        => "Day4/input.txt";

    public int PartOne((IEnumerable<int>, BingoGrid[]) input)
    {
        var (drawn, grids) = input;

        foreach (var number in drawn)
        {
            for (var i = 0; i < grids.Length; ++i)
            {
                grids[i].Check(number);
                if (grids[i].IsWinning())
                {
                    return grids[i].RemainingNumbers().Sum() * number;
                }
            }
        }
        
        return -1;
    }

    public int PartTwo((IEnumerable<int>, BingoGrid[]) input)
    {     
        var (drawn, grids) = input;

        var gridNotWonOffsets = Enumerable
            .Range(0, grids.Length)
            .ToList();

        foreach (var number in drawn)
        {
            for (var i = 0; i < grids.Length; ++i)
            {
                grids[i].Check(number);

                if (grids[i].IsWinning())
                {
                    gridNotWonOffsets.Remove(i);
                }

                if (!gridNotWonOffsets.Any())
                {
                    return grids[i].RemainingNumbers().Sum() * number;
                }
            }
        }

        return -1;
    }

    public (IEnumerable<int>, BingoGrid[]) ReadInput(string inputPath)
    {
        var raw = File
            .ReadLines(inputPath)
            .Where(line => !string.IsNullOrWhiteSpace(line))
            .ToList();

        var drawn = raw
            .First()
            .Split(",")
            .Select(draw => int.Parse(draw));

        var numbers = raw
            .Skip(1)
            .Select(line => Regex
                .Split(line.Trim(), @"\s+")
                .Select(number => int.Parse(number))
                .ToArray())
            .ToArray();

        var grids = Enumerable
            .Range(0, numbers.Length)
            .Where((x, i) => i % 5 == 0)
            .Select(offset => numbers[offset..(offset + 5)])
            .Select(grid => new BingoGrid(grid))
            .ToArray();

        return (drawn, grids);
    }
}
