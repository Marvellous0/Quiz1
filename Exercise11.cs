using System;

namespace ClassWork
{
    public class Exercise11
    {
         public static void SumAddition()
         {

            Console.WriteLine("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (num1 == num2)
            {
                double result = (num1 + num2) * 3;
                Console.WriteLine($"sum triple = {result}");
            }
            else
            {
                double total = num1 + num2;
                Console.WriteLine($"sum = {total}");
            }
         }
    }
}
