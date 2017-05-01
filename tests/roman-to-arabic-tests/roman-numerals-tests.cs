using System;
using Xunit;
using RomanNumeralsLibrary;

namespace roman_to_arabic_tests
{
    public class RomanNumeralsTests
    {
        [Theory]
        [InlineData("", 0)]
        [InlineData("I", 1)]
        [InlineData("II", 2)]
        [InlineData("IV", 4)]
        [InlineData("V", 5)]
        [InlineData("X", 10)]
        [InlineData("XXX", 30)]
        [InlineData("L", 50)]
        [InlineData("C", 100)]
        [InlineData("D", 500)]
        [InlineData("M", 1000)]
        [InlineData("MDCLXVI", 1666)]
        [InlineData("MCMXCIX", 1999)]
        public void Should_return_expected_arabic_for_numeral(string numeral, int expectedArabic)
        {
            var romanNumerals = new RomanNumerals();

            var arabic = romanNumerals.Convert(numeral);

            Assert.Equal(expectedArabic, arabic);
        }
    }
}