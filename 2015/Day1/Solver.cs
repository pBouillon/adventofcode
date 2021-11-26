using System;
using System.IO;

using Xunit;

namespace _2015.Day1;

public class Solver
{
    private static string ReadInput(string inputPath = "Day1/input.txt")
    {
        var fullPath = Path.Join(AppDomain.CurrentDomain.BaseDirectory, inputPath);
        return new StreamReader(fullPath).ReadLine() ?? String.Empty;
    }

    public class PartOne
    {
        private int Solution(string floors, int current = 0)
        {
            if (floors.Length == 0) return current;

            var head = floors[0];
            var tail = floors[1..];

            return head switch
            {
                '(' => Solution(tail, ++current),
                ')' => Solution(tail, --current),
                _ => throw new System.Exception($"Unexpected symbol '{head}'")
            };
        }

        [Theory]
        [InlineData("()()", 0)]
        [InlineData("(())", 0)]
        [InlineData("(((", 3)]
        [InlineData("(()(()(", 3)]
        [InlineData("())", -1)]
        [InlineData("))(", -1)]
        [InlineData(")))", -3)]
        [InlineData(")())())", -3)]
        public void PartOneExamples(string floors, int expected)
            => Assert.Equal(expected, Solution(floors));

        [Fact]
        private void PartOneSolution()
            => Assert.Equal(138, Solution(ReadInput()));
    }
    
    public class PartTwo 
    {
        private int Solution(string floors, int current = 0, int position = 0)
        {
            if (current == -1) return position;

            var head = floors[0];
            var tail = floors[1..];

            return head switch
            {
                '(' => Solution(tail, ++current, ++position),
                ')' => Solution(tail, --current, ++position),
                _ => throw new System.Exception($"Unexpected symbol '{head}'")
            };
        }

        [Theory]
        [InlineData(")", 1)]
        [InlineData("()())", 5)]
        public void PartTwoExamples(string floors, int expected)
            => Assert.Equal(expected, Solution(floors));

        [Fact]
        private void PartTwoSolution()
            => Assert.Equal(1771, Solution(ReadInput()));
    }
}
