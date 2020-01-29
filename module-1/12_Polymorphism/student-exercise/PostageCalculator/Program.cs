using System;

namespace PostageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the weight of the package");
            string input = Console.ReadLine();
           double weight = double.Parse(input);

            Console.WriteLine("Is that in (o)unces or (p)ounds?");
            string input2 = Console.ReadLine();
            if (input2 =="p")
            {
                weight = weight * 16;
            }
            Console.WriteLine("What is the distance (miles) traveled? ");
            string input3 = Console.ReadLine();
            int distance = int.Parse(input3);

            Console.WriteLine("Delivery Method \t\t\t\t\t $Cost");
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Postal Service (1st Class) \t\t\t\t{FirstClass:result}");
            Console.WriteLine($"Postal Service (2nd Class)\t\t\t\t {SecondClass}");
            Console.WriteLine($"Postal Service (3rd Class) \t\t\t\t{ThirdClass}");
            Console.WriteLine($"FexEd \t\t\t\t{FexEd}");

        }
    }
}
