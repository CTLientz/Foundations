using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTheory_27102016
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Left Justified : [{0, -20}]", 15);
            Console.WriteLine("Right Justified : [{0, 10}]", 22);
            //the second part of {} is the space between the [] brackets. 0 is the middle, 
            //and the - or lack of - indicated how many spaces befor the middle to place the number
            //so... how do you put it in the middle?
            Console.WriteLine("Cendered : [{0,}]", 14);
            Console.ReadLine();
        }
    }
}
