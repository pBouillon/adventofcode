using System;
using System.IO;
using System.Linq;
using Commons;

namespace _2015.Day01;

public class Solver : ISolver<string, int>
{
    public string InputPath => "Day01/input.txt";

    public int PartOne(string input)
        => PartOneRecursive(input, 0);
    
    private static int PartOneRecursive(string floors, int current = 0)
    {
        if (floors.Length == 0) return current;

        var head = floors[0];
        var tail = floors[1..];

        return head switch
        {
            '(' => PartOneRecursive(tail, ++current),
            ')' => PartOneRecursive(tail, --current),
            _ => throw new System.Exception($"Unexpected symbol '{head}'")
        };
    }

    public int PartTwo(string input)
        => PartTwoRecursive(input, 0, 0);

    private static int PartTwoRecursive(string floors, int current = 0, int position = 0)
    {
        if (current == -1) return position;

        var head = floors[0];
        var tail = floors[1..];

        return head switch
        {
            '(' => PartTwoRecursive(tail, ++current, ++position),
            ')' => PartTwoRecursive(tail, --current, ++position),
            _ => throw new System.Exception($"Unexpected symbol '{head}'")
        };
    }

    public string ReadInput(string inputPath)
        => File.ReadLines(inputPath).FirstOrDefault() ?? String.Empty;
}
