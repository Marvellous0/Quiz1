using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork
{
    public class Exercise5
    {
        public static void List()
        {
            string line = "The sun rise in the morning.";

            Console.WriteLine("\nOriginal String: " + line);
            string result = "";

            List<string> wordsList = new List<string>();
            string[] words = line.Split(new[] { " " }, StringSplitOptions.None);

            for (int i = words.Length - 1; i >= 0; i--)
            {
                result += words[i] + " ";
            }

            wordsList.Add(result);

            foreach (String s in wordsList)
            {
                Console.WriteLine("\nReverse String: " + s);
            }
        }
    
    }
}
