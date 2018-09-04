using System;

namespace Animal_Farm
{
    class Program
    {
        static void Main(string[] args)
        {
            //int start = 2;
            Console.WriteLine("0, 1");
            fibonacci(0, 1, 2);            
        }

        private static void fibonacci(int v1, int v2, int start)
        {
            start++;
            int end = 9;
            int sum = v1 + v2;            

            if (start < end)
            {
                Console.WriteLine($"{v2}, {sum}");
                fibonacci(v2, sum, start);                                
            }
            else
            {
                Console.WriteLine($"{v2}, {sum}");
                Console.WriteLine($"Number {start} in the Fibonacci Sequence is {sum}");
            }
        }
    }
}
