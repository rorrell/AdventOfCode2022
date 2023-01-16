using System.IO;
using AdventOfCode2022.Days;
using NUnit.Framework;

namespace TestProject
{
    [TestFixture]
    public class Day2
    {
        private string[] _lines;

        [SetUp]
        public void Setup()
        {
            _lines = File.ReadAllLines("Input/Input2.txt");
        }

        [Test]
        public void Day2A()
        {
            Day<int> day = new Day2A();
            Assert.AreEqual(15, day.Calculate(_lines));
        }

        [Test]
        public void Day2B()
        {
            Day<int> day = new Day2B();
            Assert.AreEqual(12, day.Calculate(_lines));
        }
    }
}