using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Sum = Cem(1, 2, 3);
            Console.WriteLine(Sum);
        }

        static int Cem(params int[] arr)
        {
            int sum = 0;

            for (var i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
    }
}