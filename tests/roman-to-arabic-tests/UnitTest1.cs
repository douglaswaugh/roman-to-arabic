using System;
using Xunit;
using RomanNumeralsLibrary;

namespace roman_to_arabic_tests
{
    public class UnitTest1
    {
        [Fact]
        public void Should_return_0_for_empty_string()
        {
            var romanNumerals = new RomanNumerals();

            var arabic = romanNumerals.Convert(string.Empty);
            
            Assert.Equal(0, arabic);
        }

        [Fact]
        public void Should_return_I_for_1()
        {
            var romanNumerals = new RomanNumerals();

            var arabic = romanNumerals.Convert("I");

            Assert.Equal(1, arabic);
        }
    }
}