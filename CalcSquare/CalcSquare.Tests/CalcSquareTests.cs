using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalcSquare;

namespace CalcSquare.Tests
{
    [TestClass]
    public class CalcSquareTests
    {
        [TestMethod]
        public void CreateWithInvalidRadius()
        {
            // arrange
            double radius = -5;

            // act
            try
            {
                Assert.IsNotNull(new CalcSquare.Circle(radius));
            }
            catch (ArgumentOutOfRangeException e)
            {
                Assert.Fail(e.ToString());
            }           
        }

        [TestMethod]
        public void CreateWithCorrectRadius()
        {
            // arrange
            double radius = 7;

            // act
            try
            {
                Assert.IsNotNull(new CalcSquare.Circle(radius));
            }
            catch (ArgumentOutOfRangeException e)
            {
                Assert.Fail(e.ToString());
            }
        }

        [TestMethod]
        public void CalculateCircleSquare()
        {
            //Arrange
            double radius = 6.0;

            Circle circle = new Circle(radius);

            //Act
            double square = circle.Square();
            //Assert
            Assert.IsTrue(square <= 115 && square > 113);
        }

        [TestMethod]
        public void CreateTriangleWithInvalidParameter()
        {
            // arrange
            double a = -3;
            double b = 2;
            double c = 1.5;

            //act
            try
            {
                Assert.IsNotNull(new CalcSquare.Triangle(a, b, c));
            }
            catch (ArgumentOutOfRangeException e)
            {
                Assert.Fail(e.ToString());
            }
        }

        [TestMethod]
        public void CreateTriangleWithCorrectParameter()
        {
            // arrange
            double a = 3;
            double b = 4;
            double c = 5;

            //act
            try
            {
                Assert.IsNotNull(new CalcSquare.Triangle(a, b, c));
            }
            catch (ArgumentOutOfRangeException e)
            {
                Assert.Fail(e.ToString());
            }
        }


        [TestMethod]
        public void CheckIfTriangleIsRectangular()
        {
            // arrange
            double a = 3.0;
            double b = 4.0;
            double c = 5.0;

            //act
            Triangle triangle = new Triangle(a, b, c);
            
            //Act Assert
            Assert.IsTrue(triangle.IsRectangular());
        }

        [TestMethod]
        public void CalculateTriangleSquare()
        {
            //Arrange
            double a = 3.0;
            double b = 4.0;
            double c = 5.0;

            Triangle triangle = new Triangle(a, b, c);

            //Act
            double square = triangle.Square();
            //Assert
            Assert.IsTrue(square <= 6.0 && square > 5.99);
        }
    }
}
