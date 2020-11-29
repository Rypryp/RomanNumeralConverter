using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace RomanNumeralConverterApp
{
    public class RomanNumeralConverter
    {
        private readonly Dictionary<char, int> RomanNumerals = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        private readonly string romanNumeralPattern = "^M{0,4}(CM|CD|D?C{0,3})(XC|XL|L?X{0,3})(IX|IV|V?I{0,3})$";
        private readonly Regex romanNumeralRegex;

        public RomanNumeralConverter()
        {
            romanNumeralRegex = new Regex(romanNumeralPattern);
        }

        public int RomanToInt(string romanNumeral)
        {
            romanNumeral = romanNumeral.ToUpper();

            if (!ValidateRomanNumeral(romanNumeral))
                return -1;

            int value = 0;
            for (int i = 0; i < romanNumeral.Length; i++)
            {
                if (i + 1 < romanNumeral.Length && RomanNumerals[romanNumeral[i]] < RomanNumerals[romanNumeral[i + 1]])
                {
                    value -= RomanNumerals[romanNumeral[i]];
                }
                else
                {
                    value += RomanNumerals[romanNumeral[i]];
                }
            }

            return value;
        }

        private bool ValidateRomanNumeral(string romanNumeral)
        {
            return romanNumeralRegex.IsMatch(romanNumeral);
        }
    }
}
