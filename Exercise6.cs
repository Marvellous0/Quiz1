using System;

namespace ClassWork
{
    public class Exercise6
    {
        public static void MultiplicationTable()
        {
            int x;

            Console.WriteLine("Enter a number:");
            x = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", x, i, x* i);

            }
        }
    }
}
