using Xunit;
using procents_operations;

namespace tests_of_percent_operations
{
    public class UnitTest1
    {
        [Fact]
        public void Returning_the_correct_percentage()
        {
           double number = 100;
           double percent = 10; 
           double result = 10;

           double actual = Class1.PercentageOfTheNumber(number, percent);

           Assert.Equal(result, actual);
        }

        [Fact]
        public void Returning_the_correct_numbeer()
        {
            double number = 10;
            double percent = 10;
            double result = 100;

            double actual = Class1.FindTheOriginalNumber(number, percent);

            Assert.Equal(result, actual);
        }
    }
}