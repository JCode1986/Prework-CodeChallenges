using System;

namespace Prework_CodeChallenges
{
    class Program
    {
        static int ArrayMaxResult(int[] arr, int num)
        {
            int count = 0;
            foreach(int i in arr)
            {
                if(i == num) count++;
            }
            return (count > 1) ? count * num : num;
        }

        static string LeapYearCalculator(int year)
        {
            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0)) return $"{year} is a Leap Year.";
            else 
            return $"{year} is not a Leap Year"; 
        }
        static void Main(string[] args)
        {
            //Problem #1
            int [] array = {1, 2, 3, 4, 4, 4, 5};
            int num = 1;
            Console.WriteLine(ArrayMaxResult(array, num));
            
            //Problem #2
            int[] years = {1986, 2000, 1453, 1993};
            Console.WriteLine(LeapYearCalculator(years[0]));
        }
    }
}
