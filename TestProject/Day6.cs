using System.IO;
using AdventOfCode2022.Days;
using NUnit.Framework;

namespace TestProject
{
    [TestFixture]
    public class Day6
    {
        private string[] _lines;

        [SetUp]
        public void Setup()
        {
            _lines = File.ReadAllLines("Input/Input6.txt");
        }

        [Test]
        public void Day6A()
        {
            Day<int> day = new Day6A();
            Assert.AreEqual(7, day.Calculate(_lines));
        }

        [Test]
        public void Day6B()
        {
            Day<int> day = new Day6B();
            Assert.AreEqual(19, day.Calculate(_lines));
        }
    }
}