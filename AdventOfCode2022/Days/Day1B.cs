using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace AdventOfCode2022.Days
{
    public class Day1B : Day<int>
    {
        public override string GetFileName() => "Input1.txt";

        public override int Calculate(string[] lines)
        {
            var sums = new List<int>();
            var total = 0;
            foreach (var line in lines)
            {
                if (line == string.Empty)
                {
                    sums.Add(total);
                    total = 0;
                }
                else
                {
                    total += int.Parse(line);
                }
            }

            if (total > 0)
            {
                sums.Add(total);
            }
            
            return sums.OrderByDescending(x => x).Take(3).Sum();
        }
    }
}