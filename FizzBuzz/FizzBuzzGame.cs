using System;
using System.Reflection.Metadata.Ecma335;
using System.Threading;

namespace FizzBuzz
{
    public class FizzBuzzGame
    {
        private string output;

        public static string CountOff(int givenNumber)
        {
            if (givenNumber % 3 == 0 && givenNumber % 5 == 0)
            {
               return "FizzBuzz";
            }
            else if (givenNumber % 3 == 0 && givenNumber % 5 != 0)
            {
                return "Fizz";
            }
            else if (givenNumber % 3 != 0 && givenNumber % 5 == 0)
            {
                return "Buzz";
            }
            else
            {
                return givenNumber.ToString();
            }
        }
    }
}
