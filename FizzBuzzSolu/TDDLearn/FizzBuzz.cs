using System;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string Print(int i)
        {

            if (i % 3 == 0 && i % 5 == 0)
            {
                return "FizzBuzz";
            }
            else if (i % 3 == 0)
            {
                return "Fizz";
            }
            else if (i % 5 == 0)
            {
                return "Buzz";

            }
            return i.ToString();
        }


    }
}
