using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadStartSample
{
    public class Printer
    {
        public void PrintNumbers()
        {
            Console.WriteLine($" ->{Thread.CurrentThread.Name} is executing PrintNumber");
            Console.WriteLine("Your number: ");

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(2000);
            }
            Console.WriteLine();
        }
    }
}
