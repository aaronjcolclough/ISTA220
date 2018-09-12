using System;

namespace MathsFormulas
{
    class Program
    {
        static void Main(string[] args)
        {
            //tell user what they are doing
            Console.WriteLine("\nPart 1 Circumference and Area of a circle");

            //get radius of circle
            Console.WriteLine("Enter the radius of the circle:");
            string radius1 = Console.ReadLine();
            float r1 = float.Parse(radius1);
            
            //multiply radius by 2pi
            float area1 = 2 * (float) Math.PI * r1;

            //multiply radius squared by pi
            float circumference = (float) Math.PI * (float) Math.Pow(r1, 2);
            
            //tell user circumference and area of circle
            Console.WriteLine($"The circumference of the circle is {circumference}.");
            Console.WriteLine($"The area of the circle is {area1}.");

            //tell user what they are doing
            Console.WriteLine("\nPart 2 Volume of a Hemisphere");

            //get the radius of the circle
            Console.WriteLine("Enter the radius of the circle:");
            string radius2 = Console.ReadLine();
            float r2 = float.Parse(radius2);

            //determine the volume of a hemisphere
            float volume = (float) ((4.0 / 3.0) * Math.PI * Math.Pow(r2, 3)) / 2;

            //tell user volume of hemisphere
            Console.WriteLine($"The volume of a hemisphere of the circle is {volume}.");

            //tell user what they are doing
            Console.WriteLine("\nPart 3 Area of a Triangle (Heron's Formula)");

            //get length of side 1
            Console.WriteLine("Enter length of first side:");
            string side1 = Console.ReadLine();
            int s1 = int.Parse(side1);

            //get length of side 2
            Console.WriteLine("Enter length of second side:");
            string side2 = Console.ReadLine();
            int s2 = int.Parse(side2);

            //get length of side 3
            Console.WriteLine("Enter length of third side:");
            string side3 = Console.ReadLine();
            int s3 = int.Parse(side3);

            //use Heron's Formula to calculate area
            float p = (s1 + s2 + s3) / 2;
            float area2 = (float) Math.Sqrt(p * (p - s1) * (p - s2) * (p - s3));

            //tell user area of triangle
            Console.WriteLine($"The area of the triangle is {area2}.");

            //tell user what they are doing
            Console.WriteLine("\nPart 4 Solving a Quadratic Equation");

            //get first coefficient
            Console.WriteLine("Enter the value of a:");
            string coeffa = Console.ReadLine();
            int a = int.Parse(coeffa);

            //get second coefficient
            Console.WriteLine("Enter the value of b:");
            string coeffb = Console.ReadLine();
            int b = int.Parse(coeffb);

            //get third coefficient
            Console.WriteLine("Enter the value of c:");
            string coeffc = Console.ReadLine();
            int c = int.Parse(coeffc);

            //use quadratic equation to solve for x
            float x = (float) (-b + Math.Sqrt((b * b) - 4 * a * c)) / (2 * a);
            float x2 = (float) (-b - Math.Sqrt((b * b) - 4 * a * c)) / (2 * a);

            //tell user values of x
            Console.WriteLine($"x = {x} and {x2}.");
        }
    }
}
