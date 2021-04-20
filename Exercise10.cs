using System;

namespace ClassWork
{
    public class Exercise10
    {
        public static void PositionChange()
        {
            string words;

            Console.Write("Enter a sentence : ");
            words = Console.ReadLine();

            if (words.Length >= 1)
            {
                var s = words.Substring(0, 1);
                Console.WriteLine(s + words + s);
            }
        }
    }
}
