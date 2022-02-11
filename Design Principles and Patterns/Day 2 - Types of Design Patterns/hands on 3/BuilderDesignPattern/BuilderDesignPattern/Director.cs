using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesignPattern
{
    public class Director
    {
        public void Construct(Builder builder)
        {
            builder.BuildPackageLight();
            builder.BuildPackageHeavy();
        }
    }
}
