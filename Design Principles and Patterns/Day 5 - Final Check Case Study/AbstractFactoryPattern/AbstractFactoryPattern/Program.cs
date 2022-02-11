using System;

namespace AbstractFactoryPattern
{
    public enum productType
    {
        Electronic, Toys, Furniture
    }

    public enum channel
    {
        Ecommerce, TeleCaller
    }

    class Program
    {
        
        static void Main(string[] args)
        {
            Factory factory = new FactoryDesign();

            ClientOrder clientOrder = new ClientOrder(factory);

            clientOrder.ElectronicOrder(channel.Ecommerce);
            clientOrder.FurnitureOrder(channel.Ecommerce);
            clientOrder.ToysOrder(channel.Ecommerce);

            clientOrder.ElectronicOrder(channel.TeleCaller);
            clientOrder.FurnitureOrder(channel.TeleCaller);
            clientOrder.ToysOrder(channel.TeleCaller);

            Console.ReadKey();
        }
    }
}
