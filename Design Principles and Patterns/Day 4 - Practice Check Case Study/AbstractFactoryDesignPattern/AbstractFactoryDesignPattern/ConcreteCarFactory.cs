using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern
{
    class ConcreteCarFactory:CarFactory
    {
        Car car;

        public override void BuildMicroCar(Location location)
        {
            car = new MicroCar(CarType.MICRO, location);
        }

        public override void BuildMiniCar(Location location)
        {
            car = new MiniCar(CarType.MINI, location);
        }

        public override void BuildLuxuryCar(Location location)
        {
            car = new LuxuryCar(CarType.LUXURY, location);
        }
    }
}
