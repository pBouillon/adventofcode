﻿using System.Collections.Generic;

using TestCommons;

namespace _2021.Day13;

public class PuzzleTest : SolverTest<Solver, (ISet<Coordinate>, IEnumerable<FoldingInstruction>), string>
{
    private readonly ISet<Coordinate> _points = new HashSet<Coordinate>
    {
        new(6, 10),
        new(0, 14),
        new(9, 10),
        new(0, 3),
        new(10, 4),
        new(4, 11),
        new(6, 0),
        new(6, 12),
        new(4, 1),
        new(0, 13),
        new(10, 12),
        new(3, 4),
        new(3, 0),
        new(8, 4),
        new(1, 10),
        new(2, 14),
        new(8, 10),
        new(9, 0),
    };

    private readonly IEnumerable<FoldingInstruction> _instructions = new List<FoldingInstruction>
    {
        new(Axis.Y, 7),
        new(Axis.X, 5),
    };

    protected override Example PartOne => new()
    {
        Input = (_points, _instructions),
        Result = "17",
    };

    protected override string PartOneSolution => "666";

    protected override Example PartTwo => new()
    {
        Input = (_points, _instructions),
        Result = string.Empty,
    };

    protected override string PartTwoSolution => "CJHAZHKU";
}
