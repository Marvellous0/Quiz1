using System;

namespace ClassWork
{
    public class Exercise9
    {
        public static void RemoveCharacter()
        {
            Console.WriteLine(remove_char("Fahrenheit", 7));
            Console.WriteLine(remove_char("Fahrenheit", 11));
        }
        public static string remove_char(string str, int n)
        {
            return str.Remove(n, 1);
        }  
    }
}
