using System;

namespace ClassWork
{
    public class Ecercise7
    {
        public static void AddNumbers()
        {
            Console.Write("Input  an integer: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (num != 0)
            {
                sum += num % 10;
                num /= 10;
            }
            Console.WriteLine("Sum of the digits of the integer: " + sum);
        }
    }
}
