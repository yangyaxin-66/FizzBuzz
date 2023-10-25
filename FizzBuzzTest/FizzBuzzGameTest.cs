using FizzBuzz;
using Xunit;

namespace FizzBuzzTest
{
    public class FizzBuzzGameTest
    {
        [Fact]
        public void Test1()
        {
            FizzBuzzGame game = new FizzBuzzGame();

            //then
            Assert.NotNull(game);
        }
    }
}