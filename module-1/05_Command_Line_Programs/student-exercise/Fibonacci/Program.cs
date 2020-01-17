using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the Fibonacci number:");
            string value = Console.ReadLine();
            int num = int.Parse(value);

            int fibOne = 0;
            int fibTwo = 1;
            int fibThree = 0;
            string toPrint = "0,1";
            Console.Write(toPrint);
            

            for (int i = 0; fibThree < num; i++)
            {
                fibThree = fibOne + fibTwo;
                if (fibThree < num)
                {
                    Console.Write($",{fibThree}"); 
                }

                fibOne = fibTwo;
                fibTwo = fibThree;
            }
            {
                

            }
        }
    }
}
