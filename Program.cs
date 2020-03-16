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
            string str = "Array: { ";
            foreach(int num in arr) 
            {
                str += $"{Convert.ToString(num)}, ";
            }
            return $"{str}}}";
        }

        public static string GetNumbersInJaggedArray(int[,] arr)
        {
            string str = "Arrays: \n   {\n";
            for(int x = 0; x < arr.GetLength(0); x ++) 
            {
                str += "\t{ ";
                for(int y = 0; y < arr.GetLength(1); y ++) 
                {
                    str += $"{Convert.ToString(arr[x, y])}, ";
                }
                str += "},\n";
            }            
            return str + "   }";
        }

        public static void GetUserInputArray(int [] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write($"Index {i}: Enter element: ");
                array[i] = int.Parse(Console.ReadLine());
                Console.WriteLine(GetNumbersInArray(array));
            }
        }
        
        public static string ArrayMaxResult()
        {
            Console.WriteLine("Enter size of array: ");

            int sizeInput = int.Parse(Console.ReadLine());

            int[] arrayInput = new int[sizeInput]; 

            GetUserInputArray(arrayInput);
            GetNumbersInArray(arrayInput);

            Console.WriteLine("Enter an Integer");

            int target = int.Parse(Console.ReadLine());

            int count = 0;

            foreach(int i in arrayInput)
            {      
                if(i == target) count++;
            }

            int check = count > 1 ? count * target : target;
            return $"Result: {target} showed up {count} time(s)\nTotal: {check}";
        }

        public static string LeapYearCalculator()
        {
            Console.WriteLine("Enter a year: ");
            int year  = int.Parse(Console.ReadLine());
            return ((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0) ? $"{year} is a Leap Year." : $"{year} is not a Leap Year"; 
        }

        public static string PerfectSequence()
        {
            Console.WriteLine("Enter size of array: ");
            int sizeInput = int.Parse(Console.ReadLine());
            int[] arrayInput = new int[sizeInput]; 
            GetUserInputArray(arrayInput);
            int sum = 0;
            int product = 1;
            foreach(int num in arrayInput)
            {
                sum += num;
                product *= num;
            }
            string str = "Perfect Sequence?: ";
            return sum == product ? $"{str}Yes" : $"{str}No"; 
        }

        public static string SumOfRows()
        {
            Console.WriteLine("Enter size of sub-arrays: ");

            int sizeInput = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number of elements in sub-array: ");

            int arrayElement = int.Parse(Console.ReadLine()); 
            
            int[,] arrayInput = new int[sizeInput,arrayElement];

            for (int x = 0; x < arrayInput.GetLength(0); x ++) 
            {
                for (int y = 0; y < arrayInput.GetLength(1); y ++) 
                {
                    Console.Write($"Array {x + 1} Index {y}: Enter element: ");
                    arrayInput[x, y] = int.Parse(Console.ReadLine());
                    GetNumbersInJaggedArray(arrayInput);
                }
            } 

            int[] result = new int[sizeInput];
            int rowSum = 0;
            string str = "";

            for (int x = 0; x < arrayInput.GetLength(0); x ++) 
            {
                for (int y = 0; y < arrayInput.GetLength(1); y ++) 
                {
                    rowSum += arrayInput[x, y];
                }
                    result[x] = rowSum;
                    str += $"Row Sum for {x + 1} sub array is {rowSum}\n";
                    rowSum = 0;   
            }
            return $"\nUser array input: {GetNumbersInJaggedArray(arrayInput)}\n{str}";
        }
        static void Main(string[] args)
        {
            //Problem #1
            Console.WriteLine("************Problem #1 Array Max Result************");
            Console.WriteLine(ArrayMaxResult());
            
            //Problem #2
            Console.WriteLine("\n************Problem #2 Leap Year Calculator************");
            Console.WriteLine(LeapYearCalculator());

            //Problem #3
            Console.WriteLine("\n************Problem #3 Perfect Sequence************");
            Console.WriteLine(PerfectSequence());            

            //Problem #4
            Console.WriteLine("\n************Problem #4 Sum of Rows************");
            Console.WriteLine(SumOfRows());
            int [] arr = {1, 2, 3};
        }
    }
}
