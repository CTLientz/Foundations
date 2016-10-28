using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSwitch_27102016
{
    class Program
    {
        static void Main()
        {
            int x = 5;

            switch (x)
            {
                case 1:
                    Console.WriteLine("x is 1");
                    break;
                case 2:
                    Console.WriteLine("x is 2");
                    break;
                case 3:
                    Console.WriteLine("x is 102");
                    break;
                case 4: 
                    Console.WriteLine("x is 3 or 4");
                    break;

                default:
                    Console.WriteLine("x is not 1 or 2 or 3 or 4");
                    Console.ReadLine();
            }
            string month = "Jan";
            switch (month)
            {
                case "Jan":
                    Console.WriteLine("January patron god is Juno who looks after the women of Rome.");
                    break;
                default:
                    Console.WriteLine("January is too cold for this nonsense.");
                    Console.ReadLine();
            }
        }
    }
}
