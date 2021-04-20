using System;

namespace ClassWork
{
    public class Exercise15
    {
            public static void MinMax()
            {
                Console.WriteLine("Enter first number: ");
                double x = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter second number: ");
                double y = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Input third integer:");
                double z = Convert.ToDouble(Console.ReadLine());

                if (x < y && x < z)
                {
                    Console.WriteLine($"The Lowest number is: {x}");
                }

                else if (y < z)
                {
                    Console.WriteLine($"The lowest number is: {y}");
                }

                else
                {
                    Console.WriteLine($"The lowest number is: {z}");
                }

                if (x > y && x > z)
                {
                    Console.WriteLine($"The largest number is: {x}");
                }

                else if (y > z)
                {
                    Console.WriteLine($"The largest number is: {y}");
                }

                else
                {
                    Console.WriteLine($"The largest number is: {z}");
                }


            }
    }
}
