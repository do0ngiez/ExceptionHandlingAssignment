using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersList = new List<int> { 10, 20, 30, 40, 50 };

            Console.WriteLine("Enter a number to divide each number in the list by:");
            string userInput = Console.ReadLine();

            try
            {
                int divisor = int.Parse(userInput);

                foreach (int number in numbersList)
                {
                    double result = (double)number / divisor;
                    Console.WriteLine($"{number} divided by {divisor} is {result}");
                    Console.ReadLine();
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Cannot divide by zero.");
                Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter a valid number.");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
                Console.ReadLine();
            }

            Console.WriteLine("Program execution has continued beyond the try/catch block.");
            Console.ReadLine();
        }
    }
}
