using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern
{
    class MiniCar : Car
    {
        public MiniCar(CarType carType, Location location) : base(CarType.MINI, location)
        {
            Construct();
        }

        public override void Construct()
        {
            Console.WriteLine("Connecting to MiniCar ...");
            Console.WriteLine(base.ToString());
        }
    }
}
