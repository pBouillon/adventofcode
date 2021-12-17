using Commons;

using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _2021.Day15;

public record Coordinate(int X, int Y)
{
    public IEnumerable<Coordinate> GetNeighbors()
        => new[]
        {
            new Coordinate(X - 1, Y),
            new Coordinate(X + 1, Y),
            new Coordinate(X, Y - 1),
            new Coordinate(X, Y + 1),
        };
}

public class Solver : ISolver<int[][], long>
{
    public string InputPath => "Day15/input.txt";

    public static int[][] GetExtendedMap(int[][] map, int magnitude = 5)
    {
        // Scale up the map
        var extendedMap = new int[map.Length * magnitude][];

        for (var x = 0; x < extendedMap.Length; ++x)
        {
            extendedMap[x] = new int[map.Length * magnitude];
        }

        // Populate its values
        for (var x = 0; x < extendedMap.Length; ++x)
        {
            for (var y = 0; y < extendedMap[x].Length; ++y)
            {
                var seed = map[x % map.Length][y % map.Length];
                var distanceFromSeed = x / map.Length + y / map.Length;
             
                extendedMap[x][y] = (seed + distanceFromSeed - 1) % 9 + 1;
            }
        }

        return extendedMap;
    }

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

        while (visited.Count != cost.Count)
        {
            var current = cost
                .Where(edge => !visited.Contains(edge.Key))
                .MinBy(edge => edge.Value)
                .Key;

            visited.Add(current);

            current.GetNeighbors()
                .Where(neighbor => cost.ContainsKey(neighbor)
                    && cost[neighbor] > cost[current] + map[neighbor.X][neighbor.Y])
                .ToList()
                .ForEach(neighbor => cost[neighbor] = cost[current] + map[neighbor.X][neighbor.Y]);
        }

        // Compute the shortest path
        return cost[target];
    }

    public long PartOne(int[][] map)
    {
        var start = new Coordinate(0, 0);
        var goal = new Coordinate(map.Length - 1, map.Length - 1);

        return GetShortestPathCost(map, start, goal);
    }

    public long PartTwo(int[][] map)
    {
        // Multiply the map in X and Y
        var extended= GetExtendedMap(map);

        var start = new Coordinate(0, 0);
        var goal = new Coordinate(extended.Length - 1, extended.Length - 1);

        // Compute the shortest path
        return GetShortestPathCost(extended, start, goal);
    }

    public int[][] ReadInput(string inputPath)
        => File
            .ReadLines(inputPath)
            .Select(line => line.Select(x => x - '0').ToArray())
            .ToArray();
}
