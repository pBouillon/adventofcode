using System;
using System.Collections.Generic;

using TestCommons;

namespace _2021.Day8;

public class PuzzleTest : SolverTest<Solver, IEnumerable<Entry>, int>
{
    protected override Example PartOne => new()
    {
        Input = new List<Entry>()
        {
            new Entry(new [] { "be", "cfbegad", "cbdgef", "fgaecd", "cgeb", "fdcge", "agebfd", "fecdb", "fabcd", "edb" }, new string[] { "fdgacbe", "cefdb", "cefbgd", "gcbe" }),
            new Entry(new [] { "edbfga", "begcd", "cbg", "gc", "gcadebf", "fbgde", "acbgfd", "abcde", "gfcbed", "gfec" }, new string[] { "fcgedb", "cgb", "dgebacf", "gc" }),
            new Entry(new [] { "fgaebd", "cg", "bdaec", "gdafb", "agbcfd", "gdcbef", "bgcad", "gfac", "gcb", "cdgabef" }, new string[] { "cg", "cg", "fdcagb", "cbg" }),
            new Entry(new [] { "fbegcd", "cbd", "adcefb", "dageb", "afcb", "bc", "aefdc", "ecdab", "fgdeca", "fcdbega" }, new string[] { "efabcd", "cedba", "gadfec", "cb" }),
            new Entry(new [] { "aecbfdg", "fbg", "gf", "bafeg", "dbefa", "fcge", "gcbea", "fcaegb", "dgceab", "fcbdga" }, new string[] { "gecf", "egdcabf", "bgf", "bfgea" }),
            new Entry(new [] { "fgeab", "ca", "afcebg", "bdacfeg", "cfaedg", "gcfdb", "baec", "bfadeg", "bafgc", "acf" }, new string[] { "gebdcfa", "ecba", "ca", "fadegcb" }),
            new Entry(new [] { "dbcfg", "fgd", "bdegcaf", "fgec", "aegbdf", "ecdfab", "fbedc", "dacgb", "gdcebf", "gf" }, new string[] { "cefg", "dcbef", "fcge", "gbcadfe" }),
            new Entry(new [] { "bdfegc", "cbegaf", "gecbf", "dfcage", "bdacg", "ed", "bedf", "ced", "adcbefg", "gebcd" }, new string[] { "ed", "bcgafe", "cdgba", "cbgef" }),
            new Entry(new [] { "egadfb", "cdbfeg", "cegd", "fecab", "cgb", "gbdefca", "cg", "fgcdab", "egfdb", "bfceg" }, new string[] { "gbdfcae", "bgc", "cg", "cgb" }),
            new Entry(new [] { "gcafb", "gcf", "dcaebfg", "ecagb", "gf", "abcdeg", "gaef", "cafbge", "fdbac", "fegbdc" }, new string[] { "fgae", "cfgab", "fg", "bagce" })
        },
        Result = 26,
    };

    protected override int PartOneSolution => 0;

    protected override Example PartTwo => throw new NotImplementedException();

    protected override int PartTwoSolution => throw new NotImplementedException();
}
