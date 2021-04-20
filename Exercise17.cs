using System;

namespace ClassWork
{
    public class Exercise17
    {
        public static void SumOfArray()
        {   
            int[] num = new int[] { 9, 28, 23, 4, 7 };
            int sum = 0;

            for (int i = 0; i < num.Length; i++)
            {
                sum = sum + num[i];
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
