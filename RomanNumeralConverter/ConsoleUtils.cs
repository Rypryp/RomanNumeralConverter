using System;
namespace RomanNumeralConverterApp
{
    public class ConsoleUtils
    {
        public static bool Confirm(string message)
        {
            ConsoleKey response;
            do
            {
                Console.Write($"{ message } [y/n] ");
                response = Console.ReadKey(false).Key;

                if (response != ConsoleKey.Enter)
                {
                    Console.WriteLine();
                }
            }
            while (response != ConsoleKey.Y && response != ConsoleKey.N);

            return response == ConsoleKey.Y;
        }

        public static void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
