using System;
using System.IO;
using Xunit;

namespace leap_year_calculator.Tests
{
    public class LeapYearCalculatorTests
    {
        [Fact]
        public void Year_4_is_leap()
        {
            Assert.True(LeapYearCalculator.IsLeapYear(4));
        }

        [Fact]
        public void Year_divisible_by_4_is_leap()
        {
            Assert.True(LeapYearCalculator.IsLeapYear(1072));
        }

        [Fact]
        public void Year_not_divisible_by_4_is_leap()
        {
            Assert.False(LeapYearCalculator.IsLeapYear(2011));
        }

        [Fact]
        public void Year_divisible_by_100_not_leap() 
        {
            Assert.False(LeapYearCalculator.IsLeapYear(900));  
        }

        [Fact]
        public void Year_divisible_by_400_is_leap() 
        {
            Assert.True(LeapYearCalculator.IsLeapYear(800));  
        }

        [Fact]
        public void Interface_says_yes_to_leap() 
        {
            var writer = new StringWriter();
            var input = new StringReader("1944");
            Console.SetOut(writer);
            Console.SetIn(input);
            LeapYearCalculator.Main(new string[0]);
            var output = writer.GetStringBuilder().ToString().Substring(65).Trim();

            Assert.Equal("yay", output);
        }

        [Fact]
        public void Interface_says_no_to_non_leap() 
        {
            var writer = new StringWriter();
            var input = new StringReader("1943");
            Console.SetOut(writer);
            Console.SetIn(input);
            LeapYearCalculator.Main(new string[0]);
            var output = writer.GetStringBuilder().ToString().Substring(65).Trim();

            Assert.Equal("nay", output);
        }
    }
}
