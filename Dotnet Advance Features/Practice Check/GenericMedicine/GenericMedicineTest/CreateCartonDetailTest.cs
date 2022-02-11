using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using GenericMedicine;

namespace GenericMedicineTest
{
    [TestFixture]
    public class CreateCartonDetailTest
    {
        Program program;

        Medicine medicine = new Medicine()
        {
            Id = 1,
            Name = "SushantPagam",
            GenericMedicineName = "Dolo650",
            Composition = "paracetamol",
            ExpiryDate = new DateTime(2023, 01, 01),
            PricePerStrip = 4.5
        };

        [SetUp]
        public void Init()
        {
            program = new Program();
        }

        [Test]
        [TestCase(10, "2022-04-09", "mumbai")]
        public void CartonObjectCreationTest(int c, DateTime date, string addr)
        {

            Assert.DoesNotThrow(() => program.CreateCartonDetail(c, date, addr, medicine));
        }

        [Test]
        [TestCase(-1, "2021-02-17", "mumbai")]
        public void StripCountTest(int c, DateTime date, string addr)
        {
            Assert.That(() => program.CreateCartonDetail(c, date, addr, medicine), Throws.Exception);
        }

        [Test]
        [TestCase(10, "2020-01-11", "mumbai", null)]
        public void NullMedicineObjectTest(int c, DateTime date, string addr, Medicine med)
        {
            Assert.AreEqual(program.CreateCartonDetail(c, date, addr, med), null);
        }

        [Test]
        [TestCase(10, "2019-12-20", "mumbai")]
        public void LaunchDateLessThanCurrentDateTest(int c, DateTime date, string addr)
        {
            Assert.That(() => program.CreateCartonDetail(c, date, addr, medicine), Throws.Exception);
        }
    }
}
