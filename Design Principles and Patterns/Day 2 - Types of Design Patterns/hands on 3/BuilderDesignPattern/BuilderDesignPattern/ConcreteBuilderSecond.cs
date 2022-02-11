using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesignPattern
{
    class ConcreteBuilderSecond:Builder
    {
        private Fruits fruits = new Fruits();
        public override void BuildPackageLight()
        {
            fruits.Add("Apple");
        
        }

        public override void BuildPackageHeavy()
        {
            fruits.Add("Banana");
            fruits.Add("Papaya");
        }

        public override Fruits GetFruits()
        {
            return fruits;
        }
    }
}
