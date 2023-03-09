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
    }
}
