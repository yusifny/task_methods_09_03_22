using System;

namespace 2task_methods_09_03_22
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = Repeat("Ha! ", 3);
            Console.WriteLine(answer);
        }

        static string Repeat(string a, int n)
        {
            var result = a;

            for (var i = 0; i < n - 1; i++)
            {
                result = result + a;
            }
            return result;
        }
    }
}
