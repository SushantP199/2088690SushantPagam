using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    class ClientOrder
    {
        Factory factory;

        public ClientOrder(Factory factory)
        {
            this.factory = factory;
        }

        public void ElectronicOrder(channel channel)
        {
            factory.ElectronicOrder(channel);
        }

        public void FurnitureOrder(channel channel)
        {
            factory.FurnitureOrder(channel);
        }

        public void ToysOrder(channel channel)
        {
            factory.ToysOrder(channel);
        }
    }
}
