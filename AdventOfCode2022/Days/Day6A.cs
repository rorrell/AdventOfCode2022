using System.Collections.Generic;

namespace AdventOfCode2022.Days
{
    public class Day6A : Day<int>
    {
        public override string GetFileName() => "Input6.txt";

        public override int Calculate(string[] lines)
        {
            var text = lines[0];

            return Process(text, 4);
        }

        public int Process(string text, int numDistinctChars)
        {
            var q = new Queue<char>();
            var processed = 0;
            foreach (var ch in text)
            {
                while (q.Contains(ch))
                {
                    q.Dequeue();
                }

                q.Enqueue(ch);
                processed++;

                if (q.Count == numDistinctChars)
                    break;
            }

            return processed;
        }
    }
}