using System;
using Xunit;

namespace XUnitTestProject
{
    public class FizzBuzzUnitTest
    {
        [Theory]
        [InlineData(1, "1")]
        [InlineData(3, "Fizz")]
        [InlineData(13, "Fizz")]
        [InlineData(5, "Buzz")]
        [InlineData(15, "FizzBuzz")]
        [InlineData(35, "FizzBuzz")]
        [InlineData(51, "FizzBuzz")]
        public void Test1(int i, string str)
        {
            var fuzzBuzz = new FizzBuzz.FizzBuzz();
            var result = fuzzBuzz.Print(i);
            Assert.Equal(result,str);
        }
    }
}
