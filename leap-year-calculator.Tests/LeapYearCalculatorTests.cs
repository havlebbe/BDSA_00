using System;
using Xunit;

namespace leap_year_calculator.Tests
{
    public class LeapYearCalculatorTests
    {
        [Fact]
        public void Year_4_is_leap()
        {
            LeapYearCalculator calculator = new LeapYearCalculator();
            Assert.True(calculator.IsLeapYear(4));
        }

        [Fact]
        public void Year_divisible_by_4_is_leap()
        {
            LeapYearCalculator calculator = new LeapYearCalculator();
            Assert.True(calculator.IsLeapYear(1072));
        }

        [Fact]
        public void Year_not_divisible_by_4_is_leap()
        {
            LeapYearCalculator calculator = new LeapYearCalculator();
            Assert.False(calculator.IsLeapYear(2011));
        }

        [Fact]
        public void Year_divisible_by_100_not_leap() 
        {
            LeapYearCalculator calculator = new LeapYearCalculator();
            Assert.False(calculator.IsLeapYear(900));  
        }

        [Fact]
        public void Year_divisible_by_400_is_leap() 
        {
            LeapYearCalculator calculator = new LeapYearCalculator();
            Assert.True(calculator.IsLeapYear(800));  
        }
    }
}
