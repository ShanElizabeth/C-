using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number to be factorial");
            int num = Convert.ToInt32(Console.ReadLine());

            Fact1(num);
        }

        public static void Fact1(int num)
        {

            int sum = 1;
            for (int i = num;i>0;i--)
            {
                //Console.WriteLine(i);
                //Console.WriteLine(sum);
                sum *= i;
            }
            Console.WriteLine(sum);
        }
    }
}
