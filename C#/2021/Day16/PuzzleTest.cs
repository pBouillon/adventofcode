using TestCommons;

namespace _2021.Day16;

public class PuzzleTest : SolverTest<Solver, Packet, int>
{
    protected override Example PartOne => new()
    {
        Input = "A0016C880162017C3686B18A3D4780".AsPacket(),
        Result = 31,
    };

    protected override int PartOneSolution => 0;

    protected override Example PartTwo => throw new System.NotImplementedException();

    protected override int PartTwoSolution => 0;
}
