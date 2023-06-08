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

        [Test]
        public void ValidScaleneTriangle_Input15and20and25_OutputValidScaleneTriangle()
        {
            //Arrange
            int firstSide = 15;
            int secondSide = 20;
            int thirdSide = 25;

            string expected = "The triangle is valid and is a SCALENE";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ValidScaleneTriangle_Input30and40and50_OutputValidScaleneTriangle()
        {
            //Arrange
            int firstSide = 30;
            int secondSide = 40;
            int thirdSide = 50;

            string expected = "The triangle is valid and is a SCALENE";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ValidScaleneTriangle_Input50and60and100_OutputValidScaleneTriangle()
        {
            //Arrange
            int firstSide = 50;
            int secondSide = 60;
            int thirdSide = 100;

            string expected = "The triangle is valid and is a SCALENE";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ValidScaleneTriangle_Input35and30and10_OutputValidScaleneTriangle()
        {
            //Arrange
            int firstSide = 35;
            int secondSide = 30;
            int thirdSide = 10;

            string expected = "The triangle is valid and is a SCALENE";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void ValidScaleneTriangle_Input23and44and51_OutputValidScaleneTriangle()
        {
            //Arrange
            int firstSide = 23;
            int secondSide = 44;
            int thirdSide = 51;

            string expected = "The triangle is valid and is a SCALENE";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void NoZeroLength_Input0and15and12_OutputInValidTriangle()
        {
            //Arrange
            int firstSide = 0;
            int secondSide = 15;
            int thirdSide = 12;

            string expected = "At least one side of your triangle has a zero length and is thus invalid";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void NoZeroLength_Input54and0and37_OutputInValidTriangle()
        { 
            //Arrange
            int firstSide = 54;
            int secondSide = 0;
            int thirdSide = 37;

            string expected = "At least one side of your triangle has a zero length and is thus invalid";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void NoZeroLength_Input17and22and0_OutputInValidTriangle()
        {
            //Arrange
            int firstSide = 17;
            int secondSide = 22;
            int thirdSide = 0;

            string expected = "At least one side of your triangle has a zero length and is thus invalid";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
