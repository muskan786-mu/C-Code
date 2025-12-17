using System.Reflection.Metadata;
using System;

namespace ShapeAreaCalculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Shape Area Calculator");
            Console.WriteLine("Enter dimensions in the same unit(e.g., cm,m,inches).");
            Console.WriteLine();

            while(true)
            {
                Console.WriteLine("Choose a shape:");
                Console.WriteLine("1) Square");
                Console.WriteLine("2) Rectangle");
                Console.WriteLine("3) Triangle");
                Console.WriteLine("4) Circle");
                Console.WriteLine("5) Parallelogram");
                Console.WriteLine("6) Trapezoid");
                Console.WriteLine("7) Ellipse");
                Console.WriteLine("Q) Quit");
                Console.WriteLine("Your choice:");


                // Reads a full line of input from the user.
                // The null-conditional operator '?.' prevents a crash if ReadLine returns null

                string choice = Console.ReadLine()?.Trim().ToLower();

                if(choice == "q")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
                double area;

                switch(choice)
                {
                    case "1":
                        // Calls a helper method that asks the user for a positive number (with validation).
                        double side = ReadPositiveDouble("Enter side length:");
                        area = side * side;
                        PrintArea("Square", area);
                        break;
                    case "2":
                        double length = ReadPositiveDouble("Enter length:");
                        double width = ReadPositiveDouble("Enter width:");
                        area = length * width;
                        PrintArea("Rectangle", area);
                       
                        break;
                    case "3":
                        double baseLen = ReadPositiveDouble("Enter base:");
                        double height = ReadPositiveDouble("Enter height:");
                        area = 0.5 * baseLen * height;
                        PrintArea("Triangle", area);
                        break;
                    case "4":
                        double radius = ReadPositiveDouble("Enter radius:");
                        area = Math.PI * radius * radius;
                        break;
                    case "5":
                        double baseP = ReadPositiveDouble("Enter base:");
                        double heightP = ReadPositiveDouble("Enter height:");
                        area = baseP * heightP;
                        PrintArea("Parallelogram", area);
                        break;
                    case "6":
                        double a = ReadPositiveDouble("Enter base 1(a):");
                        double b = ReadPositiveDouble("Enter base 2(b):");
                        double h = ReadPositiveDouble("Enter height (h):");
                        area = 0.5 * (a + b) * h;
                        PrintArea("Trapezoid", area);
                        break;
                    case "7":
                        double ra = ReadPositiveDouble("Enter semi-major axis(a):");
                        double rb = ReadPositiveDouble("Enter semi-minor axis(b):");
                        area = Math.PI * ra * rb;
                        PrintArea("Ellipse", area);
                        break;
                    default:
                        Console.WriteLine("! Invalid option.Please choose 1-7 or Q.");
                        break;

                }
                Console.WriteLine();
            }
        }

        // </summary>
                static double ReadPositiveDouble(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (double.TryParse(input, out double value))
                {
                    if (value > 0)
                        return value;
                    else
                        Console.WriteLine("Value must be greater than 0. Try again.");
                }
                else
                {
                    Console.WriteLine("Invalid number. Try again.");
                }
            }
        }

        /// <summary>
        /// Prints the area formatted to 3 decimal places.
        /// </summary>
        static void PrintArea(string shapeName, double area)
        {
            Console.WriteLine($"✅ {shapeName} area: {area:F3} (square units)");
        }
    }
}


