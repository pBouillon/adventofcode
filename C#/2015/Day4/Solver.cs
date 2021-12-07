using Commons;

using System.IO;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace _2015.Day4;

public class Solver : ISolver<string, int>
{
    private HashAlgorithm MD5 = (HashAlgorithm) CryptoConfig.CreateFromName("MD5")!;

    public string InputPath
        => Path.Join(AppDomain.CurrentDomain.BaseDirectory, "Day4/input.txt");

    // From: https://stackoverflow.com/a/11477466/6152689
    private string GetHash(string input)
    {
        // byte array representation of that string
        byte[] encoded = new UTF8Encoding().GetBytes(input);

        // need MD5 to calculate the hash
        byte[] hash = MD5.ComputeHash(encoded);

        // string representation (similar to UNIX format)
        return BitConverter.ToString(hash)
           // without dashes
           .Replace("-", string.Empty);
    }

    public int PartOne(string input)
    {
        var i = 0;
        for (i = 0; GetHash($"{input}{i}")[..5] != "00000"; ++i) { }
        return i;
    }

    public int PartTwo(string input)
    {
        var i = 0;
        for (i = 0; GetHash($"{input}{i}")[..6] != "000000"; ++i) { }
        return i;
    }

    public string ReadInput(string inputPath)
        => File.ReadLines(inputPath).FirstOrDefault() ?? String.Empty;
}
