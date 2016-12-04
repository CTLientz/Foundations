using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_Lientz_2016
//This will be an inventory system for tea
/*   Item #
Description
Price per item
Quantity on hand
Our cost per item
Value of item(price* quantity on hand) */
{
    public struct Tea
    { 
        public string TeaName;
        public double CostOfTea;
        public double PriceOfTea;
        public int QuantOfTea;
        public double ValueOfTea;
    }
    class Program
    {
        static void Main()
        {
            var numberOfTeas = 0;

            var tea = new Tea[100];

            while (true)
            {
                Console.WriteLine("Would you like to A (Add new tea), B (Blast Out a List of Tea), C (Change type of tea), D (Delete some tea) E (Exit).");

                string choice = Convert.ToString(Console.ReadLine());

                choice = choice.ToUpper(); 

                switch (choice) 
                {
                    case "A":  //add tea
                        {   
                            Console.WriteLine("Name your tea:  ");
                            var TeaName = Console.ReadLine();
                            
                            Console.WriteLine("What is the cost?  ");
                            var LineInput = Console.ReadLine();
                            double CostOfTea = double.Parse(LineInput);

                            Console.WriteLine("What is the Price to the Customer?  ");
                            LineInput = Console.ReadLine();
                            double PriceOfTea = double.Parse(LineInput);

                            Console.WriteLine("How many pounds?  ");
                            LineInput = Console.ReadLine();
                            int QuantOfTea = int.Parse(LineInput);

                            double ValueOfTea = (PriceOfTea * QuantOfTea);

                            tea[numberOfTeas].TeaName = TeaName; 
                            tea[numberOfTeas].CostOfTea = CostOfTea;
                            tea[numberOfTeas].PriceOfTea = PriceOfTea;
                            tea[numberOfTeas].QuantOfTea = QuantOfTea;
                            tea[numberOfTeas].ValueOfTea = ValueOfTea;

                            numberOfTeas++;
                            
                            break;

                        }
                    case "B": //List
                        {
                            if (numberOfTeas == 0)
                            {
                                Console.WriteLine("No teas have been added yet. Without tea, there is little joy in the world...");
                                break;

                            }
                            Console.WriteLine("Item#    TeaName        Cost    Price   Quantity   Value");
                            for (int index = 0; index < numberOfTeas; index++) 
                            {
                                
                                Console.WriteLine("  {0, -7} {1, -12} ${2, -8}${3, -8} {4, -10} ${5, -6}", index + 1, tea[index].TeaName, tea[index].CostOfTea, tea[index].PriceOfTea, tea[index].QuantOfTea, tea[index].ValueOfTea );
                            } 
                            break;
                        }

                    case "C": //change type of tea
                        {
                            if (numberOfTeas == 0)
                            {
                                Console.WriteLine("No teas have been added yet. Tea really makes the world goes 'round...");
                                break;
                            }

                            Console.WriteLine("Which item number do you want to change?   ");
                            var LineInput = Console.ReadLine();
                            int ItemNumber = int.Parse(LineInput);
                            ItemNumber--;

                            Console.Write("You currently have {0}.  What's the new name?  ", tea[ItemNumber].TeaName);
                            tea[ItemNumber].TeaName = Console.ReadLine();

                            Console.WriteLine("The cost was ${0}.  What is the new cost?  ", tea[ItemNumber].CostOfTea);
                            LineInput = Console.ReadLine();
                            tea[ItemNumber].CostOfTea = double.Parse(LineInput);

                            Console.WriteLine("The cost to customer was ${0}. What is the new price to the Customer?  ", tea[ItemNumber].PriceOfTea);
                            LineInput = Console.ReadLine();
                            tea[ItemNumber].PriceOfTea = double.Parse(LineInput);

                            Console.WriteLine("The previous weight was {0}.  How many pounds would you like now?  ", tea[ItemNumber].QuantOfTea);
                            LineInput = Console.ReadLine();
                            tea[ItemNumber].QuantOfTea = int.Parse(LineInput);

                            tea[ItemNumber].ValueOfTea = (tea[ItemNumber].PriceOfTea * tea[ItemNumber].QuantOfTea);
                            break;
                        }


                    case "D":  //delete some tea from your order
                        {
                            if (numberOfTeas == 0)
                            {
                                Console.WriteLine("Nothing left to delete.  Obviously.");
                                break;
                            }

                            Console.WriteLine("Which item number do you want to delete?   ");
                            var LineInput = Console.ReadLine();
                            int ItemNumber = int.Parse(LineInput);
                            ItemNumber--;



                            for (var index = ItemNumber; index < numberOfTeas; index++) 
                            {

                                tea[index] = tea[index + 1];
                            }

                            numberOfTeas--;

                            break;
                        }
                    case "E":   //list change your tea order
                        {
                            Console.WriteLine("Goodbye World");
                            Environment.Exit(0);
                            break;
                        }
                    default: 
                        {
                            Console.WriteLine("You totally screwed up.  Try again. [{0}].", choice);
                            break;
                        }
                }
            }
        }

    }
}


