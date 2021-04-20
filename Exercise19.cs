using System;

namespace ClassWork
{
    public class Exercise19
    {
        public static void Arrays()
        {
            int[] nums = { 5, 6, 8, 3, 9, 10, 11, 14};
            Console.WriteLine("\nOriginal array: [{0}]", string.Join(", ", nums));
            Console.WriteLine("Check if an array contains an odd number? " + OddNumbers(nums));

        }

        public static bool OddNumbers(int[] nums)
        {
            foreach (var n in nums)
            {
                if (n % 2 != 0)
                {
                    return true;
                }

            }
            return false;
        }
    }
}
