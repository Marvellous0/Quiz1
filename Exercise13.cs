using System;

namespace ClassWork
{
    public class Exercise13
    {
        public static void LongestString()
        {
            string[] stringList;
            int max = 0;

            Console.WriteLine("Enter a sentence: ");
            string sentence = Console.ReadLine();

            stringList = sentence.Split(' ');

            for (int i = 0; i < stringList.Length; i++)
            {
                if(stringList[i].Length > max)
                {
                    max = stringList[i].Length;
                    Console.WriteLine($"Longest string is : {stringList[i]}");
                }
            }


        }
    }
}
