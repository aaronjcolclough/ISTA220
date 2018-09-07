﻿using System;

namespace Animal_Farm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] greg = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
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
                /*int x = i % 3;
                int y = i / 3;*/
                fab[i%3,i/3] = greg[i];
                Console.Write($"{fab[i/3,i%3]} ");


            }
            
        }

    }
}