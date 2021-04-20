using System;

namespace ClassWork
{
    public class Exercise20
    {
        static void GetCentury()
        {
            Console.WriteLine("Enter year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            int result = (year / 100) + ((year % 100 == 0) ? 0 : 1);
            Console.WriteLine($"{result} century");
        }
    }
}
