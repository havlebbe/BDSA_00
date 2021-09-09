using System;
using System.IO;
using Xunit;

namespace leap_year_calculator.Tests
{
    public class LeapYearCalculatorTests
    {

        [Fact]
        public void Year_divisible_by_4_is_leap()
        {
            Assert.True(LeapYearCalculator.IsLeapYear(1672));
        }

        [Fact]
        public void Year_not_divisible_by_4_is_not_leap()
        {
            Assert.False(LeapYearCalculator.IsLeapYear(2011));
        }

        [Fact]
        public void Year_divisible_by_100_not_leap() 
        {
            Assert.False(LeapYearCalculator.IsLeapYear(1700));  
        }

        [Fact]
        public void Year_divisible_by_400_is_leap() 
        {
            Assert.True(LeapYearCalculator.IsLeapYear(1600));  
        }

        [Fact]
        public void Console_Prints_Nay() 
        {
            var writer = new StringWriter();
            Console.SetOut(writer);

            var input = new StringReader("2021");
            Console.SetIn(input);

            LeapYearCalculator.Main(new string[0]);

            Assert.Contains("nay", writer.GetStringBuilder().ToString());
        }

        [Fact]
        public void Console_Prints_Yay() 
        {
            var writer = new StringWriter();
            Console.SetOut(writer);

            var input = new StringReader("2024");
            Console.SetIn(input);

            LeapYearCalculator.Main(new string[0]);
            Assert.Contains("yay", writer.GetStringBuilder().ToString());
        }

        [Fact]
        public void error_thrown_when_year_below_1582() 
        {
            Assert.Throws<ArgumentException>(() => LeapYearCalculator.IsLeapYear(4));
        }

        [Fact]
        public void interface_informs_when_input_not_int() 
        {
             var writer = new StringWriter();
            Console.SetOut(writer);

            var input = new StringReader("hello");
            Console.SetIn(input);

            LeapYearCalculator.Main(new string[0]);
            Assert.Contains("This is not a year", writer.GetStringBuilder().ToString());
        }
    }
}
