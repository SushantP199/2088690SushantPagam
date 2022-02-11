using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeDesignPattern

{
    class Shape : IShape
    {
        public void draw()
        {
            Console.WriteLine("Draw Circle"); ;
        }
    }
    public class Square : IShape
    {
        public void draw()
        {
            Console.WriteLine("Draw Square");
        }
    }

    public class Rectangle : IShape
    {
        public void draw()
        {
            Console.WriteLine("Draw Rectangle"); ;
        }
    }

}
