using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    [TestFixture]
    public class FloodFillTests
    {
        [Test]
        public void TestExample()
        {
            var expected = new int[,]
            { 
                { 1, 4, 3 },
                { 1, 4, 4 },
                { 2, 3, 4 } 
            };

            var actual = new int[,]
            {
                { 1, 2, 3 },
                { 1, 2, 2 },
                { 2, 3, 2 }
            };

            CollectionAssert.AreEqual(expected, Kata.FloodFill(actual, 0, 1, 4));
        }
    }
}
