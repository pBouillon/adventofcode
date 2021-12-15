using Commons;

using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;

namespace _2021.Day15;

public record Coordinate(int X, int Y)
{
    public IEnumerable<Coordinate> GetNeighbors()
        => from i in new[] { -1, 0, 1 }
           from j in new[] { -1, 0, 1 }
           where i != 0 || j != 0
           select new Coordinate(X + i, Y + j);
}

public class Solver : ISolver<int[][], long>
{
    public string InputPath => "Day15/input.txt";

    private static long GetShortestPathCost(int[][] map, Coordinate source, Coordinate target)
    {
        // Initialize the costs map
        var cost = new Dictionary<Coordinate, long>();

        for (var x = 0; x < map.Length; ++x)
        {
            for (var y = 0; y < map[x].Length; ++y)
            {
                cost[new Coordinate(x, y)] = long.MaxValue;
            }
        }

        cost[source] = 0;

        // Compute the shortest distance between nodes
        var visited = new HashSet<Coordinate>();
        var predecessor = new Dictionary<Coordinate, Coordinate>();

        while (visited.Count != cost.Count)
        {
            var current = cost
                .Where(edge => !visited.Contains(edge.Key))
                .MinBy(edge => edge.Value)
                .Key;

            visited.Add(current);

            current.GetNeighbors()
                .Where(neighbor => cost.ContainsKey(neighbor)
                    && cost[neighbor] > cost[current])
                .ToList()
                .ForEach(neighbor =>
                {
                    cost[neighbor] = cost[current] + map[current.X][current.Y];
                    predecessor[neighbor] = current;
                });
        }

        // Compute the shortest path
        return cost[target];
    }

    public long PartOne(int[][] input)
    {
        var start = new Coordinate(0, 0);
        var goal = new Coordinate(input.Length - 1, input.Length - 1);

        return GetShortestPathCost(input, start, goal);
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
