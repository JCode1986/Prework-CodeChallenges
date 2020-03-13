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
            int num = 1;
            Console.WriteLine(ArrayMaxResult(array, num));
        }
    }
}
