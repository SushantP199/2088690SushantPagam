using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesignPattern
{
    public abstract class Builder
    {
        public abstract void BuildPackageLight();

        public abstract void BuildPackageHeavy();
       
        public abstract Fruits GetFruits();
    }
}
