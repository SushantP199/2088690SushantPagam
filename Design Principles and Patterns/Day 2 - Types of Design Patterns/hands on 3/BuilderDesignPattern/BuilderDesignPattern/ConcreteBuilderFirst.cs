using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesignPattern
{
    class ConcreteBuilderFirst : Builder
    {
        private Fruits fruits = new Fruits();
        public override void BuildPackageLight()
        {
            fruits.Add("Apple");
            fruits.Add("Lemon");
        }

        public override void BuildPackageHeavy()
        {
            fruits.Add("Watermelon");
            fruits.Add("Dragonfruit");
        }

        public override Fruits GetFruits()
        {
            return fruits;
        }
    }
}
