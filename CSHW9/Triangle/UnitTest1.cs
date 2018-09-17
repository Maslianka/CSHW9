using CSHW9;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TriangleTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPerimiter()
        {
            //Arrange
            Point a = new Point(0, 1);
            Point b = new Point(1, 0);
            Point c = new Point(0, 0);
            
            //Act            
            double expected = 3.41;
            double result = Math.Round(new Triangle(a, b, c).Perimiter(), 2);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestSquare()
        {
            //Arrange
            Point a = new Point(0, 1);
            Point b = new Point(1, 0);
            Point c = new Point(0, 0);

            //Act            
            double expected = 0.5;
            double result = new Triangle(a, b, c).Square();

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
