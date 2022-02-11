using NUnit.Framework;
using AdapterDesignPattern;

namespace AdapterDesignPatternTest
{
    public class MovableAdapterImplTest
    {
        [SetUp]
        public void Setup() { }

        [Test]
        public void ConvertMphtoKmphTest()
        {
            Movable tesla = new Tesla();
            MovableAdapterImpl movableAdapter = new MovableAdapterImpl(tesla);
            Assert.AreEqual(movableAdapter.getSpeed(), 482.802);
        }

        [Test]
        public void ConvertUSDtoEuroTest()
        {
            Movable tesla = new Tesla();
            MovableAdapterImpl movableAdapter = new MovableAdapterImpl(tesla);
            Assert.AreEqual(movableAdapter.getPrice(), 420.0);
        }
    }
}