using System;
using NUnit.Framework;

namespace CodeWars
{
    [TestFixture]
    public class GridTests
    {
        [Test]
        public void Test1()
        {
            int rectangles = Grid.NumberOfRectangles(4, 4);
            Assert.AreEqual(100, rectangles);
        }

        [Test]
        public void Test2()
        {
            int rectangles = Grid.NumberOfRectangles(5, 5);
            Assert.AreEqual(225, rectangles);
        }
    }
}
