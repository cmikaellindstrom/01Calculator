using System;

namespace Calculator
{
    /// <summary>
    /// The class for this program
    /// </summary>
    internal class Program
    {
        // Name of this program
        const string ProgramName = "The Calculator 2000";

        /// <summary>
        /// The start point of this program
        /// </summary>
        /// <param name="args">Anything</param>
        static void Main(string[] args)
        {
            // Welcome the user to this program
            Console.WriteLine($"Welcome to {ProgramName}!");

            // Make a pause in the program
            Console.ReadKey();
        }
        /// <summary>
        /// Show the menu of this program and wait for user has make their choise
        /// </summary>
        /// <returns>The user choise</returns>
        static string Menu()
        {
            // Create a empty console window and show the name of this program
            Console.Clear();
            Console.WriteLine(ProgramName);

            // Create a empty row
            Console.WriteLine();

            // Show a menu header
            ShowAHeader("Menu");

            // Create a empty row
            Console.WriteLine();

            // Show the menu ifself
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Divsion");
            Console.WriteLine("4. Multiplication");
            Console.WriteLine("99. End of this program");

            // Create a empty row
            Console.WriteLine();

            // Ask the user about their choise
            Console.Write("Make your choise: ");
            return Console.ReadLine();
        }

        /// <summary>
        /// Show a header 
        /// </summary>
        /// <param name="title">The text in the header</param>
        static void ShowAHeader(string title) => Console.WriteLine($"********** {title} **********");
        
        /// <summary>
        /// Collecting some integer values
        /// </summary>
        /// <returns>A array of integer values</returns>
        static int[] GetSomeInteger()
        {
            // Variables for collecting some integer values
            string numbers = "";
            int[] result;

            // Ask the user about some integer values
            Console.WriteLine("Write some numbers and split them by coma: ");
            numbers = Console.ReadLine();

            // Convert a string value into a array of integer values
            result = Array.ConvertAll(numbers.Split(","),int.Parse);
            return result;
        }

        /// <summary>
        /// Calculate the sum from some integer values
        /// </summary>
        static void Addition()
        {
            // Show a header for the addition function
            ShowAHeader("Addition");

            // Variables for calculation of the sum
            int result = 0;
            int[] numbers = GetSomeInteger();

            // Calculate the sum and show the result in console window
            Console.Write("The sum from ");
            for(int x = 0; x < numbers.Length; x++) 
            {
                // Add value to the result
                result += numbers[x];

                // Show the number that added to result
                Console.Write(numbers[x]);
                if (x != numbers.Length - 1)
                    Console.Write(", ");
            }
            Console.WriteLine($" are {result}.");
        }
        /// <summary>
        /// Calculate the difference from some integer values
        /// </summary>
        static void Subtraction()
        {
            // Show a header for the subtraction function
            ShowAHeader("Subtraction");

            // Variables for calculation of the difference
            int result = 0;
            int[] numbers = GetSomeInteger();

            // Calculate the difference and show the result in console window
            Console.Write("The difference from ");
            for(int x = 0; x < numbers.Length; x++)
            {
                // Check if the number are the first number then set or reduce the result with numbers[x] value
                if(x == 0)
                    result = numbers[x];
                else
                    result -= numbers[x];

                // Show the number that set or reduce the result
                Console.Write(numbers[x]);
                if (x != numbers.Length - 1)
                    Console.Write(", ");
            }
            Console.WriteLine($" are {result}.");
        }
        /// <summary>
        /// Calculate the qouta from two integer values
        /// </summary>
        static void Division()
        {
            // Show the header for division function
            ShowAHeader("Division");

            // Variables for calculation of the qouta
            int a, b;

            // Ask the user about two integer values
            Console.Write("Write a number: ");
            int.TryParse(Console.ReadLine(), out a);

            Console.Write("Write a other number and didn't allowed be zero: ");
            int.TryParse(Console.ReadLine(), out b);

            // Check if the secord number are zero or not
            if (b == 0)
                Console.WriteLine("The secord number are zero and don't allowed be zero.");
            else
                Console.WriteLine($"The qouta of {a} and {b} are {a/b}.");
        }
        /// <summary>
        /// Calculate the product of two integer values
        /// </summary>
        static void Multiplication()
        {
            // Show the header of the multiplication function
            ShowAHeader("Multiplication");

            // Variables for calculation of the product
            int a, b;

            // Ask the user about two integer values
            Console.Write("Write a number: ");
            int.TryParse(Console.ReadLine(), out a);

            Console.Write("Write a ohter number:");
            int.TryParse(Console.ReadLine(), out b);

            // Calculate the product and show the result in console window
            Console.WriteLine($"The product of {a} and {b} are {a * b}.");
        }
    }
}
