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
    }
}
