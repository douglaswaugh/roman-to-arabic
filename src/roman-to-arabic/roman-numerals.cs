using System;
using System.Collections.Generic;

namespace RomanNumeralsLibrary
{
    public class RomanNumerals
    {
        public int Convert(string numerals)
        {
            var romanArabicMappings = new Dictionary<char, int> 
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000},
            };

            var arabicCounter = 0;

            for(int i = 0; i < numerals.Length; i++)
            {
                if(i+1 < numerals.Length && romanArabicMappings[numerals[i]] < romanArabicMappings[numerals[i+1]])
                {
                    arabicCounter -= romanArabicMappings[numerals[i]];
                }
                else
                    arabicCounter += romanArabicMappings[numerals[i]];
            }
            
            return arabicCounter;
        }
    }
}
