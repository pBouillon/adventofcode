using Commons;

using System;
using System.IO;
using System.Linq;

namespace _2021.Day16;

public static class PacketHelpers
{
    public static Packet AsPacket(this string transmission) => new(string.Join(
            string.Empty,
            transmission.Select(@char =>
                Convert.ToString(
                    Convert.ToInt32(@char.ToString(), 16), 2)
                .PadLeft(4, '0'))));
}

public record Packet(string Transmission)
{
    public int Version => Convert.ToInt32(string.Join(string.Empty, Transmission.Take(3)), 2);

    public int Id => Convert.ToInt32(string.Join(string.Empty, Transmission.Skip(3).Take(3)), 2);

    public int LengthType => Convert.ToInt32(Transmission.Skip(6).First().ToString(), 2);

    public bool IsOperator => Id != 4;
}

public class Solver : ISolver<Packet, int>
{
    public string InputPath => "Day16/input.txt";

    
    public int PartOne(Packet packet)
    {
        return 0;
    }

    public int PartTwo(Packet packet)
    {
        return 0;
    }

    public Packet ReadInput(string inputPath)
        => File.ReadLines(inputPath).First().AsPacket();
}
