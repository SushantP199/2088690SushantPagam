using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles
{
     public class PhoneProcessOrder : IProcessOrder
    {
        
        public void ProcessOrder(string modelName)
        {
            Console.WriteLine($"{modelName} order accepted ..!");
        }
    }
}
