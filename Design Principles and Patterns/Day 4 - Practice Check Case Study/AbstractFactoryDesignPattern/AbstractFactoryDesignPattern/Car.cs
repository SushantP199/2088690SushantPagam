using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern
{
    public enum CarType
    {
        MICRO, MINI, LUXURY
    }

    public enum Location
    {
        DEFAULT, USA, INDIA
    }

    abstract class Car
    {
        public Car(CarType model, Location location)
        {
            this.CarType = model;
            this.Location = location;
        }

        public abstract void Construct();

        public CarType CarType { get; set; }

        public Location Location { get; set; }

        public override string ToString()
        {
            return $"Car model {CarType.ToString()} is located in {Location.ToString()}";
        }
    }
}
