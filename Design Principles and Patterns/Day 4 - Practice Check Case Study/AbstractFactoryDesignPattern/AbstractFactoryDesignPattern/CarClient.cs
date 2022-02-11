using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern
{
    class CarClient
    {
        CarFactory _carFactory;
        public CarClient(CarFactory carFactory)
        {
            _carFactory = carFactory;
        }

        public void BuildMicroCar(Location location)
        {
            _carFactory.BuildMicroCar(location);
        }

        public void BuildMiniCar(Location location)
        {
            _carFactory.BuildMiniCar(location);
        }

        public void BuildLuxuryCar(Location location)
        {
            _carFactory.BuildLuxuryCar(location);
        }
    }
}
