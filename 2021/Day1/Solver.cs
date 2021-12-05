using Commons;

using System;
using System.IO;
using System.Linq;

namespace _2021.Day1;

public class Solver : ISolver<int[], int>
{

    public string InputPath
        => Path.Join(AppDomain.CurrentDomain.BaseDirectory, "Day1/input.txt");

    public int PartOne(int[] measures)
    {
        var count = 0;
        
        for (var i = 1; i < measures.Length; ++i)
        {
            if (measures[i - 1] < measures[i]) ++count;
        }

        return count;
    }

    public int PartTwo(int[] measures)
    {
        var windowSums = Enumerable.Range(0, measures.Length - 2)
            .Select(offset => measures[offset..(offset + 3)].Sum())
            .ToArray();

        return PartOne(windowSums);
    }

    public int[] ReadInput(string inputPath)
        => File
            .ReadLines(inputPath)
            .Select(measure => int.Parse(measure))
            .ToArray();
}
