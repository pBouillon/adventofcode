﻿using System.Collections.Generic;

using TestCommons;

namespace _2021.Day08;

public class PuzzleTest : SolverTest<Solver, IEnumerable<Entry>, int>
{
    private readonly List<Entry> _entries = new()
    {
        new Entry(
            new[] { "be", "cfbegad", "cbdgef", "fgaecd", "cgeb", "fdcge", "agebfd", "fecdb", "fabcd", "edb" },
            new[] { "fdgacbe", "cefdb", "cefbgd", "gcbe" }),
        new Entry(
            new[] { "edbfga", "begcd", "cbg", "gc", "gcadebf", "fbgde", "acbgfd", "abcde", "gfcbed", "gfec" },
            new[] { "fcgedb", "cgb", "dgebacf", "gc" }),
        new Entry(
            new[] { "fgaebd", "cg", "bdaec", "gdafb", "agbcfd", "gdcbef", "bgcad", "gfac", "gcb", "cdgabef" },
            new[] { "cg", "cg", "fdcagb", "cbg" }),
        new Entry(
            new[] { "fbegcd", "cbd", "adcefb", "dageb", "afcb", "bc", "aefdc", "ecdab", "fgdeca", "fcdbega" },
            new[] { "efabcd", "cedba", "gadfec", "cb" }),
        new Entry(
            new[] { "aecbfdg", "fbg", "gf", "bafeg", "dbefa", "fcge", "gcbea", "fcaegb", "dgceab", "fcbdga" },
            new[] { "gecf", "egdcabf", "bgf", "bfgea" }),
        new Entry(
            new[] { "fgeab", "ca", "afcebg", "bdacfeg", "cfaedg", "gcfdb", "baec", "bfadeg", "bafgc", "acf" },
            new[] { "gebdcfa", "ecba", "ca", "fadegcb" }),
        new Entry(
            new[] { "dbcfg", "fgd", "bdegcaf", "fgec", "aegbdf", "ecdfab", "fbedc", "dacgb", "gdcebf", "gf" },
            new[] { "cefg", "dcbef", "fcge", "gbcadfe" }),
        new Entry(
            new[] { "bdfegc", "cbegaf", "gecbf", "dfcage", "bdacg", "ed", "bedf", "ced", "adcbefg", "gebcd" },
            new[] { "ed", "bcgafe", "cdgba", "cbgef" }),
        new Entry(
            new[] { "egadfb", "cdbfeg", "cegd", "fecab", "cgb", "gbdefca", "cg", "fgcdab", "egfdb", "bfceg" },
            new[] { "gbdfcae", "bgc", "cg", "cgb" }),
        new Entry(
            new[] { "gcafb", "gcf", "dcaebfg", "ecagb", "gf", "abcdeg", "gaef", "cafbge", "fdbac", "fegbdc" },
            new[] { "fgae", "cfgab", "fg", "bagce" }),
    };

    protected override Example PartOne => new()
    {
        Input = _entries,
        Result = 26,
    };

    protected override int PartOneSolution => 237;

    protected override Example PartTwo => new()
    {
        Input = _entries,
        Result = 61229,
    };

    protected override int PartTwoSolution => 1009098;
}