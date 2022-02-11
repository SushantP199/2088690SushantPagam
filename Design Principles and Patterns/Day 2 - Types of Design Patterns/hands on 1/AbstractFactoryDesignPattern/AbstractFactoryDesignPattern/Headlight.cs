using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern
{
    public abstract class Headlight
    {
        string headlightType;

        public Headlight(string headlight)
        {
            headlightType = headlight;
        }

        public string GetHeadlight()
        {
            return headlightType;
        }

    }
}
