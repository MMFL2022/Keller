/*
 * Shape calculation program 
 * 
 * 
 */

using System;

namespace Keller
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                bool error = false;
                Console.WriteLine("Choose a shape - 1: Square, 2: Triangle, 3: Circle");
                var input = Console.ReadLine();
                int.TryParse(input, out int selection);

                if (selection > 0 && selection < 4)
                {
                    switch (selection)
                    {
                        case 1:
                            // square
                            // prompt user for input and store in variables to parse later
                            Console.WriteLine("You have chosen a square.");
                            Console.Write("Enter the square's length: ");
                            var inputLength = Console.ReadLine();
                            Console.Write("Enter the square's width: ");
                            var inputWidth = Console.ReadLine();

                            // try to parse the numbers entered by the user
                            float.TryParse(inputLength, out float length);
                            float.TryParse(inputWidth, out float width);

                            // if the values entered are valid, proceed to calculations
                            if (length > 0 && width > 0)
                            {
                                var square = new Square(length, width);
                                Console.WriteLine($"The square's area is {square.Area()}");
                                Console.WriteLine($"The square's perimeter is {square.Perimeter()}");
                            }
                            else
                            {
                                // one of the values is invalid
                                // figure out which one is invalid
                                if (length < 1)
                                    Console.WriteLine("You have entered an invalid length.");
                                else
                                    Console.WriteLine("You have entered an invalid width.");

                                Console.WriteLine("Press any key to start over.");
                                error = true;
                            }

                            break;
                        case 2:
                            // triangle
                            // prompt user for input and store in variables to parse later
                            Console.WriteLine("You have chosen a triangle.");
                            Console.Write("Enter the length of side A: ");
                            var inputSideA = Console.ReadLine();
                            Console.Write("Enter the length of side B: ");
                            var inputSideB = Console.ReadLine();
                            Console.Write("Enter the length of side C: ");
                            var inputSideC = Console.ReadLine();

                            // try to parse the numbers entered by the user
                            float.TryParse(inputSideA, out float sideA);
                            float.TryParse(inputSideB, out float sideB);
                            float.TryParse(inputSideC, out float sideC);

                            // if the values entered are valid, proceed to calculations
                            if (sideA > 0 && sideB > 0 && sideC > 0)
                            {
                                var triangle = new Triangle(sideA, sideB, sideC);
                                Console.WriteLine($"The triangle's area is {triangle.Area()}");
                                Console.WriteLine($"The triangle's perimeter is {triangle.Perimeter()}");
                                Console.WriteLine($"The triangle's height is {triangle.Height()}");
                            }
                            else
                            {
                                // one of the values is invalid
                                // figure out which one is invalid
                                if (sideA < 1)
                                    Console.WriteLine("You have entered an invalid value for side A.");
                                else if (sideB < 1)
                                    Console.WriteLine("You have entered an invalid value for side B.");
                                else
                                    Console.WriteLine("You have entered an invalid value for side C.");

                                Console.WriteLine("Press any key to start over.");
                                error = true;
                            }

                            break;
                        case 3:
                            // circle
                            // prompt user for input and store in variables to parse later
                            Console.WriteLine("You have chosen a circle.");
                            Console.Write("Enter the triangle's radius: ");
                            var inputRadius = Console.ReadLine();

                            // try to parse the number entered by the user
                            float.TryParse(inputRadius, out float radius);

                            // if the value entered is valid, proceed to calculations
                            if (radius > 0)
                            {
                                var circle = new Circle(radius);
                                Console.WriteLine($"The circle's area is {circle.Area()}");
                                Console.WriteLine($"The circle's circumference is {circle.Perimeter()}");
                                Console.WriteLine($"The circle's diameter is {circle.Diameter()}");
                            }
                            else
                            {
                                // the entered value for radius is invalid
                                Console.WriteLine("You have entered an invalid value for radius.");

                                Console.WriteLine("Press any key to start over.");
                                error = true;
                            }
                            break;
                        default:
                            break;
                    }

                    if (!error)
                        Console.WriteLine("Press any key to try another shape!");
                }
                else
                {
                    Console.WriteLine("You have entered an invalid selection, press any key to try again.");
                }

                Console.ReadLine();
            }
        }
    }
}
