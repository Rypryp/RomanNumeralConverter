using System;

namespace RomanNumeralConverterApp
{
    public class ConsoleInterface
    {
        public void Run()
        {
            RomanNumeralConverter rnc = new RomanNumeralConverter();

            do
            {
                Console.WriteLine("Enter Roman numeral: ");

                string input = Console.ReadLine();
                int value = rnc.RomanToInt(input);

                if (value == -1)
                {
                    ConsoleUtils.Error("Format error, please check the correct roman numeral format!");
                    continue;
                }
                else
                {
                    Console.WriteLine($"Arabic numeral is {value}");
                }
            }
            while (ConsoleUtils.Confirm("Try again?"));
        }
    }
}
