using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2022.Days
{
    public class Day4A : Day<int>
    {
        public override string GetFileName() => "Input4.txt";

        public override int Calculate(string[] lines)
        {
            var count = 0;
            foreach (var line in lines)
            {
                //ex 2-4,6-8
                var assignments = line.Split(',');
                var ranges = new List<int>[2];
                int i = 0;
                foreach (var assignment in assignments)
                {
                    //ex 2-4
                    var brackets = assignment.Split('-').Select(int.Parse).ToArray();
                    ranges[i] = Enumerable.Range(brackets[0], brackets[1] - brackets[0] + 1).ToList();
                    i++;
                }

                if (ranges[0].All(x => ranges[1].Contains(x)) || ranges[1].All(x => ranges[0].Contains(x)))
                    count++;
            }

            return count;
        }
    }
}