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

        public void ValidIsocelesTriangle_Input15and15and15_OutputValidIsocelesTriangle()
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




    }
}
