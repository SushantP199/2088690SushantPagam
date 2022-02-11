using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern
{ 
    public class TataFactory:Factory
    {
        public override Headlight makeHeadlight()
        {
            return new TataHeadlight();
        }

        public override Tire makeTire()
        {
            return new TataTire();
        }
    }
}
