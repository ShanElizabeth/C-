using System;
using System.Runtime.InteropServices;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter Number");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your number is " + number);

            Fib(number);
        }

        public static void Fib(int number)
        {
            int old = 0;
            int nnew=1;
            int num;
            
            for (int i = 1; i <= number; i++)
            {   
                
                Console.WriteLine();
                num = old + nnew;
                Console.WriteLine(num);

                old = nnew;
                nnew = num;
                
            }
        }
    }
}
