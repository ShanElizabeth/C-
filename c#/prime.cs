using System;

namespace prime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PLease enter a number to check if its prime or not ");
            int num = Convert.ToInt32(Console.ReadLine());

            //call prime num function

            if (Prime(num)){
                Console.WriteLine("Not A Prime Numbre");
            }

            else
            {
                Console.WriteLine("A Prime Numbre");
            }
         }

        public static bool Prime(int num)
        {
            
            int j = num / 2;

            for (int i = 2; i < j; i++)
            {
                if (num % i == 0)
                {
                    
                    return (true);
                }
            }

            return (false);
            
            
            


        }
    }
}
