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

                var middle = GetMiddleCharacter(inputString);
                if (middle != null)
                    Console.WriteLine($"The middle character(s): {middle}");
                else
                    Console.WriteLine("Your input did not contain any characters.  Re-run the program to try again.");
            }
        }

        private static string GetMiddleCharacter(string input)
        {
            int inputStringLength = input.Length;
            if (inputStringLength != 0)
            {
                if (inputStringLength % 2 == 0)
                {
                    // even number of characters
                    var start = inputStringLength / 2;
                    return input.Substring(start - 1, 2);
                }
                else
                {
                    // odd number of characters
                    var start = (inputStringLength - 1) / 2;
                    return input.Substring(start, 1);
                }
            }
            else
            {
                return null;
            }
        }
    }
}
