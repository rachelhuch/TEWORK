using System;

namespace LinearConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.Write("Please enter the length:");
                string input = Console.ReadLine();
                decimal length = decimal.Parse(input);

                Console.Write("Is the measurement in (m), or (f)?");
                input = Console.ReadLine();
                if (input.ToLower() != "m")
                {
                    decimal newLength = (length * 0.3048M);
                    Console.WriteLine($"{length}f is {newLength}m");
                }
                else
                {
                    decimal newLength = ((length * 3.2808399M));
                    Console.WriteLine($"{length}m is {newLength}f");
                }
                Console.WriteLine("Would you like to repeat? y/n");
                input = Console.ReadLine();
                if (input.ToLower() != "y")
                {
                    break;
                }

            }
        }
    }
}
