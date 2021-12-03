﻿using Commons;

using System;
using System.IO;
using System.Linq;

namespace _2021.Day3;

public class Solver : ISolver<string[], int>
{
    public string InputPath
        => "Day3/input.txt";

    public int PartOne(string[] input)
    {
        var gamma = string.Empty;
        var epsilon = string.Empty;

        for (var i = 0; i < input[0].Length; ++i)
        {
            var zeroes = input
                .Select(row => row[i])
                .Count(value => value == '0');
        
            if (zeroes > input.Length / 2)
            {
                gamma += "0";
                epsilon += "1";
            }
            else
            {
                gamma += "1";
                epsilon += "0";
            }
        }

        return Convert.ToInt32(gamma, 2) * Convert.ToInt32(epsilon, 2);
    }

    public int PartTwo(string[] input)
    {
        var oxygen = PartTwoRecurs(true, input);
        var co2 = PartTwoRecurs(false, input);

        return Convert.ToInt32(oxygen, 2) * Convert.ToInt32(co2, 2);
    }

    private string PartTwoRecurs(bool searchOxygen, string[] input, int offset = 0)
    {
        if (input.Length == 1) return input[0];

        var zeroes = 0;
        foreach (var row in input)
        {
            if (row[offset] == '0') ++zeroes;
        }

        var mostCommon = zeroes > input.Length / 2 ? '0' : '1';
        var leastCommon = mostCommon == '0' ? '1' : '0';

        var symbol = searchOxygen ? mostCommon : leastCommon;

        var filtered = input
            .Where(row => row[offset] == symbol)
            .ToArray();

        return PartTwoRecurs(searchOxygen, filtered, ++offset);
    }

    public string[] ReadInput(string inputPath)
        => File.ReadLines(inputPath).ToArray();
}

