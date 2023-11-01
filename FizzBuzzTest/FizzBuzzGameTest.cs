using FizzBuzz;
using Xunit;

namespace FizzBuzzTest
{
    public class FizzBuzzGameTest
    {
        [Fact]
        public void Should_return_normalNumber_when_countof_given_normalNumber()
        {
            //given
            int givenNumber = 1;
            //when
            string result = FizzBuzzGame.CountOff(givenNumber);

            //then
            Assert.Equal("1", result);
        }

        [Fact]
        public void Should_return_normalNumber_when_countof_given_3mutipleNumber()
        {
            //given
            int givenNumber = 3;
            //when
            string result = FizzBuzzGame.CountOff(givenNumber);

            //then
            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void Should_return_normalNumber_when_countof_given_5mutipleNumber()
        {
            //given
            int givenNumber = 5;
            //when
            string result = FizzBuzzGame.CountOff(givenNumber);

            //then
            Assert.Equal("Buzz", result);
        }

        [Fact]
        public void Should_return_normalNumber_when_countof_given_3and5mutipleNumber()
        {
            //given
            int givenNumber = 15;
            //when
            string result = FizzBuzzGame.CountOff(givenNumber);

            //then
            Assert.Equal("FizzBuzz", result);
        }
    }
}