using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace AdventOfCode2022.Days
{
    public class Day5A : Day<string>
    {
        public override string GetFileName() => "Input5.txt";

        public override string Calculate(string[] lines)
        {
            var (grid, instructions) = ParseInput(lines);

            FollowInstructions(ref grid, instructions, ProcessMove);

            return string.Join("", grid.Select(stack => stack.Peek()));
        }

        private void ProcessMove(int times, Stack<string> from, Stack<string> to)
        {
            for (int j = 0; j < times; j++)
            {
                to.Push(from.Pop());
            }
        }

        public (List<Stack<string>>, IEnumerable<string>) ParseInput(string[] lines)
        {
            //break lines into grid and instructions
            var gridLines = new List<string>();
            var i = 1;
            foreach (var line in lines)
            {
                if (line.Trim().Length == 0)
                {
                    break;
                }
                i++;
                gridLines.Add(line);
            }

            var instructions = lines.Skip(i);

            //parse grid
            /* grid example:
                   [D]    
               [N] [C]    
               [Z] [M] [P]
                1   2   3 
             */
            var grid = new List<Stack<string>>();
            for (int j = gridLines.Count - 1; j >= 0; j--)
            {
                if (j == gridLines.Count - 1)
                {
                    //get the last number in the bottom row to figure out the number of stacks
                    var count = gridLines[j]
                        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse).Last();
                    foreach (var num in Enumerable.Range(0, count))
                    { // create the stacks
                        grid.Add(new Stack<string>());
                    }
                }
                else
                {
                    // the regex allows us to keep [D] in the first row in stack 2 instead of it ending up in stack 1
                    Regex itemPattern = new Regex(@"(\s{3}|\[\D\])(?:\s?)");
                    var items = itemPattern.Matches(gridLines[j]).Select(x => x.Value).ToArray();
                    for (int k = 0; k < grid.Count; k++)
                    {
                        if (items[k].Trim().Length > 1) //don't push whitespace items that are there for formatting
                            grid[k].Push(items[k][1].ToString()); //take only the letter, not the surrounding brackets
                    }
                }
            }

            return (grid, instructions);
        }

        public void FollowInstructions(ref List<Stack<string>> grid, IEnumerable<string> instructions, Action<int, Stack<string>, Stack<string>> action)
        {
            foreach (var instruction in instructions)
            {
                // the regex allows us to extract the numbers
                Regex pattern = new Regex(@"(?:move|from|to) (?<number>\d{1,2})(?:\s?)");
                var matches = pattern.Split(instruction).Where(x => x != "")
                    .Select(int.Parse).ToArray();
                var move = matches[0];
                var from = matches[1];
                var to = matches[2];
                // move the numbers around as instructed
                action.Invoke(move, grid[from-1], grid[to-1]);
            }
        }
    }
}