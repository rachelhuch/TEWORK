using System;

namespace TempConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.Write("Please enter the temperature:");
                string input = Console.ReadLine();
                double temp = double.Parse(input);

                Console.Write("Is the temperature in (C)elcius or (F)arenheit?");
                input = Console.ReadLine();
                if (input.ToLower() != "c")
                {
                    double newTemp = ((temp * 1.8) + 32.0);
                    Console.WriteLine($"{ temp}F is { newTemp}C");
                }
                else
                {
                    double newTemp = ((temp - 32.0) / 1.8);
                    Console.WriteLine($"{temp}C is { newTemp}F");
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
