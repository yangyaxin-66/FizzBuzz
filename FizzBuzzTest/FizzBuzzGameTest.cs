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
    }
}