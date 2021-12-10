using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Commons;

namespace _2015.Day04;

public class Solver : ISolver<string, int>
{
    private readonly HashAlgorithm _md5 = (HashAlgorithm) CryptoConfig.CreateFromName("MD5")!;

    public string InputPath
        => "Day04/input.txt";

    // From: https://stackoverflow.com/a/11477466/6152689
    private string GetHash(string input)
    {
        // byte array representation of that string
        var encoded = new UTF8Encoding().GetBytes(input);

        // need MD5 to calculate the hash
        var hash = _md5.ComputeHash(encoded);

        // string representation (similar to UNIX format)
        return BitConverter.ToString(hash)
           // without dashes
           .Replace("-", string.Empty);
    }

    public int PartOne(string input)
    {
        int i;
        for (i = 0; GetHash($"{input}{i}")[..5] != "00000"; ++i) { }
        return i;
    }

    public int PartTwo(string input)
    {
        int i;
        for (i = 0; GetHash($"{input}{i}")[..6] != "000000"; ++i) { }
        return i;
    }

    public string ReadInput(string inputPath)
        => File
            .ReadLines(inputPath)
            .First();
}
