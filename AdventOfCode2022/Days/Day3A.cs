using System;
using System.Linq;

namespace AdventOfCode2022.Days
{
    public class Day3A : Day<int>
    {
        public override string GetFileName() => "Input3.txt";

        public override int Calculate(string[] lines)
        {
            var dict = Enumerable.Range(65, 58).ToDictionary(x => (char)x, x => (x > 64 && x < 91) ? x - 38 : x - 96);

            var total = 0;

            foreach (var line in lines)
            {
                var rucksack1 = line[0..(line.Length / 2)];
                var rucksack2 = line[rucksack1.Length..];

                char result = Char.MinValue;
                for (int i = 0; i < rucksack1.Length; i++)
                {
                    if (rucksack2.Contains(rucksack1[i]))
                    {
                        result = rucksack1[i];
                        break;
                    }
                }

                total += dict[result];
            }

            return total;
        }
    }
}