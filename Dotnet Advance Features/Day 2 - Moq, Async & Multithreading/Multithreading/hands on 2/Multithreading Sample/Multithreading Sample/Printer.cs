using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreading_Sample
{
    public class Printer
    {
        private object LockToken = new object();

        public void PrintNumber()
        {
            lock (LockToken)
            {
                // Display thread info
                Console.WriteLine($"Thread-> {Thread.CurrentThread.ManagedThreadId} started @{DateTime.Now.ToLongTimeString()} and executing printNumber() method");

                Console.WriteLine("Your Number");
                for(int i = 0; i < 10; i++)
                {
                    Console.WriteLine("{0} ", i);
                    Thread.Sleep(1000);
                }
                Console.WriteLine();
            }
        }
    }
}
