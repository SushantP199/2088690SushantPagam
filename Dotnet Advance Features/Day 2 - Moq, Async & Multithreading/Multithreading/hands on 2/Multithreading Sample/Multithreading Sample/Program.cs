using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreading_Sample
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***MultiThreading Program***\n");
            Console.WriteLine($"Main Thtread Started .ThreadId = {Thread.CurrentThread.ManagedThreadId}");

            Printer printer = new Printer();
            WaitCallback workItem = new WaitCallback(PrintTheNumbers);

            for(int i = 0; i < 10; i++)
            {
                ThreadPool.QueueUserWorkItem(workItem,printer);
            }

            Console.WriteLine("All task queued");
            Console.ReadLine();
        }

        static void PrintTheNumbers(object state)
        {
            Printer task=(Printer)state;
            task.PrintNumber();
        }
    }
}
