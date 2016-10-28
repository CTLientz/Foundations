using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_27102016
{
    class Program
    {
        static void Main()

        {
            Console.Write("What is your favorite letter?");
            string str = Console.ReadLine();

            char ch = str[0];
            int ascii = (int)ch;

            //How do I pull the input string into my WriteLine?  
            //This would pull the first letter even if multiple letters are entered. 
            Console.WriteLine("The ASCII code for ___________ is {0}", ascii);


            Console.ReadLine();
        }
    }
}
