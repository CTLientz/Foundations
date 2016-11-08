// File: Switch.cs
using System;

class TestSwitch
{
    static void Main()
    {
        while (true) 
            { 
        Console.WriteLine("Is the ascii character of a key in group A, B, C, or D.");
        Console.WriteLine("Pick a key, any key... ");
        string str = Console.ReadLine();
        char asciiChar = str[0];
        int asciiNum = asciiChar;

        if (asciiNum <= 25)

        {
            Console.WriteLine("{0} is {1} and that is in group A (Between 1-25)", asciiChar, asciiNum);
        }
        else if (asciiNum >= 26 && asciiNum <= 75)
        {
            Console.WriteLine("{0} is {1} and that is in group B (Between 26 and 75)", asciiChar, asciiNum);
        }
        else if (asciiNum >= 76 && asciiNum <= 125)
        {
            Console.WriteLine("{0} is {1} and that is in group C (Between 76 and 125", asciiChar, asciiNum);
        }
        else if (asciiNum >= 126)
        {
            Console.WriteLine("{0} is {1} and that is in group D (126 or higher)", asciiChar, asciiNum);
        }
        else
        {
            Console.WriteLine("I don't know what you typed, but that totally crashed the system.");
        }
        
        Console.ReadLine();
        }
    }
}