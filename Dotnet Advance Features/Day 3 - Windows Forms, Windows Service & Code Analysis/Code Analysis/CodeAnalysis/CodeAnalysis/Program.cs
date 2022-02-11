using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "John", "Bobby", "Chirag", "Denis", "Alfee", "Bond" };

            var nameOfB = names.Where(n => n.StartsWith("B"));
        }
    }
}
