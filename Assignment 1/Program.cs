using System;
using Utilities;

namespace Assignment_1
{
    class Program
    {
        

        
        static void Main(string[] args)
        {

            TextUtil myUtility = new TextUtil();
            string stringToReverse = "racecars";

            string stringToDisplay = myUtility.ReverseString(stringToReverse); //TextUtil is the static name
            Console.WriteLine(stringToDisplay);

            bool palindrome = myUtility.IsPalindrome(stringToReverse);

            if (palindrome)
                Console.WriteLine($"{stringToReverse} is a palindrome");
            else
                Console.WriteLine($"{stringToReverse} is not a palindrome");

            /*   for(int counter =10;counter >= 0; counter--)
               {
                   Console.WriteLine(counter);
               }*/

            string stringToDisplays = myUtility.ReverseStringVersion2(stringToReverse);
            Console.WriteLine(stringToDisplays);
        }
    }
}
