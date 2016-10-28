using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElse_v2_27102016
{
    class Program
    {
        static void Main()
        {
            int x = 5;
            int y = 2;

            if (x >1 && y > 2)
            {
                Console.WriteLine("X is greater than one AND Y is greater than two");
            }
            if (x > 5 || y < 4)
            {
                Console.WriteLine("X is greater than five OR Y is less than four");
            }
            if ((x > 2 && y < 3) || x == 2)
            {
                Console.WriteLine("this is true when x is greater than two and y is less than three, OR x equals 2");
            }
            Console.ReadLine();
        }
    }
}
