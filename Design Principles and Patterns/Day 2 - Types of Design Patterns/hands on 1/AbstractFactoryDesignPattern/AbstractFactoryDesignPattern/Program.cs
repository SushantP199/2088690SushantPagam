using System;

namespace AbstractFactoryDesignPattern
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Type Tata Or Tesla");
            string type = Console.ReadLine().ToLower();

            Tire tire = GetFactory(type).makeTire();
            Console.WriteLine(tire.getTire());

            Headlight headlight = GetFactory(type).makeHeadlight();
            Console.WriteLine(headlight.GetHeadlight());

                        
            
        }

        public static Factory GetFactory(string factoryname)
        {
            if (factoryname.Equals("audi"))
            {
                return new TataFactory();
            }
            else if (factoryname.Equals("mercedes"))
            {
                return new TeslaFactory();
            }
            else return null;
        }

        
        
    }
}
