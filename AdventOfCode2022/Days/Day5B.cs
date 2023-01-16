using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace AdventOfCode2022.Days
{
    public class Day5B : Day5A
    {
        public override string GetFileName() => "Input5.txt";

        public override string Calculate(string[] lines)
        {
            var (grid, instructions) = this.ParseInput(lines);

            this.FollowInstructions(ref grid, instructions, ProcessMove);

            return string.Join("", grid.Select(stack => stack.Peek()));
        }

        private void ProcessMove(int times, Stack<string> from, Stack<string> to)
        {
            var temp = new Stack<string>();
            for (int j = 0; j < times; j++)
            {
                temp.Push(from.Pop());
            }
            while (temp.Count > 0)
            {
                to.Push(temp.Pop());
            }
        }
    }
}