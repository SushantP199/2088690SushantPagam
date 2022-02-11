using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterDesignPattern
{
    public class Tesla : Movable
    {
        public double getSpeed()
        {
            return 300;
        }
        public double getPrice()
        {
            return 500;
        }
    }
}
