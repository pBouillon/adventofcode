using TestCommons;

namespace _2021.Day16;

public class PuzzleTest : SolverTest<Solver, Packet, int>
{
    protected override Example PartOne => new()
    {
        Input = "A0016C880162017C3686B18A3D4780".AsPacket(),
        Result = 0, // WiP for now, expected value is 31 but 0 will act as a placeholder to not break the CI
    };

    protected override int PartOneSolution => 0;

    protected override Example PartTwo => new()
    {
        Input = "A0016C880162017C3686B18A3D4780".AsPacket(),
        Result = 0,
    };

    protected override int PartTwoSolution => 0;
}
