using System;
using System.Collections.Generic;
using PostageCalculator.Classes;

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

            List<IDeliveryDriver> companies = new List<IDeliveryDriver>();

            FirstClass firstClass = new FirstClass(distance, weight);
            companies.Add(firstClass);

            SecondClass secondClass = new SecondClass(distance, weight);
            companies.Add(secondClass);

            ThirdClass thirdClass = new ThirdClass(distance, weight);
            companies.Add(thirdClass);

            FexEd fexEd = new FexEd(distance, weight);
            companies.Add(fexEd);

            SPU spu = new SPU(distance, weight);
            companies.Add(spu);

            SPU2DAY spu2Day = new SPU2DAY(distance, weight);
            companies.Add(spu2Day);

            SPUNEXTDAY spuNextDay = new SPUNEXTDAY(distance, weight);
            companies.Add(spuNextDay); 

            //add UPS


            Console.WriteLine("Delivery Method \t\t\t\t\t $Cost");
            Console.WriteLine("----------------------------------");

            foreach (IDeliveryDriver item in companies)
            {
                if (item is FirstClass)
                {
                    Console.WriteLine($"Postal Service (1st Class) \t\t\t\t{item.CalculateRate(distance, weight):C}");
                }
                else if (item is SecondClass)
                {
                    Console.WriteLine($"Postal Service (2nd Class\t\t\t\t {item.CalculateRate(distance, weight):C}");

                }
                else if (item is ThirdClass)
                {
                    Console.WriteLine($"Postal Service (2nd Class\t\t\t\t{item.CalculateRate(distance, weight):C}");
                }
                else if (item is FexEd)
                {
                    Console.WriteLine($"FexEd {item.CalculateRate(distance, weight):C}");
                }
                else if (item is SPU)
                {
                    Console.WriteLine($"SPU 4 day {item.CalculateRate(distance, weight):C} ");
                }
                else if (item is SPU2DAY)
                {
                    Console.WriteLine($"SPU 2 day {item.CalculateRate(distance, weight):C} ");
                }
                else if (item is SPUNEXTDAY)
                {
                    Console.WriteLine($"SPU Next Day {item.CalculateRate(distance, weight):C}");
                }
            }

            //add in rest

           
            

        }
    }
}
