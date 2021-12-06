using Commons;

using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _2021.Day6;

public class LanternFish
{
    public int InternalTimer { get; private set; }

    public LanternFish(int internalTimer)
        => InternalTimer = internalTimer;

    public void PassDay()
        => InternalTimer = InternalTimer == 0
            ? InternalTimer = 6
            : --InternalTimer;
}

public class LanternFishPopulation
{
    public List<LanternFish> Population { get; private set; } = new List<LanternFish>();

    public LanternFishPopulation(List<LanternFish> initialPopulation)
        => Population = initialPopulation;

    public void PassDay()
    {
        for (var i = 0; i < Population.Count(fish => fish.InternalTimer == 0); ++i)
        {
            Population.Add(new LanternFish(8));
        }

        Population.ForEach(fish => fish.PassDay());
    }
}

public class Solver : ISolver<LanternFishPopulation, int>
{
    public string InputPath
        => "Day6/input.txt";

    public int PartOne(LanternFishPopulation lanternFishesPopulation)
    {
        for (int i = 0; i < 80; ++i)
        {
            lanternFishesPopulation.PassDay();
        }

        return lanternFishesPopulation.Population.Count;
    }

    public int PartTwo(LanternFishPopulation input)
    {
        throw new System.NotImplementedException();
    }

    public LanternFishPopulation ReadInput(string inputPath)
    {
        var lanternFishes = File
            .ReadLines(inputPath)
            .First()
            .Split(",")
            .Select(internalTimer => new LanternFish(int.Parse(internalTimer)))
            .ToList();

        return new LanternFishPopulation(lanternFishes);
    }
}
