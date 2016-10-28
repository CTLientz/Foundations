// File: while.cs
using System;

class TestWhile
{
    static void Main()
    {
        int x;
        int sum = 0;

        x = 1; //you must initialize the variable before you begin
        while (x < 1000)
        {//start of the loop
            sum = sum + x;

            if (sum > 20)
            {
                // exits the loop
                break;
            }

            if (sum == 10)
            {
                // skips remainder of loop body
                continue;
            }

            Console.WriteLine("x is {0} and sum is {1}", x, sum);

            x++;//incrament 
        }//end of the loop

        Console.ReadLine();
    }
}