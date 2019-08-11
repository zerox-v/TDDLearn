using System;

namespace FizzBuzz
{
    public class FizzBuzz
    {

        public string Print(int i)
        {
            var result = "";
            if (i % 3 == 0 || i.ToString().Contains("3")) result += "Fizz";
            if (i % 5 == 0|| i.ToString().Contains("5") ) result += "Buzz";
            if (result == "") result = i.ToString();
            return result;
        }

       
    }
}
