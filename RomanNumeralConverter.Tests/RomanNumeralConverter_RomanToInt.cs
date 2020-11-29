using System;
using Xunit;

namespace RomanNumeralConverterApp.Tests
{
    public class RomanNumeralConverter_RomanToInt
    {
        [Theory]
        [InlineData("XX")]
        [InlineData("XVii")]
        [InlineData("MMM")]
        public void RomanToInt_IsRomanNumeral(string value)
        {
            RomanNumeralConverter romanNumeral = new RomanNumeralConverter();
            int number = romanNumeral.RomanToInt(value);

            Assert.NotEqual(-1, number);
        }

        [Theory]
        [InlineData("MMMMM")]
        [InlineData("ixi")]
        [InlineData("DDD")]
        [InlineData("DD D")]
        [InlineData("*II")]
        public void RomanToInt_NotRomanNumeral(string value)
        {
            RomanNumeralConverter romanNumeral = new RomanNumeralConverter();
            int number = romanNumeral.RomanToInt(value);

            Assert.Equal(-1, number);
        }
    }
}
