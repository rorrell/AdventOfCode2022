using System.IO;

namespace AdventOfCode2022.Days
{
    public abstract class Day<T>
    {
        public abstract string GetFileName();
        public string[] GetLines() => File.ReadAllLines("Input/" + GetFileName());

        public abstract T Calculate(string[] lines);

        public T Run()
        {
            var lines = GetLines();

            return Calculate(lines);
        }
    }
}