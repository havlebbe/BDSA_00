using System;

namespace leap_year_calculator
{
    public class LeapYearCalculator
    {
        static void Main(string[] args) 
        {

        }

        public bool IsLeapYear(int year) {
            bool isLeap = false;
            if (year % 4 == 0) isLeap = true;
            if (year % 100 == 0) isLeap = false;
            if (year % 400 == 0) isLeap = true;

            return isLeap;
        }
    }
}
