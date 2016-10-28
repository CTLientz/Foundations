// File: Switch.cs
using System;

class TestSwitch
{
    static void Main()

    {
        string strName;
    while(true)
        { 
        Console.Write("Please select a month (1-12):  ");
        strName = Console.ReadLine();

        string month = "0";
        int nDays = 0;
        

        switch (strName)
        {
            case "1":
                month = "January";
                nDays = 31;
                break;
            case "2":
                month = "February";
                nDays = 28;
                break;
            case "3":
                month = "March";
                nDays = 31;
                break;
            case "4":
                month = "April";
                nDays = 30;
                break;
            case "5":
                month = "May";
                nDays = 31;
                break;
            case "6":
                month = "June";
                nDays = 30;
                break;
            case "7":
                month = "July";
                nDays = 31;
                break;
            case "8":
                month = "August";
                nDays = 31;
                break;
            case "9":
                month = "September";
                nDays = 30;
                break;
            case "10":
                month = "October";
                nDays = 31;
                break;
            case "11":
                month = "November";
                nDays = 31;
                break;
            case "12":
                month = "December";
                nDays = 30;
                break;
            default:
                Console.WriteLine("Next time, try giving a number between 1-12");
                break;
                
        }
//end of switch
        Console.WriteLine("The month {0} has {1} days", month, nDays);
        Console.ReadLine();
        }
    }//end of main
}//end of class