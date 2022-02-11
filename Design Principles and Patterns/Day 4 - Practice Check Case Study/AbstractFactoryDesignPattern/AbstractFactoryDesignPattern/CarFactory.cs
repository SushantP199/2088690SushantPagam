using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern
{
    abstract class CarFactory
    {
        public abstract void BuildMicroCar(Location location);

        public abstract void BuildMiniCar(Location location);

        public abstract void BuildLuxuryCar(Location location);
    }
}
