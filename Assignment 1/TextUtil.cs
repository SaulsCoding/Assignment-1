using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class TextUtil
    {

        public string ReverseString(string inputString)
        {
            string reversedString = string.Empty;

            for (int counter = inputString.Length - 1; counter >= 0; counter--)
            {
                // Console.WriteLine(InputString[counter]);//Look at each char []-means array-string is in array of characters
                reversedString += inputString[counter];
                // reversedString = reversedString + InputString[counter];
            }

            return reversedString;
        }
        public string ReverseStringVersion2(string inputString)
        {
            string reversedString = string.Empty;

            int counter = inputString.Length - 1;

            while (counter >= 0)
            {
                reversedString += inputString[counter];
                counter--;
            }

            return reversedString;
        }

        public bool IsPalindrome(string inputString)
        {
            string reversedString = ReverseStringVersion2(inputString);

            if (inputString == reversedString)
                return true;
            else
                return false;
        }
    }
}
