using System;

namespace leap_year_calculator
{
    public class LeapYearCalculator
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("please type a year and press enter to check if it is a leap year:");
            int year = Convert.ToInt32(Console.ReadLine());
            if (IsLeapYear(year)) Console.WriteLine("yay");
            else Console.WriteLine("nay");
        }

        public static bool IsLeapYear(int year) {
            bool isLeap = false;
            if (year % 4 == 0) isLeap = true;
            if (year % 100 == 0) isLeap = false;
            if (year % 400 == 0) isLeap = true;

            return isLeap;
        }
    }
}
