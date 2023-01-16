namespace AdventOfCode2022.Days
{
    public class Day6B : Day6A
    {
        public override string GetFileName() => "Input6.txt";

        public override int Calculate(string[] lines)
        {
            return this.Process(lines[0], 14);
        }
    }
}