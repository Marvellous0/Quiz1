using System;

namespace ClassWork
{
    public class Exercise16
    {
        public static void StringOddPosition()
        {
            Console.Write("Enter a string : ");
            string word = Console.ReadLine();

            string result = string.Empty;

            for (var i = 0; i < word.Length; i++)
            {
                if (i % 2 == 0) result += word[i];
            }
            Console.WriteLine(result);
        }
    }
}
