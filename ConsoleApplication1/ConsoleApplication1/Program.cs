using System;
class TestMain
{
    static void Main();
    {
    //1.  ask the user to input a number on the sconsole
    Console.Write ("What is your favorite number?    ");
   
    //2. read the number from console and store to string
    string str;
    str = Console.ReadLine();

    //3. convert the number from string to numaric format
    int x = int.Parse(str);

    //4. do the calculation  5*x*x +6
    int iResult;
    IAsyncResult = (int)((5 * x * x) + 6);
    
    //5. convert the result back to string or it can be done automatically if using consult.write to show on the screen

    Console.WriteLine ("Abracadabra, now your favore number is {0}", iResult);
      
    Console.ReadLine(); 
    }
}
