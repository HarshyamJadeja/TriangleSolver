using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangleSolver;
using NUnit.Framework;

namespace TriangleTests
{
    public class Class1
    {
        [Test]
        public void ValidEquilateralTriangle_Input15and15and15_OutputValidEquilateralTriangle()
        {
            //Arrange
            int firstSide = 15;
            int secondSide = 15;
            int thirdSide = 15;

            string expected = "The triangle is valid and is an EQUILATERAL";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ValidIsocelesTriangle_Input15and15and5_OutputValidIsocelesTriangle()
        {
            //Arrange
            int firstSide = 15;
            int secondSide = 15;
            int thirdSide = 5;

            string expected = "The triangle is valid and is an ISOSCELES";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ValidIsocelesTriangle_Input20and10and20_OutputValidIsocelesTriangle()
        {
            //Arrange
            int firstSide = 20;
            int secondSide = 10;
            int thirdSide = 20;

            string expected = "The triangle is valid and is an ISOSCELES";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ValidIsocelesTriangle_Input15and15and25_OutputValidIsocelesTriangle()
        {
            //Arrange
            int firstSide = 15;
            int secondSide = 15;
            int thirdSide = 25;

            string expected = "The triangle is valid and is an ISOSCELES";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, actual);
        }


    }
}
