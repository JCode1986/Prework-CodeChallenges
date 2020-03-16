using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Prework_CodeChallenges
{
    class Program
    {
        public static string GetNumbersInArray(int[] arr)
        {
            string str = "Array: ";
            foreach (int num in arr) 
            {
                str += Convert.ToString(num);
                str += ", ";
            }
            return str;
        }
        
        // public static int ArrayMaxResult(int[] arr, int num)
        // {
        //     int count = 0;
        //     foreach(int i in arr)
        //     {
        //         if(i == num) count++;
        //     }
        //     return (count > 1) ? count * num : num;
        // }
        public static string ArrayMaxResult()
        {
            Console.WriteLine("Enter size of array: ");
            int sizeInput = int.Parse(Console.ReadLine());
            int[] arrayInput = new int[sizeInput]; 

            for(int i = 0; i < arrayInput.Length; i++)
            {
                Console.WriteLine($"{i + 1}: Enter element");
                arrayInput[i] = int.Parse(Console.ReadLine());
                Console.WriteLine(GetNumbersInArray(arrayInput));
            }

            GetNumbersInArray(arrayInput);
            Console.WriteLine("Enter an Integer");
            int target = int.Parse(Console.ReadLine());

            int count = 0;
            foreach(int i in arrayInput)
            {
                if(i == target) count++;
            }
            int check = (count > 1) ? count * target : target;
            return $"Result: {check}";
        }

        public static string LeapYearCalculator(int year)
        {
            return (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0)) ? $"{year} is a Leap Year." : $"{year} is not a Leap Year"; 
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
            int[] result = new int[arr.Length];
            int rowSum = 0;
            string str = "";
            for (int x = 0; x < arr.GetLength(0); x ++) {
                for (int y = 0; y < arr.GetLength(1); y ++) {
                    rowSum += arr[x, y];
                }
                    result[x] = rowSum;
                    str += $"Row Sum for {x + 1} sub array is {rowSum}\n";
                    rowSum = 0;   
            }
            return str;
        }
        static void Main(string[] args)
        {
            //Problem #1
            Console.WriteLine("************Problem #1 Array Max Result************");
            Console.WriteLine(ArrayMaxResult());
            
            //Problem #2
        //     Console.WriteLine("************Problem #2 Leap Year Calculator************");
        //     int[] years = {1986, 2000, 1453, 1993};
        //     Console.WriteLine($"Result Leap Year: {LeapYearCalculator(years[0])}");
        //     Console.WriteLine($"Result Not Leap Year: {LeapYearCalculator(years[1])}");
        //     Console.WriteLine();

        //     //Problem #3
        //     Console.WriteLine("************Problem #3 Perfect Sequence************");
        //     int[] arr1 = {1, 2, 3};
        //     int[] arr2 = {0, 0, 0};
        //     int[] arr3 = {1, 2, 3, 4, 5};
        //     string answerOne = PerfectSequence(arr1);
        //     string answerTwo = PerfectSequence(arr3);
        //     Console.WriteLine($"Result Perfect Sequence: {answerOne}");
        //     Console.WriteLine($"Result Not Perfect Sequence: {answerTwo}");
        //     Console.WriteLine();

        //     //Problem #4
        //     int[,] mArrayOne = new int[3, 5]
        //     { 
        //         { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 } 
        //     };
        //     int[,] mArrayTwo = new int[7, 8]
        //     { 
        //         { 1, 2, 3, 4, 5, 6, 7, 8 }, { 6, 7, 8, 9, 10, 11, 12, 13 }, { 11, 12, 13, 14, 15, 16,17, 20 }, 
        //         { 1, 2, 3, 4, 5, 6, 7, 23 }, { 6, 7, 8, 9, 10, 11, 12, 40 }, { 11, 12, 13, 14, 15, 16,17, 69 }, 
        //         { 1, 2, 3, 4, 5, 6, 10, 420 } 
        //     };
        //     Console.WriteLine("************Problem #4 Sum of Rows************");
        //     Console.WriteLine($"Result 1 with {mArrayOne.GetLength(0)} Rows:\n{SumOfRows(mArrayOne)}");
        //     Console.WriteLine($"Result 2 with {mArrayTwo.GetLength(0)} Rows:\n{SumOfRows(mArrayTwo)}");
        }
    }
}
