using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeDesignPattern
{
    public class ShapeMaker
    {
        public ShapeMaker()
        {

        }

        private Shape circle = new Shape();
        private Square square = new Square();
        private Rectangle rectangle = new Rectangle();

        public void drawCircle()
        {
            Console.WriteLine("Drawing Circle Started");
            circle.draw();
            Console.WriteLine("Circle Drawing Completed");
            Console.WriteLine();
        }

        public void drawSqaure()
        {
            Console.WriteLine("Drawing Sqaure Started");
            square.draw();
            Console.WriteLine("Square Drawing Completed");
            Console.WriteLine();
        }

        public void drawRectangle()
        {   
            Console.WriteLine("Drawing Rectangle Started");
            rectangle.draw();
            Console.WriteLine("Rectangle Drawing Completed");
            Console.WriteLine();
        }
    }
}
