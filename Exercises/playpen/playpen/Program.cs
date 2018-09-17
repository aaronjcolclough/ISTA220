using System;

namespace Animal_Farm
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int[] greg = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[,] enzo = new int[3, 3];

            for (int i = 0; i < greg.Length / 3; i++)
            {
                for (int j = 0; j < enzo.Length / 3; j++)
                {
                    enzo[i,j] = greg[3 * i + j];
                    Console.Write($"{enzo[i,j]}");
                }
                Console.WriteLine($"");                
            }
            
            for (int i = 0; i < enzo.Length; i++)
            {
                int x = i / 3;
                int y = i % 3;
                Console.Write($"{enzo[x, y]} ");
            }
            Console.WriteLine("");

            int[,] fab = new int[3,3];
            for (int i = 0; i < 9; i++)
            {
                int x = i % 3;
                int y = i / 3;
                fab[i%3,i/3] = greg[i];
                Console.Write($"{fab[i/3,i%3]} ");


            }
            Console.WriteLine("Enter Year:");
            int cent = Convert.ToInt32(Console.ReadLine());
            int cent2 = (cent / 100) + 1;
            Console.WriteLine($"It's the {cent2} st/rd century.");*/

            int hfv1 = 0;
            
            for (int i = 1, j = 1; i < 24 || j < 28; i++, j++)
            {                
                if (24 % i == 0 && 28 % j == 0)
                {
                    hfv1 = i;                    
                }
            }
            Console.WriteLine(hfv1);
            
        }


    }
}