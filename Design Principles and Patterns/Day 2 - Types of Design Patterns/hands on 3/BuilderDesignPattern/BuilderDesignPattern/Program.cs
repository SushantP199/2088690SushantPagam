using System;

namespace BuilderDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            Director director = new Director();

            Builder concreteBuilderOne = new ConcreteBuilderFirst();
            director.Construct(concreteBuilderOne);
            Fruits concreteBuilderOneFruits = concreteBuilderOne.GetFruits();
            concreteBuilderOneFruits.Display();

            Builder concreteBuilderTwo = new ConcreteBuilderSecond();

            director.Construct(concreteBuilderTwo);
            Fruits concreteBuilderTwoFruits = concreteBuilderTwo.GetFruits();
            concreteBuilderTwoFruits.Display();

            Console.ReadLine();
        }
    }
}
