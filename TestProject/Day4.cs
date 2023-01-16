using System.IO;
using AdventOfCode2022.Days;
using NUnit.Framework;

namespace TestProject
{
    [TestFixture]
    public class Day4
    {
        private string[] _lines;

        [SetUp]
        public void Setup()
        {
            _lines = File.ReadAllLines("Input/Input4.txt");
        }

        [Test]
        public void Day4A()
        {
            Day<int> day = new Day4A();
            Assert.AreEqual(2, day.Calculate(_lines));
        }

        [Test]
        public void Day4B()
        {
            Day<int> day = new Day4B();
            Assert.AreEqual(4, day.Calculate(_lines));
        }
    }
}