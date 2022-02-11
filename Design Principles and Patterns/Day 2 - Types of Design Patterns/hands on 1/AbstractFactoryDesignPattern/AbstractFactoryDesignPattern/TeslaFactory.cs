using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern
{
    public class TeslaFactory : Factory
    {
        public override Headlight makeHeadlight()
        {
            return new TeslaHeadlight();
        }

        public  override  Tire makeTire()
        {
            return new TeslaTire();
        }
    }
}
