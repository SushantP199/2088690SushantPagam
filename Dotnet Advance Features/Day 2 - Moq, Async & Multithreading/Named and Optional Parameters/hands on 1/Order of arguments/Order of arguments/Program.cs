using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_of_arguments
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Cohort Name");
            string cohort_name=Console.ReadLine();

            Console.WriteLine("Enter the Genc count ");
            int count = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Mode");
            string mode = Console.ReadLine();   

            Console.WriteLine("Enter your  Track");
            string track=Console.ReadLine();

            Console.WriteLine("Enter the Current Module");
            string module=Console.ReadLine();

            Program p = new Program();

            // passing paramteres in same order 
            p.GetCohortDetails(cohort_name, count, mode, track, module);

            // passing parameteres in different order 
            p.GetCohortDetails(mode, count, track, module, cohort_name);

            // Using named parameters in different order
            p.GetCohortDetails(mode:mode, track :track, cohort_name:cohort_name, module:module, count: count);
        }

        public void GetCohortDetails(string cohort_name, int count,string mode, string track,string module)
        {
            Console.WriteLine($"It is {cohort_name} with {count} GenCs undergoing training for {mode} thru {track}. The current module of training is {module}");
        }
    }
}
