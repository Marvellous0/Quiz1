using System;

namespace ClassWork
{
    public class Exercise8
    {
        public static void Conversion()
        {
            Console.Write("Enter the amount of celsius: ");
            int celsius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kelvin = {0}", celsius + 273);
            Console.WriteLine("Fahrenheit = {0}", celsius * 9 / 5 + 32);
        }
    }
}
