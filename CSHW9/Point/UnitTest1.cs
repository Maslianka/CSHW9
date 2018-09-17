using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSHW9;
using System.IO;


namespace PointTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCheckPoints()
        {
            //Arrange
            Point point = new Point(0,1);

            //Act
            double expectedX = 0;
            double expectedY = 1;

            //Assert
            Assert.AreEqual(expectedX, point.X);
            Assert.AreEqual(expectedY, point.Y);
        }

        [TestMethod]
        public void TestDistance_p1_p2()
        {
            //Arrange
            Point point1 = new Point(0, 1);
            Point point2 = new Point(0, 0);
            double expected = 1;
            
            //Act
            double result = point1.Distance(point2);

            //Assert
            Assert.AreEqual(expected, result);


        }
        public void TestDistance_p2_p1()
        {
            //Arrange
            Point point1 = new Point(0, 0);
            Point point2 = new Point(0, 1);
            double expected = 1;

            //Act
            double result = point1.Distance(point2);

            //Assert
            Assert.AreEqual(expected, result);

        }
    }
}
