using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFoodSupply;
using NUnit.Framework;

namespace MyFoodSupplyTest
{
    [TestFixture]
    public class SupplyDetailTest
    {
        Program program;

        [SetUp]
        public void setup()
        {
            program = new Program();
        }

        [Test]
        [TestCase(4, "2022-06-10", "SushantPagam", 120.40)]
        public void SupplyDetailObjectCreationTest(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge)
        {
            FoodDetail item = program.CreateFoodDetail("abc", 1, new DateTime(2025, 01, 05), 8.55);
            var result = program.CreateSupplyDetail(foodItemCount, requestDate, sellerName, packingCharge, item);
            Assert.That(result, Is.TypeOf<SupplyDetail>());
        }

        [Test]
        [TestCase(1, "2020-05-01", "SushantPagam", 150.00)]
        public void FoodItemIsNullTest(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge)
        {
            Assert.AreEqual(program.CreateSupplyDetail(foodItemCount, requestDate, sellerName, packingCharge, null), null);
        }
       
        [Test]
        [TestCase(2, "2018-07-15", "SushantPagam", 1.5)]
        public void RequestDateLessThanCurrentDateTest(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge)
        {
            FoodDetail item = program.CreateFoodDetail("abc", 1, new DateTime(2025, 01, 05), 8.55);
            Assert.Throws<Exception>(() => program.CreateSupplyDetail(foodItemCount, requestDate, sellerName, packingCharge, item));
        }

        [Test]
        [TestCase(-3, "2017-08-28", "SushantPagam", 200.002)]
        public void FoodItemCountLessThanZeroTest(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge)
        {
            FoodDetail item = program.CreateFoodDetail("abc", 1, new DateTime(2025, 01, 05), 8.55);
            Assert.Throws<Exception>(() => program.CreateSupplyDetail(foodItemCount, requestDate, sellerName, packingCharge, item));
        }
    }
}
