using System;

namespace playpen
{
    class Program
    {
        static void Main(string[] args)        
        {
            optionMenu();
        }

        private static void optionMenu()
        {
            Console.WriteLine("1- Sum of grades.");
            Console.WriteLine("2- Assign letter to a grade.");
            Console.WriteLine("3- Average 10 grades and assign a letter grade.");
            Console.WriteLine("4- Average a specific number of grades and assign a letter grade.");
            Console.WriteLine("5- Average an unknown number of grades and assign a letter grade.");
            Console.WriteLine("Enter program to run:");
            int menu = Convert.ToInt32(Console.ReadLine());
            if (menu == 1)
            {
                double start = 0;
                double end = 10;
                double sum = 0;
                get_sum(start, end, sum);
            }
            else if (menu == 2)
            {
                Console.WriteLine("Enter grade to be converted:");
                double grade = Convert.ToDouble(Console.ReadLine());
                char lettergrade = get_letter(grade);
                Console.WriteLine($"The letter grade is {lettergrade}");
            }
            else if (menu == 3)
            {
                double start = 0;
                double end = 10;
                double sum = 0;
                get_ave(start, end, sum);
            }
            else if (menu == 4)
            {
                Console.WriteLine("Enter number of grades to be averaged:");
                double end = Convert.ToInt32(Console.ReadLine());
                double start = 0;
                double sum = 0;
                get_ave(start, end, sum);
            }
            else if (menu == 5)
            {
                double start = 0;
                double sum = 0;
                get_sum(start, sum);
            }
        }

        private static void get_sum(double start, double sum)
        {
            start = start + 1;            
            Console.WriteLine($"Enter grade {start}:");
            double g1 = Convert.ToDouble(Console.ReadLine());
            sum = sum + g1;
            if (g1 == -1)
            {
                Console.WriteLine($"The sum is {sum + 1}");
                get_ave(sum + 1, start - 1);
            }
            else
            {
                get_sum(start, sum);
            }
        }

        private static void get_ave(double start, double end, double sum)
        {
            start = start + 1;
            Console.WriteLine($"Enter grade {start}:");
            double g1 = Convert.ToDouble(Console.ReadLine());
            sum = sum + g1;
            if (start < end)
            {
                get_ave(start, end, sum);
            }
            else
            {
                Console.WriteLine($"The sum is {sum}");
                get_ave(sum, start);
            }
        }

        private static char get_letter(double grade)
        {
            if (grade >= 90) return 'A';
            else if (grade >= 80) return 'B';
            else if (grade >= 70) return 'C';
            else if (grade >= 60) return 'D';
            else return 'F';
        }

        private static void get_sum(double start, double end, double sum)
        {
            start = start + 1;
            Console.WriteLine($"Enter grade {start}:");
            double g1 = Convert.ToDouble(Console.ReadLine());
            sum = sum + g1;
            if  (start < end)
            {
                get_sum(start, end, sum);
            }
            else
            {
                Console.WriteLine($"The sum is {sum}");
            }
        }

        private static void get_ave(double sum, double start)
        {
            double ave = sum / start;
            Console.WriteLine($"The average is {ave}");
            char lettergrade = getletter(ave);
            Console.WriteLine($"The grade is {lettergrade}");
        }

        private static char getletter(double ave)
        {
            if (ave >= 90) return 'A';
            else if (ave >= 80) return 'B';
            else if (ave >= 70) return 'C';
            else if (ave >= 60) return 'D';
            else return 'F';
        }

    }
    
}
