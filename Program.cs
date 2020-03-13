using System;

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
        static int ArrayMaxResult(int[] arr, int num)
        {
            int count = 0;
            foreach(int i in arr)
            {
                if(i == num)
                {
                    count++;
                }
            }
            return (count > 1) ? count * num : num;
        }

        static void Main(string[] args)
        {
            int [] array = {1, 2, 3, 4, 4, 4, 5};
            int num = 4;
            Console.WriteLine(ArrayMaxResult(array, num));
        }
    }
}
