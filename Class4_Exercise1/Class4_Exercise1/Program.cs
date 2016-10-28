using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class4_Exercise1
{
    class Program
    {
        static void Main()

        {
            //Ask the user to enter a character
            Console.WriteLine("This is cool!  Want to find out the ASCII number for your favorite letter?  Great!  What is your favorite letter?");
            // read and store to input from the user (from console)
            string str = Console.ReadLine();
            //Make sure you grab the first character that they entered (regardless)
            char ch = str[0];
            //grab or convert character into an ascii number.  
            //I'm going from 2 bytes to intiger 4 bytes
            int myascii = (int)ch;
            //show the integer/result onto the console

            Console.WriteLine("Here you go! The ASCII value of {0} is {1}", ch, myascii);
            Console.ReadLine();
        }
    }
}
