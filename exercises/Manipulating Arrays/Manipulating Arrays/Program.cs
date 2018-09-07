using System;

namespace Manipulating_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array_A = { 0, 2, 4, 6, 8, 10 };            
            int[] Array_B = { 1, 3, 5, 7, 9 };          
            int[] Array_C = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };
            
            int sumA = sum(Array_A);            
            int sumB = sum(Array_B);
            int sumC = sum(Array_C);

            Console.WriteLine($"The mean of Array A is {mean(Array_A, sumA)}");
            Console.WriteLine($"The mean of Array B is {mean(Array_B, sumB)}");
            Console.WriteLine($"The mean of Array C is {mean(Array_C, sumC)}");

            Console.WriteLine("The reverse of Array A is:");
            reverse(Array_A);

            Console.WriteLine("The reverse of Array B is:");
            reverse(Array_B);

            Console.WriteLine("The reverse of Array C is:");
            reverse(Array_C);
            
            Console.WriteLine("Array A rotated 2 places to the left is:");
            rotate(Array_A, "left", 2);

            Console.WriteLine("Array B rotated 2 places to the right is:");
            rotate(Array_B, "right", 2);

            Console.WriteLine("Array C rotated 4 places to the left is:");
            rotate(Array_C, "left", 4);

            Console.WriteLine("Array C sorted is:");
            sort(Array_C);
        }

        private static void sort(int[] arr)
        {
            
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int k = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = k;                        
                    }                    
                }
                Console.Write($" {arr[i]}");                
            }
            Console.WriteLine("");
        }

        private static void rotate(int[] arr, string dir, int numshift)
        {
            if (dir == "left")
            {                
                foreach (int i in arr)
                {
                    int j = (numshift % arr.Length);
                    numshift++;
                    Console.Write($" {arr[j]}");
                }            
            }
            else
            {
                int k = (arr.Length - numshift);
                foreach (int i in arr)
                {                  
                    int j = (k % arr.Length);
                    k++;
                    Console.Write($" {arr[j]}");
                }                
            }
            Console.WriteLine("");
        }

        private static void reverse(int[] arr)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {                
                Console.Write($" {arr[i]}");                
            }
            Console.WriteLine("");
        }

        private static double mean(int[] arr, int sum)
        {
            double mean = (double) sum / arr.Length;
            return mean;
        }

        private static int sum(int[] arr)
        {
            int sum = 0;
            foreach (int v in arr)
            {
                sum += v;
            }
            return sum;
        }
    }
}
