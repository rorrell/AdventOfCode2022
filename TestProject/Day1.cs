using System.IO;
using System.Runtime.InteropServices.ComTypes;
using AdventOfCode2022.Days;
using NUnit.Framework;

namespace TestProject
{
    [TestFixture]
    public class Day1
    {
        private string[] _lines;

        [SetUp]
        public void Setup()
        {
            _lines = File.ReadAllLines("Input/Input1.txt");
        }

        [Test]
        public void Day1A()
        {
            Day<int> day = new Day1A();
            Assert.AreEqual(24000, day.Calculate(_lines));
        }

        [Test]
        public void Day1B()
        {
            Day<int> day = new Day1B();
            Assert.AreEqual(45000, day.Calculate(_lines));
        }
    }
}