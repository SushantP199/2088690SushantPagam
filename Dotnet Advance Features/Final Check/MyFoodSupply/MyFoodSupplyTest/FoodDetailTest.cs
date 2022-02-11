using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFoodSupply;
using NUnit.Framework;

namespace MyFoodSupplyTest
{
    public class FoodDetailTest
    {
        [TestFixture]
        public class SupplyDetailTest
        {
            Program program;

            [SetUp]
            public void Setup()
            {
                program = new Program();
            }

            [Test]
            [TestCase("SushantPagam", 2, "2030-07-28", 30.03)]
            public void FoodDetailObjectCreationTest(string name, int dishType, DateTime expiryDate, double price)
            {
                var result = program.CreateFoodDetail(name, dishType, expiryDate, price);
                Assert.That(result, Is.TypeOf<FoodDetail>());
            }

            [Test]
            [TestCase("", 3, "2021-01-05", 80.4)]
            public void EmptyNameTest(string name, int dishType, DateTime expiryDate, double price)
            {
                Assert.Throws<Exception>(() => program.CreateFoodDetail(name, dishType, expiryDate, price));
            }

            [Test]
            [TestCase("SushantPagam", 1, "2020-11-16", -10.50)]
            public void NegativePriceTest(string name, int dishType, DateTime expiryDate, double price)
            {
                Assert.Throws<Exception>(() => program.CreateFoodDetail(name, dishType, expiryDate, price));
            }

            [Test]
            [TestCase("SushantPagam", 4, "2019-08-06", 100.5)]
            public void ExpiryDateLessThanCurrentDateTest(string name, int dishType, DateTime expiryDate, double price)
            {
                Assert.Throws<Exception>(() => program.CreateFoodDetail(name, dishType, expiryDate, price));
            }

        }
    }
}
