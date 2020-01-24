using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards.Models
{
    //add public for access modifier 
    public class Car
    {
        //Automatic Properties
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }


        /// <summary>
        /// Derived property to get the age of the car.
        /// </summary>
        public int Age
        {
            get
            {
                return DateTime.Now.Year - this.Year;
            }
        }
        /// <summary>
        /// Gets the Speed of the Car. To change speed, use the Accelerate method.
        /// </summary>
        public int Speed { get; private set; }

        /// <summary>
        /// Increases the speed of the car by 1 mph
        /// </summary>
        /// <returns>Returns the current speed of the car after acceleration</returns>
        public int Accelerate()
        {
            this.Speed++;
            return this.Speed;
        }
        /// <summary>
        /// Increase the speed of the car by a user defined amount
        /// </summary>
        /// <param name="delta"> Amount to increase speed</param>
        /// <returns></returns>
        public int Accelerate(int delta)
        {
            this.Speed += delta;
            return this.Speed;
        }
        public Car()
        {
            Console.WriteLine("The default constructor for Car was called");
        }
        public Car(string make, string model, int year)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;

        }
    }
}



