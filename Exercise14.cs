using System;

namespace ClassWork
{
    public class Exercise14
    {
        public static void MultiplesFactors()
        {
            Console.WriteLine("Input number: ");
            int x = Convert.ToInt32(Console.ReadLine());

            if (x % 3 == 0 && x % 7 != 0)
            {
                Console.WriteLine($"{x} is a multiple of 3");
            }
            else if (x % 7 == 0 && x % 3 != 0)
            {
                Console.WriteLine($"{x} is a multiple of 7");
            }
            else if (x % 3 == 0 && x % 7 == 0)
            {
                Console.WriteLine($"{x} is a multiple of 3 and 7");
            }
            else
            {
                Console.WriteLine($"{x} is not a multiple of 3 and 7"); 
            }

        }
    }
}
