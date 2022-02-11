using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

namespace CalcLibrary.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        SimpleCalculator simpleCalculator;

        [SetUp]
        public void Initialize()
        {
            simpleCalculator = new SimpleCalculator();
        }

        [TearDown]
        public void FreeUp()
        {
            simpleCalculator = null;
        }

        [Test, TestCaseSource("subtractionCases")]
        public void SubtractionTest(double a, double b, double expectedSubtraction)
        {
            // Arrange

            // Act
            double actualSubtraction = simpleCalculator.Subtraction(a, b);

            // Assert
            Assert.AreEqual(Math.Round(expectedSubtraction, 1), Math.Round(actualSubtraction, 1));

        }

        public static object[] subtractionCases =
        {
            new object[] {1, 2, -1},
            new object[] {3.1, 2.5, 0.6},
            new object[] {50, 9, 41},
            new object[] {-54.2, 78.7, -132.9},
            new object[] {4, -0.5, 4.5}
        };


        [Test, TestCaseSource("multiplicationCases")]
        public void MultiplicationTest(double a, double b, double expectedMultiplication)
        {
            // Arrange

            // Act
            double actualMultiplication = simpleCalculator.Multiplication(a, b);

            // Assert
            Assert.AreEqual(Math.Round(expectedMultiplication, 2), Math.Round(actualMultiplication, 2));
        }

        public static object[] multiplicationCases =
        {
            new object[] {2, 3, 6},
            new object[] {1.5, 8.9, 13.35},
            new object[] {-9.1, 0.9, -8.19},
            new object[] {1.5, 10, 15},
            new object[] {-3, 8.9, -26.7},
        };

        [Test, TestCaseSource("divisonCases")]
        public void DivisionTest(double a, double b, double expectedDivision)
        {
            try
            {
                // Arrange

                // Act
                double actualDivision = simpleCalculator.Division(a, b);

                // Assert
                Assert.AreEqual(Math.Round(expectedDivision, 4), Math.Round(actualDivision, 4));
            }
            catch(ArgumentException)
            {
                Assert.Fail("Division by zero");
            }
            
        }

        public static object[] divisonCases =
        {
            new object[] {4, 2, 2},
            new object[] {0.4, -9, -0.0444},
            new object[] {-10.45, -2.56, 4.0820},
            new object[] {10, 0, -999999},
            new object[] {1, 50, 0.02},
        };

        [Test]
        public void TestAddAndClear()
        {
            // Arrange
            double expectedResult = 0;

            // Act
            simpleCalculator.Addition(1, 2);
            double actualResult = simpleCalculator.GetResult;

            simpleCalculator.AllClear();
            actualResult = simpleCalculator.GetResult;

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}