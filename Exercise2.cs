using System;

namespace ClassWork
{
    public class Exercise2
    {
        public static void SwapMethod()  
            {  
                int  a = 5, b = 10;            
                Console.WriteLine("a = "+a+" b = "+b);

                a = a * b;      
                b = a / b;      
                a = a / b;    
                Console.WriteLine("a = "+a+" b = "+b);       
            }  
    }
}
