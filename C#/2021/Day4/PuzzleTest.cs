﻿using System.Collections.Generic;

using TestCommons;

namespace _2021.Day4;

public class PuzzleTest : SolverTest<Solver, (IEnumerable<int>, BingoGrid[]), int>
{
    private readonly int[] Drawn = new[]
    {
        07, 04, 09, 05, 11, 17, 23, 02, 00, 14,
        21, 24, 10, 16, 13, 06, 15, 25, 12, 22,
        18, 20, 08, 19, 03, 26, 01
    };

    private readonly BingoGrid[] Grids = new[]
    {
        new BingoGrid(new[]
        {
            new int[] { 22, 13, 17, 11,  0 },
            new int[] {  8,  2, 23,  4, 24 },
            new int[] { 21, 9, 14, 16, 7 },
            new int[] { 6, 10, 3, 18, 5 },
            new int[] { 1, 12, 20, 15, 19 },
        }),
        new BingoGrid(new[]
        {
            new int[] {  3, 15,  0,  2, 22 },
            new int[] {  9, 18, 13, 17,  5 },
            new int[] { 19,  8,  7, 25, 23 },
            new int[] { 20, 11, 10, 24,  4 },
            new int[] { 14, 21, 16, 12,  6 },
        }),

        new BingoGrid(new[]
        {
            new int[] { 14, 21, 17, 24,  4 },
            new int[] { 10, 16, 15,  9, 19 },
            new int[] { 18,  8, 23, 26, 20 },
            new int[] { 22, 11, 13,  6,  5 },
            new int[] {  2,  0, 12,  3,  7 },
        }),
    };

    protected override Example PartOne => new()
    {
        Input = (Drawn, Grids),
        Result = 4512,
    };

    protected override Example PartTwo => new()
    {
        Input = (Drawn, Grids),
        Result = 1924,
    };
}
