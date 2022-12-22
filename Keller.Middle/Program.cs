/*
 * Program to return the middle character of a string 
 * If string is even, return two middle characters
 * 
 */

using System;

namespace Keller.Middle
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter a string:");
                var inputString = Console.ReadLine();

                int inputStringLength = inputString.Length;
                if (inputStringLength != 0)
                {
                    if (inputStringLength % 2 == 0)
                    {
                        // even number of characters
                        var start = inputStringLength / 2;
                        var middleCharacter = inputString.Substring(start - 1, 2);
                        Console.WriteLine($"Middle characters are '{middleCharacter}'");
                    }
                    else
                    {
                        // odd number of characters
                        var start = (inputStringLength - 1) / 2;
                        var middleCharacter = inputString.Substring(start, 1);
                        Console.WriteLine($"Middle character is '{middleCharacter}'");
                    }
                }
                else
                {
                    Console.WriteLine("Your input did not contain any characters.  Re-run the program to try again.");
                }
            }
        }
    }
}
