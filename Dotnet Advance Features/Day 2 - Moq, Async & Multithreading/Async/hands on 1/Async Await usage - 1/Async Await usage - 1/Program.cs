using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Async_Await_usage___1
{
    internal class Program
    {
        static  void Main(string[] args)
        {
            PrintMessage();

            Console.WriteLine("this is main method");
            Thread.Sleep(4000);
        }

        static async void PrintMessage()
        {
            Task<string> task =new Task<string>(ReturnMessage);

            task.Start();

            string message = await task;
            Console.WriteLine(message);
        }

        static string ReturnMessage()
        {
            Console.WriteLine("Eneter the message");
            string message=Console.ReadLine();

            Thread.Sleep(300);

            return message;
        }
    }
}
