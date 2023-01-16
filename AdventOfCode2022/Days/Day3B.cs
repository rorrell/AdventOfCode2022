using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2022.Days
{
    public class Day3B : Day<int>
    {
        public override string GetFileName() => "Input3.txt";

        public override int Calculate(string[] lines)
        {
            var dict = Enumerable.Range(65, 58).ToDictionary(x => (char)x, x => (x > 64 && x < 91) ? x - 38 : x - 96);

            var total = 0;

            for (int i = 0; i < lines.Length; i+=3)
            {
                var set = new[] { lines[i], lines[i + 1], lines[i + 2] };
                var ordered = set.OrderByDescending(x => x.Length);
                var longest = ordered.First();
                var others = ordered.Skip(1).Take(2).ToArray();
                foreach (var ch in longest)
                {
                    if (!others[0].Contains(ch) || !others[1].Contains(ch)) continue;
                    total += dict[ch];
                    break;
                }
            }

            return total;
        }
    }
}