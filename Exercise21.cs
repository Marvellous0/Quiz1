using System;

namespace ClassWork
{
    public class Exercise21
    {
        public static void SortArray()
        {
            int[] num = new int[] { 1, 9, 6, 7, 5, 9 };

            Console.WriteLine("Unsorted List");

            foreach (int i in num)
            {
                Console.Write(i + " ");
            }

            Array.Sort(num);

            Console.WriteLine("\nSorted List");
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write(num[i] + " ");
            }
        }
    }
}
