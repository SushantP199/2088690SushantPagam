using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles
{
    class PhoneOrderRepair : IOrderRepair
    {
        public void AccessoryRepairProcess(string accessoryType)
        {
            Console.WriteLine($"{accessoryType} repair accepted ..!");
        }
        
        
        public void PhoneRepairProcess(string modelName)
        {
            Console.WriteLine($"{modelName} repair accepted ..!");
        }
    }
}
