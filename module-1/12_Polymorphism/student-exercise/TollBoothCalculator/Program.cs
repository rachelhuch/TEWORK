using System;
using System.Collections.Generic;
using TollBoothCalculator.Classes;

namespace TollBoothCalculator
{
    class Program
    {
        static void Main(string[] args)
    {
        List<IVehicle> tollCalculator = new List<IVehicle>();

            //car, named car 1, new car, bool on trailors
            Car car1 = new Car(true);
            //add it to the list
            tollCalculator.Add(car1);

            Truck truck1 = new Truck(6);
            tollCalculator.Add(truck1);

            Tank tank1 = new Tank();
            tollCalculator.Add(tank1);


            Random random = new Random();
            int totalDistance = 0;
            double totalTolls = 0;

            Console.WriteLine($"Vehicle \t Distance Traveled \t Toll");
            Console.WriteLine("--------------------------");
            foreach (IVehicle item in tollCalculator)
            {
                if (item is Car)
                {
                    //randomizer
                    int carDistance = random.Next(1, 1000);
                    totalDistance += carDistance;
                    totalTolls += item.CalculateToll(carDistance);
                    Console.WriteLine($"Car \t\t {carDistance} \t\t {item.CalculateToll(carDistance):C}");
                }
                else if (item is Truck)
                {
                    int truckDistance = random.Next(1, 1000);
                    totalDistance += truckDistance;
                    totalTolls += item.CalculateToll(truckDistance);
                    Console.WriteLine($"Truck \t\t {truckDistance} \t\t {item.CalculateToll(truckDistance):C}");

                }
                else
                {
                    int tankDistance = random.Next(1, 1000);
                    totalDistance += tankDistance;
                    Console.WriteLine($"Tank \t\t {tankDistance} \t\t {item.CalculateToll(tankDistance):C}");


                }
                Console.WriteLine();
                Console.WriteLine($"Total Miles Traveled: \t\t {totalDistance}");
                Console.WriteLine($"Total Tolls : \t\t {totalTolls}");
            }



        }
    }

    }

