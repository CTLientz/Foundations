using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_FractoralOfInteger_27102016
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Let's find the fractoral of your favorite number.");
            Console.WriteLine("Enter a number:");

            string str = Console.ReadLine();

            int nNumb = int.Parse(str);
            int x;

            int nFact = 1;


            for (x = 1; x < nNumb; x++)
            {
                nFact = nFact * x;
            }
          

            Console.WriteLine("POOF!  The Fractoral of {0} is {1}.", nNumb, nFact);


            Console.ReadLine();

            //This is still a complicated problem for me.  I
        }
    }
}
