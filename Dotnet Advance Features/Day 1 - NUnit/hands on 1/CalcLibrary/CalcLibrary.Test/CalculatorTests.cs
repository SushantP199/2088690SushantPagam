using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

namespace CalcLibrary.Test
{
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

        [Test]
        public void AdditionTest()
        {
            // Arrange
            // SimpleCalculator simpleCalculator = new SimpleCalculator();
            double a = 1;
            double b = 2;
            double expectedAddition = 3;

            // Act
            double actualAddition = simpleCalculator.Addition(a, b);

            // Assert
            Assert.AreEqual(expectedAddition, actualAddition);
        }
    }
}
