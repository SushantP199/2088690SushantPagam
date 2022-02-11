using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesignPattern
{    
    //Product
    public class Fruits
    {
        private List<string> packages = new List<string>();

        public void Add(string fruit)
        {
            packages.Add(fruit);
        }

        public void Display()
        {
            if(packages.Count == 3)
            {
                Console.WriteLine("First Package");
            }
            else
            {
                Console.WriteLine("Second Package");
            }
            
            foreach(string s in packages)
            {  
                Console.Write(s + " | ");
            }

            Console.WriteLine();
        }
    }
}
