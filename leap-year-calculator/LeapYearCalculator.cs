using System;

namespace leap_year_calculator
{
    public class LeapYearCalculator
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("Please type a year to check if it is leap:");
            try 
            {
                int year = Convert.ToInt32(Console.ReadLine());
                if (IsLeapYear(year)) Console.WriteLine("yay");
                else Console.WriteLine("nay");
            } 
            catch(FormatException) 
            {
                Console.WriteLine("This is not a year");
            } 
            catch(ArgumentException)
            {
                Console.WriteLine("Year must be after 1582");
            }
        }

        public static bool IsLeapYear(int year)  
        {
            if (year < 1582) 
            {
                throw new ArgumentException("Year must be after 1582");
            }
            bool isLeap = false;
            if (year % 4 == 0) isLeap = true;
            if (year % 100 == 0) isLeap = false;
            if (year % 400 == 0) isLeap = true;

            return isLeap;
        }
    }
}
