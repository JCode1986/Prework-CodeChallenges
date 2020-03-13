using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Prework_CodeChallenges
{
    class Program
    {
        public static void GetNumbersInArray(int[] arr)
        {
            foreach (int num in arr) 
            {
                Console.Write($"{num}, ");
            }
            Console.WriteLine();
        }
        public static int ArrayMaxResult(int[] arr, int num)
        {
            int count = 0;
            foreach(int i in arr)
            {
                if(i == num) count++;
            }
            return (count > 1) ? count * num : num;
        }

        public static string LeapYearCalculator(int year)
        {
            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0)) return $"{year} is a Leap Year.";
            else 
            return $"{year} is not a Leap Year"; 
        }

        public static string PerfectSequence(int[] arr)
        {
            int sum = 0;
            int product = 1;
            foreach(int num in arr)
            {
                sum += num;
                product *= num;
            }
            return (sum == product) ? "Yes" : "No"; 
        }

        public static string SumOfRows(int[,] arr)
        {
            int[] result = new int[3];
            int rowSum = 0;
            string str = "\nProblem #4\n";
            for (int i = 0; i < 3; i++)
                {
                for (int j = 0; j < 5; j++)
                {
                    rowSum += arr[i, j];
                }
                    result[i] = rowSum;
                    str += $"Row Sum for {i + 1} sub array is {rowSum}\n";
                    rowSum = 0;
                }
            return str;
        }
        static void Main(string[] args)
        {
            //Problem #1
            Console.WriteLine("Problem #1");
            int [] array = {1, 2, 3, 4, 4, 4, 5};
            int num = 4;
            Console.WriteLine($"Result: {ArrayMaxResult(array, num)}");
            Console.WriteLine();
            
            //Problem #2
            Console.WriteLine("Problem #2");
            int[] years = {1986, 2000, 1453, 1993};
            Console.WriteLine($"Result: {LeapYearCalculator(years[0])}");
            Console.WriteLine();

            //Problem #3
            Console.WriteLine("Problem #3");
            int[] arr1 = {1, 2, 3};
            int[] arr2 = {0, 0, 0};
            int[] arr3 = {1, 2, 3, 4, 5};
            string answer = PerfectSequence(arr1);
            Console.WriteLine($"Result: {answer}");

            //Problem #4
            int[,] mArray = new int[3, 5]
            { 
                { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 } 
            };
            Console.WriteLine(SumOfRows(mArray));
        }
    }
}
