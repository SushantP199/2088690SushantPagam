using NUnit.Framework;
using GenericMedicine;
using System;

namespace GenericMedicineTest
{
    [TestFixture]
    public class CreateMedicineDetailTest
    {
        Program program;

        [SetUp]
        public void Init()
        {
            program = new Program();
        }

        [Test]
        [TestCase("SushantPagam", "Dolo650", "Paracetamol", "2030-01-28", 5.4)]
        public void MedicineObjectCreationTest(string name, string medName, string comp, DateTime date, double p)
        {
            var result = program.CreateMedicineDetail(name, medName, comp, date, p);
            Assert.That(result, Is.TypeOf<Medicine>());
        }

        [Test]
        [TestCase("SushantPagam", "Dolo650", "Paracetamol", "2020-05-20", 4.5)]
        public void ExpiryDateTest(string name, string medName, string comp, DateTime date, double p)
        {
            Assert.That(() => program.CreateMedicineDetail(name, medName, comp, date, p), Throws.Exception);
        }

        [Test]
        [TestCase("SushantPagam", "", "Paracetamol", "2022-01-28", 4.5)]
        public void MedicineNameTest(string name, string medName, string comp, DateTime date, double p)
        {
            Assert.That(() => program.CreateMedicineDetail(name, medName, comp, date, p), Throws.Exception);
        }

        [Test]
        [TestCase("SushantPagam", "Dolo650", "", "2022-01-28", 0)]
        public void PriceValueTest(string name, string medName, string comp, DateTime date, double p)
        {
            Assert.That(() => program.CreateMedicineDetail(name, medName, comp, date, p), Throws.Exception);
        }
    }
}