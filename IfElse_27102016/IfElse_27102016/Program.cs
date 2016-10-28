using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElse_27102016
{
    class Program
    {
        static void Main()
        {
            int x = 2;
            int y = 1;

            if (x == y)
            {
                Console.WriteLine("You totally know that x=y, so why did you ask? ");
            }
            if (x != y)
            {
                Console.WriteLine("YOur math is as off as the concept of Trump as a feminist.");
            }

            if (x > y)
            {
                Console.WriteLine("x is greater than y, just go ask your womens' studies teacher.");
            };

            if (x < y)
            {
                Console.WriteLine("y is greater than x, or at the very least y earns more.");
            }

            if (x >= y)
            {
                Console.WriteLine("x is greater than or equal to y, which is a mathy way of saying Gloria Steinem Wrote This");
            }

            if (x <= y)
            {
                Console.WriteLine("x is less than or equal to y, just like title IX funding");
            }


            Console.ReadLine();
        }
    }
}
