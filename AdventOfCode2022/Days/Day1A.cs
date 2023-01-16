using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode2022.Days
{
    public class Day1A : Day<int>
    {
        public override string GetFileName() => "Input1.txt";

        public override int Calculate(string[] lines)
        {
            var max = 0;
            var total = 0;
            foreach (var line in lines)
            {
                if (line == string.Empty)
                {
                    if (total > max)
                    {
                        max = total;
                    }

                    total = 0;
                }
                else
                {
                    total += int.Parse(line);
                }
            }

            return max;
        }
    }
}