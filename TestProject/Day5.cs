using System.IO;
using AdventOfCode2022.Days;
using NUnit.Framework;

namespace TestProject
{
    [TestFixture]
    public class Day5
    {
        private string[] _lines;

        [SetUp]
        public void Setup()
        {
            _lines = File.ReadAllLines("Input/Input5.txt");
        }

        [Test]
        public void Day5A()
        {
            Day<string> day = new Day5A();
            Assert.AreEqual("CMZ", day.Calculate(_lines));
        }

        [Test]
        public void Day5B()
        {
            Day<string> day = new Day5B();
            Assert.AreEqual("MCD", day.Calculate(_lines));
        }
    }
}