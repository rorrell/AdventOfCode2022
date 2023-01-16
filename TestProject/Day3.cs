using System.IO;
using AdventOfCode2022.Days;
using NUnit.Framework;

namespace TestProject
{
    [TestFixture]
    public class Day3
    {
        private string[] _lines;

        [SetUp]
        public void Setup()
        {
            _lines = File.ReadAllLines("Input/Input3.txt");
        }

        [Test]
        public void Day3A()
        {
            Day<int> day = new Day3A();
            Assert.AreEqual(157, day.Calculate(_lines));
        }

        [Test]
        public void Day3B()
        {
            Day<int> day = new Day3B();
            Assert.AreEqual(70, day.Calculate(_lines));
        }
    }
}