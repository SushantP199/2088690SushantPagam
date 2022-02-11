using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    class ElectronicOrder:Order
    {
        channel _channel;
        productType _productType;

        public ElectronicOrder(channel channel, productType productType) : base(channel, productType.Electronic)
        {
            _channel = channel;
            _productType = productType;
            processOrder();
        }

        public override void processOrder()
        {
            Console.WriteLine();
            Console.WriteLine($"{_productType} Order is placed through {_channel} channel");
        }
    }
}
