using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timeofday

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your Name:");
            String userName = Console.ReadLine();
            Console.WriteLine("Thanks, {0} the time is {1}", userName, System.DateTime.Now.TimeOfDay);
            Console.WriteLine("Press andy key to quit.");
            Console.ReadKey();

        }
    }
}